
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Day
{
    //properties
    private string report;
    public string Report { get { return report; } set { report = value; } }

    private int number;
    public int Number { get { return number; } }


    private bool outside;
    public bool Outside { get { return outside; } set { outside = value; } }


    private List<Activity> l_activity;
    public List<Activity> L_activity { get { return l_activity; } }

    private Place map_hq;
    public Place Map_hq { get { return map_hq; } }


    //constructor

    public Day(int _number, Place _map_hq)
    {
        number = _number;
        map_hq = _map_hq;
        l_activity = new List<Activity>();

        Activity defaultAct = new Inside(0, 147, map_hq);
        for (int i = 0; i <= 147; i++) //24*6+4 -1 because no activity at 24:40
        {
            //create default activity
            l_activity.Insert(i, defaultAct);
        }
    }

    //methodes


    public void addActivity(Activity newActivity)
    {
        //add an activity and remove the previous one
        for (int i = newActivity.Start; i < newActivity.End; i++)
        {
            l_activity[i] = newActivity; 
        }
        sortActivityList(); 
    }


    //remove an activity and replace it by an activity by default
    //it is possible to remove only a part of the activity => when you make it shorter for instance
    public void rmActivity(Activity prevActivity)
    {       
        rmActivity(prevActivity, prevActivity.Start, prevActivity.End);
    }

    public void rmActivity(Activity prevActivity, int start, int end)
    {
        //has to check that the activity is on the list
        //has to check that the part of the activity to remove is included in activity
        if ((l_activity.Contains(prevActivity)))// && (prevActivity.Start <= start) && (prevActivity.End >= end))
        {
            //replace the remove activity by the default one which is private at the hq
            Activity newActivity = new Inside(start, end, map_hq);
            addActivity(newActivity);
        }
        else
        {
            //error message
        }
    }

    public void modifyHoursActivity(Activity prevActivity, int newStart, int newEnd)
    {

        //we have to create a new activity and not only update the previous one not to have problems with sortActivity
        Activity newActivity;

        if (prevActivity is Inside) { newActivity = new Inside(newStart, newEnd, prevActivity.Place, prevActivity.Type); }
        else { newActivity = new Outside(newStart, newEnd, prevActivity.Place, prevActivity.Type); }
        newActivity.Description = prevActivity.Description;
        newActivity.L_astronaut = prevActivity.L_astronaut;

        rmActivity(prevActivity);
        addActivity(newActivity);

    }

    public void modifyContentActivity(Activity prevActivity, string newDescription)
    {
        prevActivity.Description = newDescription;
    }

    public void modifyContentActivity(Activity prevActivity, Place newPlace)
    {
        prevActivity.Place = newPlace;
    }

    public void sortActivityList()
    {
        //this function sort a list and its activity in order them to be coherent
        
        for (int i = 0; i < l_activity.Count -1 ; i++)//Stop at Count -1 because of i+1
        {
            //if two consecutive activities are different
            if (!(l_activity[i].Equals(l_activity[i + 1])))
            {
                //but have the same type and place, it is considered as being the same activity
                // So we merge the both activities
                if ((l_activity[i].Type.Equals(l_activity[i + 1].Type))
                    && (l_activity[i].Place.Equals(l_activity[i + 1].Place)))
                {
                    //extend the end and merge descriptions before merging the entire activity
                    l_activity[i].End = l_activity[i + 1].End;
                    l_activity[i].Description = l_activity[i].Description + l_activity[i + 1].Description; //join the both description
                    l_activity[i + 1] = l_activity[i];
                }
                //elsewise, we reschedule the previous and forward activity activities
                else
                {
                    //We have to create a new activity instead of updating the previous one
                    //We check that the current ativity is not already rescheduled not to process twice

                    if (l_activity[i].End != i + 1)
                    {
                        if (l_activity[i] is Inside) { l_activity[i] = new Inside(l_activity[i].Start, i + 1, l_activity[i].Place, l_activity[i].Type); }
                        else { new Inside(l_activity[i].Start, i + 1, l_activity[i].Place, l_activity[i].Type); }

                        for (int j = l_activity[i].Start; j < l_activity[i].End; j++)
                        {
                            l_activity[j] = l_activity[i];
                        }
                    }
                    //We check that the next ativity is not already rescheduled not to process twice
                    if (l_activity[i + 1].Start != i + 1)
                    {
                        //need a mean to check if we can delete or not
                        //l_activity[i + 1] = l_activity[i];
                        if (l_activity[i + 1] is Inside) { l_activity[i + 1] = new Inside(i + 1, l_activity[i + 1].End, l_activity[i + 1].Place, l_activity[i + 1].Type); }
                        else { new Inside(i + 1, l_activity[i + 1].End, l_activity[i + 1].Place, l_activity[i + 1].Type); }

                        for (int j = l_activity[i + 1].Start; j < l_activity[i + 1].End; j++)
                        {
                            l_activity[j] = l_activity[i + 1];
                        }
                    }

                }

            }
        }

    }
}



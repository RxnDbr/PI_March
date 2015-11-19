
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

    public Day(int _number, Place map_hq)
    {
        number = _number;
        Activity defaultAct = new Inside(0, 147, map_hq);
        for (int i = 0; i <= 147; i++) //24*6+4 -1 because no activity at 24:40
        {
            //create default activity
            l_activity[i] = defaultAct;
        }
    }

    //methodes


    //don't mind what you remove
    public void addActivity(Activity newActivity)
    {
        for (int i = newActivity.Start; i <= newActivity.End; i++)
        {
            l_activity[i] = newActivity;
        }
    }

    public void rmActivity(Activity prevActivity)
    {
        if (l_activity.Contains(prevActivity))
        {
            rmActivity(prevActivity, prevActivity.Start, prevActivity.End);
        }
    }

    public void rmActivity(Activity prevActivity, int start, int end)
    {
        if ((l_activity.Contains(prevActivity)) && (prevActivity.Start <= start) && (prevActivity.End >= end))
        {
            //replace the remove activity by the default one which is private at the hq
            Activity newActivity = new Inside(start, end, map_hq);
            addActivity(newActivity);
        }
        else
        {
            //message erreur
        }
    }

    public void modifyHoursActivity(Activity prevActivity, int newStart, int newEnd)
    {
        if ((prevActivity.Start < newStart) && (newEnd < prevActivity.End))
        {
            //error message
        }
        else if (prevActivity.Start < newStart)
        {
            rmActivity(prevActivity, prevActivity.Start, newStart);
        }

        else if (newEnd < prevActivity.End)
        {
            rmActivity(prevActivity, newEnd, prevActivity.End);
        }

        prevActivity.Start = newStart;
        prevActivity.End = newEnd;

        //addActivity(prevActivity); is this useful ? 

    }

    public void modifyContentActivity(Activity prevActivity, string newDescription)
    {
        prevActivity.Description = newDescription;
    }

    public void modifyContentActivity(Activity prevActivity, Place newPlace)
    {
        prevActivity.Place = newPlace;
    }


}



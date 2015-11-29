
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Day
{
    #region attributes

    protected int number;
    public int Number { get { return number; } }

    protected List<Activity> l_activity;
    public List<Activity> L_activity { get { return l_activity; } set {l_activity = value;} }

    protected Place map_hq;
    public Place Map_hq { get { return map_hq; } }

    #endregion

    #region constructor

    public Day(int _number, Place _map_hq)
    {
        number = _number;
        map_hq = _map_hq;
        l_activity = new List<Activity>();
        createDfaultActList();
        sortActivityList();
    }

    #endregion

    #region methodes

    #region sort / update activity list

    public void sortActivityList()
    {
        //this function sorts a list and its activities in order them to be coherent
        
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
    #endregion

    #region outside activities

    public bool isOutside() 
    {
        foreach(Activity act in l_activity) 
        {
            if (act is Outside) {return true;}
        }
        return false;
    }
    #endregion

    #region intern methodes
    private void createDfaultActList()
    {
        Activity sleeping1 = new Inside(0, 7 * 6, map_hq, "sleeping");
        Activity sleeping2 = new Inside(22 * 6, 147, map_hq, "sleeping");
        Activity eating1 = new Inside(12 * 6, 13 * 6, map_hq, "eating");
        Activity eating2 = new Inside(19 * 6, 20 * 6, map_hq, "eating");
        Activity defaultAct1 = new Inside(7 * 6, 12 * 6, map_hq, "private");
        Activity defaultAct2 = new Inside(13 * 6, 19 * 6, map_hq, "private");
        Activity defaultAct3 = new Inside(20 * 6, 22 * 6, map_hq, "private");

        for (int i = 0; i <= 147; i++) //24*6+4 -1 because no activity at 24:40
        {
            if (i >= 0 && i < 7 * 6) { l_activity.Insert(i, sleeping1); }
            else if (i >= 7 * 6 && i < 12 * 6) { l_activity.Insert(i, defaultAct1); }
            else if (i >= 12 * 6 && i < 13 * 6) { l_activity.Insert(i, eating1); }
            else if (i >= 13 * 6 && i < 19 * 6) { l_activity.Insert(i, defaultAct2); }
            else if (i >= 19 * 6 && i < 20 * 6) { l_activity.Insert(i, eating2); }
            else if (i >= 20 * 6 && i < 22 * 6) { l_activity.Insert(i, defaultAct3); }
            else if (i >= 22 * 6 && i < 147) { l_activity.Insert(i, sleeping2); }
            else { l_activity.Insert(i, defaultAct1); }
        }

    }
    #endregion
    #endregion
}



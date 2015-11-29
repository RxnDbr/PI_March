using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Present : Day
{
    public override string Report { get { return report; } set { report = value.Substring(0, 1000); } }

    public Present(int _number, Place _map_hq) : base(_number, _map_hq) { }
    #region Add, Remove or modify the activities list


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

    public void rmActivity(Activity prevActivity)
    {
        rmActivity(prevActivity, prevActivity.Start, prevActivity.End);
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

    #endregion


}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Activity
{
    #region attributes

    protected string description;
    public string Description { get { return description; } set { description = value; } }

    protected string type;
    public string Type { get { return type; } }

    protected List<Astronaut> l_astronaut;
    public List<Astronaut> L_astronaut { get { return l_astronaut; } set { l_astronaut = value; } }

    protected Place place;
    public abstract Place Place;

    protected int start;
    public int Start { get { return start; } set { start = value; } }

    protected int end;
    public int End { get { return end; } set { end = value; } }

    #endregion

    #region constructor

    public Activity(int _start, int _end, Place _place, string _type = "private")
    {
        //choose the place in a list / with the map. If it's not there, create it
        start = _start;
        end = _end;
        place = _place;
        type = _type;
    }

    #endregion

    #region methodes

    #region updates methodes
    public void addDescription(string _description)
    {
        description = _description;
    }

    public void addAstronaut(Astronaut _astronaut)
    {
        l_astronaut.Add(_astronaut);
    }
    #endregion

    #endregion

}


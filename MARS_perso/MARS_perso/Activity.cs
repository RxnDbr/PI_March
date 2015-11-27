
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Activity
{
    private string description;
    public string Description { get { return description; } set { description = value; } }

    private string type;
    public string Type { get { return type; } }

    private List<Astronaut> l_astronaut;
    public List<Astronaut> L_astronaut { get { return l_astronaut; } set { l_astronaut = value; } }

    private Place place;
    public Place Place { get { return place; } set { place = value; } }

    private int start;
    public int Start { get { return start; } set { start = value; } }

    private int end;
    public int End { get { return end; } set { end = value; } }

    public Activity(int _start, int _end, Place _place, string _type = "private")
    {
        //choose the place in a list / with the map. If it's not there, create it
        start = _start;
        end = _end;
        place = _place;
        type = _type;
    }

    public void addDescription(string _description)
    {
        description = _description;
    }

    public void addAstronaut(Astronaut _astronaut)
    {
        l_astronaut.Add(_astronaut);
    }

}


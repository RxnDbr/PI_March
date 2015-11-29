
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Outside : Activity
{
    private Place place;
    public Place Place { get { return place; } set { place = value; } }

    public Outside(int _start, int _end, Place _place, string _type) : base(_start, _end, _type) 
    {
        place = _place;
    }
}



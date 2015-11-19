
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Place
{
    //attributes, properties and accessors

    private double map_x;
    public double X { get { return map_x; } set { map_x = value; } }


    private double map_y;
    public double Y { get { return map_y; } set { map_y = value; } }

    private string name;
    public string Name { get { return name; } set { name = value; } }

    private int[] base_hq;
    public int[] Base_hq { get { return base_hq; } }


    private List<Outside> l_outside;
    public List<Outside> L_Outside { get { return l_outside; } set { l_outside = value; } }

    //constructor

    public Place(double _map_x, double _map_y, string _name, int[] _base_hq)
    {
        map_x = _map_x;
        map_y = _map_y;
        name = _name;
        base_hq = _base_hq;
    }

    public Place(int _click_x, int _click_y, string _name)
    {
        /*x = convertisseur (pixel_x);
        y = ..;
        Place(x,y, name)*/
    }

    //methodes

    // horizontal = true :
    // --> converti coordonnée x
    // horizontale = false :
    // --> converti coordonnée y

    public double convertClickToMap(int _coordonnée, bool horizontal)
    {
        if (horizontal)
        {

        }
        return 0.0;
    }


}

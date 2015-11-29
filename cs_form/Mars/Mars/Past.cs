
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Past : Day
{
    public override string Report { get { return report; } set { report = value.Substring(0, 1000); } }

    public Past(int _number, Place _map_hq) : base(_number, _map_hq) { }

}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars
{
    public class Past : Day
    {
        public Past(int _number, Place _map_hq) : base(_number, _map_hq) { }
        public virtual string getReport()
        {
            throw new System.NotImplementedException();
        }

    }

}
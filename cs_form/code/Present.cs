
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars
{
    public class Present : Day
    {
        public Present(int _number, Place _map_hq) : base(_number, _map_hq) { }
        public virtual void setReport(string report)
        {
            throw new System.NotImplementedException();
        }

        public virtual void modifyActivity(Activity newActivity)
        {
            throw new System.NotImplementedException();
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Future : Day
{
    public Future(int _number, Place _map_hq) : base(_number, _map_hq) { }
    public virtual void modifyActivity(Activity newActivity)
    {
        throw new System.NotImplementedException();
    }

}


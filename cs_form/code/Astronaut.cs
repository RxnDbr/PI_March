
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Mars
{
    public class Astronaut
    {
        private string nom
        {
            get;
            set;
        }

        private string prenom
        {
            get;
            set;
        }

        public virtual IEnumerable<Activity> l_activity
        {
            get;
            set;
        }

    }
}

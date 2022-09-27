using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Todo.Data
{
    internal class Todopersonsequencer
    {
        private static int nameid;
        public Todopersonsequencer(int Nextid)
        {
            nameid = Nextid;
        }
        public int Nextid()
        {
            nameid++;
            return nameid;      

        }
        public void reset()
        {
            nameid = 0;
        }

    }

}


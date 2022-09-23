using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Data
{
    internal class Todopersonsequencer
    {
        private int nameid;
        private int Reset;
        public Todopersonsequencer(int Nextid)
        {
            this.nameid = Nextid;
            Reset = 0;
        }
        public int Nextid
        {
            get
            {

                return nameid++;

            }
            set
            {
                nameid = value;
            }

        }
        public int reset
        {
            get
            {
                return Reset;
            }

        }

    }

}


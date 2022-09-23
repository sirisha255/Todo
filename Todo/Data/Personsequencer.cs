using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Data
{
    public class Personsequencer
    {
        private int Personid;
        private int Reset;
        public  Personsequencer(int NextPersonid)
        {
            this.Personid = NextPersonid;
            Reset = 0;
        }
        public int NextPersonid
        {
            get
            {
               
                return Personid++;
               
            }
            set
            {
                Personid = value;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Todo.Models;


namespace Todo.Data
{
    public class Personsequencer
    {
        private static int Personid;
        public Personsequencer(int NextPersonid)
        {
            Personid = NextPersonid;

        }
        public static  int GetPersonid()
        {
            return Personid;
        }
        public static int NextPersonid()
        {
            Personid++;
            return Personid;

        }
        public void Reset()
        {
            Personid = 0;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Models
{
    public class Todo1
    {
        private readonly int Id;
        private string Description;
       // private bool done;
       // Person assignee;
        public Todo1(int id, string description)// bool done, Person assignee)
        {
            this.Id = id;
            Description = description;
            //this.done = true;
            //this.assignee = assignee;
        }
        public int id
        {
            get { return Id; }

        }
        public string description
        {
            get { return Description; }
            set { Description = value; }
        }
       // public bool Done
       // {
       //     get { return done; }
            

       // }
     //   public Person Assignee
     //   {
      //      get { return assignee; }
     //       set { assignee = value; }
     //   }
    }
}

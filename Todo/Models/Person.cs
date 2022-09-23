using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Todo.Models
{
    public class Person
    {
        private readonly int Id;
        private string? Name1;
        private string? Name2;
        public Person(int id, string firstname, string lastname)
        {
            this.Id = id;
            Name1 = firstname;
            Name2 = lastname;
        }
        public int id
        { get
            {
                return Id;
            }
        }
        public string firstname
        {
            get
            {
                return Name1;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("first name cannot be null or empty");
                }
                else { }

            }
        }
        public string lastname
        {
            get
            {
                return Name2;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("second name cannot be null or empty");
                }
                else { }
            }
        }
    }
}

   
    

    


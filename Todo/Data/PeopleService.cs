using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Todo.Models;


namespace Todo.Data
{
    public class PeopleService
    {

        private static Person[] persons = new Person[0];
       public Person[] Persons
       {
            get
            {
                return persons;

            }
            set
            {
                persons = value;
            }
            
        }
        public int size()
        {
            return Persons.Length;
        }
        public Person[] FindAll()
        {
            return Persons;
        }
        public Person? FindById( int id)
        {
            foreach (Person person in Persons) 
            {
                if(person.id == id)
                    return person;

            }
            return null;
            
        } 
        public Person newPersons(string name1,string name2)
       {
            Person newPersontoadd = new Person(name1, name2, Personsequencer.NextPersonid(Personsequencer.GetPersonid()));
          Array.Resize(ref persons, persons.Length + 1);
          persons[persons.Length - 1] = newPersontoadd;
           return newPersontoadd;
       }

        public void Clear()
        {
            persons = new Person[0];
        }
        public void removeperson()
        {
            for(int i = 0; i < persons.Length; i++)
            {
                if (persons[i].id = Id)
                    for(int offset = i + 1; offset < persons.Length; offset++)
                    {
                        persons[i] = persons[offset];
                    }
                Array.Resize(ref persons, persons.Length-1);
                break;
            }
            

        }
    }

}


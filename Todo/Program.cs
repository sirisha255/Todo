using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Models;
using Todo.Data;


namespace Todo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(11, "siri", "tadepalli");
            Console.WriteLine(person.id + "  " + person.firstname + "  " + person.lastname);
            Console.ReadLine();

            Todo1 todo = new Todo1(12, "Happy coding");
            Console.WriteLine(todo.id + "  " + todo.description);
            Console.ReadLine();

            Personsequencer ps = new Personsequencer(13);
            Console.WriteLine(ps.NextPersonid);
            Console.ReadLine();
           Console.WriteLine(ps.reset);

            Todopersonsequencer tps = new Todopersonsequencer(20);
            Console.WriteLine(tps.Nextid);
            Console.ReadLine();
            Console.WriteLine(tps.reset);

           



        }
    }
}

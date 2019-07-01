using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema("28Cinema", "28 May");
            Hall hall = new Hall("VIP", 40);

            Person person = new Person("Resad", "Gozelov", 40);
            Seat seat = new Seat(6, 5, person);
            hall.AddPerson(seat);

            Person person1 = new Person("Flankes", "Flankesov", 30);
            Seat seat1 = new Seat(6, 4, person1);
            hall.AddPerson(seat1);


            

        }
    }
}

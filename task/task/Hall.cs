using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Hall
    {
        private static int ID;

        public string Name { get; set; }

        public float Price { get; set; }

        public Seat[,] seats;

        public Hall(string name,float price)
        {
            Name = name;
            Price = price;
            seats = new Seat[10, 10];
        }
        public void AddPerson(Seat seat)
        {
            if (seat.PersonSeat.Money == Price && seats[seat.Row, seat.Col] == null)
            {
                seats[seat.Row, seat.Col] = seat;
                Console.WriteLine($"{seat.PersonSeat.Name} {seat.PersonSeat.Surname} Buyurun daxil ola bilersiniz");
            }

            else
            {
                Console.WriteLine($"{seat.PersonSeat.Name} {seat.PersonSeat.Surname} Efsuslar olsun daxil ola bilmersiniz");
            }

        }
    }
}

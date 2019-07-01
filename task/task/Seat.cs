using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Seat
    {
        private static int ID;

        public int Row { get; set; }

        public int Col { get; set; }

        public Person PersonSeat;

        public Seat(int row,int col,Person personseat)
        {
            Row = row;
            Col = col;
            PersonSeat = personseat;

        }

    }
}

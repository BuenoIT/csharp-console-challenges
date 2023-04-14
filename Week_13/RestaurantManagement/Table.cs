using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    internal class Table
    {
        public int TableNumber;
        public int NumberOfSeats;
        public bool IsAvailable;
        public int OriginalNumberOfSeats;

        public Table(int tableNumber, int numberOfSeats)
        {
            TableNumber = tableNumber;
            NumberOfSeats = numberOfSeats;
            IsAvailable = true;
            OriginalNumberOfSeats = numberOfSeats;
        }
    }
}

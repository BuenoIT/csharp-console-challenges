using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    public class TablesManager
    {
        private Table[] tables;

        public TablesManager(int numberOfTables)
        {
            tables = new Table[numberOfTables];
            for (int i = 0; i < numberOfTables; i++)
            {
                Console.Write($"Enter the number of seats for table {i + 1}: ");
                int numberOfSeats = int.Parse(Console.ReadLine());
                tables[i] = new Table(i + 1, numberOfSeats);
            }
        }

        public void CreateTable(int tableNumber, int numberOfSeats)
        {
            tables[tableNumber - 1] = new Table(tableNumber, numberOfSeats);
        }

        public void AssignCustomers(int numberOfCustomers)
        {
            Console.WriteLine("Available Tables:");
            for (int i = 0; i < tables.Length; i++)
            {
                if (tables[i].IsAvailable && tables[i].NumberOfSeats >= numberOfCustomers)
                {
                    Console.WriteLine($"Table {tables[i].TableNumber} ({tables[i].NumberOfSeats} seats)");
                }
            }

            Console.Write("Select a table: ");
            int tableNumber = int.Parse(Console.ReadLine());
            Table selectedTable = tables[tableNumber - 1];

            if (selectedTable.IsAvailable && selectedTable.NumberOfSeats >= numberOfCustomers)
            {
                selectedTable.IsAvailable = false;
                selectedTable.NumberOfSeats -= numberOfCustomers;
                Console.WriteLine($"Customers assigned to Table {selectedTable.TableNumber} ({numberOfCustomers} seats)");
            }
            else
            {
                Console.WriteLine("Table is not available or does not have enough seats.");
            }
        }

        public void ReleaseTable(int tableNumber)
        {
            foreach (Table table in tables)
            {
                if (table.TableNumber == tableNumber)
                {
                    if (!table.IsAvailable)
                    {
                        table.IsAvailable = true;
                        table.NumberOfSeats = table.OriginalNumberOfSeats;
                        Console.WriteLine($"Table {table.TableNumber} has been released.");
                    }
                    else
                    {
                        Console.WriteLine($"Table {table.TableNumber} is not currently occupied.");
                    }
                    return;
                }
            }
            Console.WriteLine($"Table {tableNumber} does not exist.");
        }



        public void ListTables()
        {
            Console.WriteLine("List of Tables:");
            foreach (var table in tables)
            {
                Console.WriteLine($"Table {table.TableNumber} ({table.NumberOfSeats} seats) - Available: {table.IsAvailable}");
            }
        }
    }

}

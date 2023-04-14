using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
                Console.WriteLine("Welcome to the Restaurant Table and Seats Management System!");

                Console.Write("Enter the number of tables in the restaurant: ");
                int numberOfTables = int.Parse(Console.ReadLine());

                TablesManager tablesManager = new TablesManager(numberOfTables);

                bool isRunning = true;

                while (isRunning)
                {
                    Console.WriteLine("\nPlease select an option:");
                    Console.WriteLine("1 - Create a new table");
                    Console.WriteLine("2 - Assign customers to a table");
                    Console.WriteLine("3 - Release a table");
                    Console.WriteLine("4 - List all tables");
                    Console.WriteLine("5 - Exit");

                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.Write("Enter the table number: ");
                            int tableNumber = int.Parse(Console.ReadLine());

                            Console.Write("Enter the number of seats: ");
                            int numberOfSeats = int.Parse(Console.ReadLine());

                            tablesManager.CreateTable(tableNumber, numberOfSeats);
                            Console.WriteLine($"Table {tableNumber} with {numberOfSeats} seats created successfully.");
                            break;

                        case 2:
                            Console.WriteLine("Available Tables:");
                            tablesManager.ListTables();

                            Console.Write("\nEnter the table number to assign customers: ");
                            tableNumber = int.Parse(Console.ReadLine());

                            Console.Write("Enter the number of customers: ");
                            int numberOfCustomers = int.Parse(Console.ReadLine());

                            tablesManager.AssignCustomers(numberOfCustomers);

                            break;

                        case 3:
                            Console.WriteLine("Occupied Tables:");
                            tablesManager.ListTables();

                            Console.Write("\nEnter the table number to release: ");
                            tableNumber = int.Parse(Console.ReadLine());

                        int tableToRelease = int.Parse(Console.ReadLine());

                        tablesManager.ReleaseTable(tableNumber);
                        break;

                        case 4:
                            tablesManager.ListTables();
                            break;

                        case 5:
                            isRunning = false;
                            Console.WriteLine("Exiting the Restaurant Table and Seats Management System...");
                            break;

                        default:
                            Console.WriteLine("Invalid option selected. Please select a valid option.");
                            break;
                    }
                }
            }
        }
}

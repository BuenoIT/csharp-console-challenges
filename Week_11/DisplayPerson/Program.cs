using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayPerson
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

            static void Main(string[] args)
            {
                // Declare a new Person object and initialize its properties
                Person person = new Person
                {
                    Name = "John Doe",
                    Age = 30
                };

                // Call the DisplayPersonDetails method and pass the person object as an argument
                DisplayPersonDetails(person);

                Console.ReadLine();
            }

            static void DisplayPersonDetails(Person person)
            {
                Console.WriteLine("Name: {0}", person.Name);
                Console.WriteLine("Age: {0}", person.Age);
            }
        }
    }


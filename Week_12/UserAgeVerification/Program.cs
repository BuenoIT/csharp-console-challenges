using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAgeVerification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            do
            {
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();

                Console.Write("Please enter your age: ");
                age = int.Parse(Console.ReadLine());

                User user = new User(name, age);

                if (user.IsAdult())
                {
                    Console.WriteLine("Welcome, {0} ({1} years old)!", user.Name, user.Age);
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, {0}. You are too young to use this application.", user.Name);
                    Console.Write("Please enter your parent's permission (Y/N): ");
                    string permission = Console.ReadLine();

                    if (permission.Equals("Y", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Welcome, {0} ({1} years old)!", user.Name, user.Age);
                        break;
                    }
                }
            } while (age < 18);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
}
    class User
    {
        public string Name;
        public int Age;

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public bool IsAdult()
        {
            return Age >= 18;
        }
    }
}

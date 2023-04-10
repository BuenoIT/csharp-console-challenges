using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the size of the array.
            Console.Write("Enter the size of the array: ");
            int size = 0;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Invalid input. Enter a positive integer: ");
            }

            // Initialize the array with user input.
            int[] arr = new int[size];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.Write("Invalid input. Enter an integer: ");
                }
            }

            // Sort the array using bubble sort algorithm.
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            // Print the sorted array to the console.
            Console.Write("Sorted array: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

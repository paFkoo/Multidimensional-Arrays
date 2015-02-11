using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Program
    {
        static void Main()
        {
            Console.Write("Enter N = ");

            int n = int.Parse(Console.ReadLine());

            string[] array = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a string array[{0}]: ", i);
                array[i] = Console.ReadLine();
            }

            // Sort with lambda
            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

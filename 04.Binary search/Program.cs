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
            Console.Write("Enter K = ");
            int k = int.Parse(Console.ReadLine());

            int[] myArray = new int[n];
            Console.WriteLine("Enter {0} numbers: ", n);
            for (int i = 0; i < n; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(myArray);

            int biggest = Array.BinarySearch(myArray, k);
            biggest = biggest >= 0 ? biggest : (biggest == -1 ? -1 : Math.Abs(biggest + 2));

            if (biggest != -1)
            {
                Console.WriteLine("\nFound smaller or equal number to K = {0}", k);
                Console.WriteLine("-> Result number: {0}\n", myArray[biggest]);
            }
            else
            {
                Console.WriteLine("\n- There is no smaller or equal to K = {0} number in array!\n", k);
            }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("M = ");
        int m = int.Parse(Console.ReadLine());

        string[,] myArray = new string[n, m];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("Array[{0},{1}] = ", row, col);
                myArray[row, col] = Console.ReadLine();
            }
        }

        int numMaxElements = 0;
        int numCurrElements = 0;
        string maxStr = "";


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {

                numCurrElements = 0;
                for (int k = i; k < n - 1; k++)
                {
                    if (myArray[j, k + 1] == myArray[j, k])
                    {
                        numCurrElements++;
                    }

                    if (numCurrElements > numMaxElements)
                    {
                        numMaxElements = numCurrElements;
                        maxStr = myArray[j, k];
                    }
                }


                numCurrElements = 0;
                for (int k = j; k < m - 1; k++)
                {
                    if (myArray[k, i] == myArray[k + 1, i])
                    {
                        numCurrElements++;
                    }

                    if (numCurrElements > numMaxElements)
                    {
                        numMaxElements = numCurrElements;
                        maxStr = myArray[k, i];
                    }
                }


                numCurrElements = 0;
                for (int k = i, l = j; (k < n - 1) && (l < m - 1); k++, l++)
                {
                    if (myArray[l, k] == myArray[l + 1, k + 1])
                    {
                        numCurrElements++;
                    }

                    if (numCurrElements > numMaxElements)
                    {
                        numMaxElements = numCurrElements;
                        maxStr = myArray[l, k];
                    }
                }
            }
        }

        for (int i = 0; i < numMaxElements + 1; i++) Console.Write(maxStr + ", ");
        Console.WriteLine();
    }
}

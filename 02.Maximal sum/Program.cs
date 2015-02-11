using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        /*Write a program that reads a rectangular matrix of size N x M and finds 
         * in it the square 3 x 3 that has maximal sum of its elements.*/
        int width = 3;
        int height = 3;
        Console.Write("Number of rows = ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Number of columns = ");
        int cols = int.Parse(Console.ReadLine());
        if (rows < 3 && cols < 3)
        {
            Console.WriteLine("Invalid input!!!");
        }
        else
        {
        int[,] matrix = new int[rows, cols];
        int element = 1;

        for (int col = 0; col < cols; col++)
        {
            for (int row = 0; row < rows; row++)
            {
                matrix[row, col] = element;
                element++;
            }
        }

        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - height + 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - width + 1; col++)
            {
                int sum = 0;
                for (int platformRow = row; platformRow < row + height; platformRow++)
                {
                    for (int platformCol = col; platformCol < col + width; platformCol++)
                    {
                        sum += matrix[platformRow, platformCol];
                    }
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        Console.WriteLine("The best platform is:");
        for (int platformRow = bestRow; platformRow < bestRow+ height; platformRow++)
        {
            for (int platformCol = bestCol; platformCol < bestCol+width; platformCol++)
            {
                Console.Write("{0} ", matrix[platformRow, platformCol]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("The maximal sum is: {0}", bestSum);
        }
    }
}

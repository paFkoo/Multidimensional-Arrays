using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        //Write a program that fills and prints a matrix of size (n, n) as shown below:
        Console.Write("Number of rows = ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Number of columns = ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        int element = 1;
        // a)
        for (int col = 0; col < cols; col++)
        {
            for (int row = 0; row < rows; row++)
            {
                matrix[row, col] = element;
                element++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("The matrix a) is as follows:");
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }

            Console.WriteLine();
        }
        // b)
        bool isDirDown = true;
        for (int col = 0, row = 0, index = 1; col < matrix.GetLength(1); col++)
        {
            while (row >= 0 && row < matrix.GetLength(0))
            {
                matrix[row, col] = index++;
                row += isDirDown ? +1 : -1; // Change 'row' value
            }
            // Change direction and change 'row' value
            isDirDown = !isDirDown;
            row += isDirDown ? +1 : -1;
        }

        Console.WriteLine();
        Console.WriteLine("The matrix b) is as follows:");
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }

            Console.WriteLine();
        }
        // c)
        for (int row = matrix.GetLength(0) - 1, index = 1; index <= matrix.GetLength(0) * matrix.GetLength(1); row--)
        {
            for (int currCol = (row >= 0 ? 0 : -row), currRow = (row >= 0 ? row : 0);
                currCol < (matrix.GetLength(1) - (row >= 0 ? row : 0)); )
            {
                matrix[currRow++, currCol++] = index++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("The matrix c) is as follows:");
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}

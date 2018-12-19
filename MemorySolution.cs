using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Program
    {
        static void Main(string[] args)
        {

            int size = GetSize();

            int[,] matrix = new int[size, size];
            GenerateRandomMatrix(size, matrix);

            PrintMatrix(matrix);


            Console.ReadLine();
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j] , 2 } ");
                }
                Console.WriteLine();
            }
        }

        private static void GenerateRandomMatrix(int size, int[,] matrix)
        {
            Random r = new Random();
            int zugot = size * size / 2;
            for (int i = 1; i <= zugot; i++)
            {
                // find place for car number 1
                // put in this place the i
                int row, col;
                do
                {
                    row = r.Next(0, size);
                    col = r.Next(0, size);
                }
                while (matrix[row, col] != 0);
                matrix[row, col] = i;

                // find place for car number 2
                // put in this place the i
                do
                {
                    row = r.Next(0, size);
                    col = r.Next(0, size);
                }
                while (matrix[row, col] != 0);
                matrix[row, col] = i;
            }
        }

        private static int GetSize()
        {
            int size;
            do
            {
                Console.WriteLine("Enter size:");
                size = Convert.ToInt32(Console.ReadLine());
            }
            while (size <= 0 || size % 2 != 0 || size > 8);

            return size;
        }
    }
}

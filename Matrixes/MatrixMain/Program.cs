using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrixes;

namespace MatrixMain
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number of columns");
            int columns = Convert.ToInt32(Console.ReadLine());

            Matrix matrix = new Matrix(rows, columns);

             Random random = new Random();
             for(int i=0;i<rows;++i)
             {
                 for(int j=0;j<columns;++j)
                 {
                     matrix.MatrixArray[i, j] = random.Next(0,10);
                    
                 }
             }

            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < columns; ++j)
                {
                    Console.Write(matrix.MatrixArray[i, j] + " ");

                }
                Console.WriteLine();
            }

            Matrix matrix1 = new Matrix(rows, columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix1.MatrixArray[i, j] = random.Next(0, 10);
                }
            }

            Console.WriteLine("Matrix1 for addition is");
            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < columns; ++j)
                {
                    Console.Write(matrix1.MatrixArray[i, j] + " ");

                }
                Console.WriteLine();
            }


            matrix.Addition(matrix1);

            matrix.Largest();
            matrix.Smallest();
            matrix.Transpose();
            matrix.Inverse();
            matrix.ScalarMultiplication(2);
            
            Console.WriteLine("please enter the number of columns in the second matrix to multioly the matrixes");
            int cols = Convert.ToInt32((Console.ReadLine()));
            Matrix matrix2 = new Matrix(columns, cols);
            matrix.Multiplication(matrix2);

            

            /*
            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < columns; ++j)
                {
                //stex chem haskanum sxaly??
                    matrix.MatrixArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            */


            Console.ReadKey();
        }
    }
}

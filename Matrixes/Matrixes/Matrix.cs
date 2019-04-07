using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixes
{
    public class Matrix
    {
        public int Columns { get; set; }
        public int Rows { get; set; }
        public double[,] MatrixArray { get; set; }


        public Matrix()
        {
            Rows=0;
            Columns = 0;
            MatrixArray = new double[0, 0];

        }

        public Matrix(int Row, int Col)
        {
            Rows = Row;
            Columns = Col;
            MatrixArray = new double[Rows, Columns];
        }

        public Matrix(int[,] M)
        {

            Columns = M.GetLength(1);
            Rows = M.GetLength(0);
            MatrixArray = new double[Rows, Columns];
            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Columns; ++j)
                {
                    MatrixArray[i, j] = M[i, j];
                }
            }
        }

        public Matrix Addition(Matrix matrix)
        {
            Console.WriteLine("The operation od Addition ");
            if (matrix.Rows != this.Rows || matrix.Columns != this.Columns)
            {
                Console.WriteLine("Matrixes' sizes are different.Please input the appropriarte matrix");
                return null;
            }
            Matrix SumMatrix = new Matrix(Rows, Columns);

            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Columns; ++j)
                {
                    SumMatrix.MatrixArray[i, j] = matrix.MatrixArray[i, j] + this.MatrixArray[i, j];
                }
            }
            for (int i = 0; i < SumMatrix.Rows; ++i)
            {
                for (int j = 0; j < SumMatrix.Columns; ++j)
                {
                    Console.Write(SumMatrix.MatrixArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            return SumMatrix;
        }

        public double Largest()
        {
            Console.WriteLine("This operation determines the largest number in the matrix");
            double max = 0.0;
            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Columns; ++j)
                {
                    if (MatrixArray[i, j] > max)
                        max = MatrixArray[i, j];
                }
            }
            Console.WriteLine("The Largest number in this matrix is " + " "  + max);
            return max;
        }



        public double Smallest()
        {
            Console.WriteLine("This operation determines the smallest number in the matrix");
            double min = 11.0;
            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Columns; ++j)
                {
                    if (MatrixArray[i, j] < min)
                        min = MatrixArray[i, j];
                }
            }
            Console.WriteLine("The smallest number in this matrix is " + " " + min);
            return min;
        }



        public Matrix Multiplication(Matrix M)
        {
            Console.WriteLine("The following operation multiplies matrixes");
            if (Columns != M.Rows)
            {
                Console.WriteLine(" the inputted matrix isnt appropriate");
                return null;
            }
            Matrix Multiplied = new Matrixes.Matrix(Rows, M.Columns);
            for (int i = 0; i < Rows; ++i)
            {
                for (int k = 0; k < M.Columns; ++k)
                {
                    for (int j = 0; j < Columns; ++j)
                    {
                        Multiplied.MatrixArray[i, k] += this.MatrixArray[i, j] * M.MatrixArray[j, k];
                    }
                }
            }

            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < M.Columns; ++j)
                {
                    Console.Write(Multiplied.MatrixArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            return Multiplied;
        }



        public Matrix ScalarMultiplication(double n)
        {
            //Console.WriteLine("This is ScalarMultiplication");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    MatrixArray[i, j] *= n;
                }
            }
            /*for (int i = 0; i < Rows; i++)
            {
                for (int j = 0;j<Columns; ++j)
                {
                    Console.Write(MatrixArray[i, j] + " ");
                }
                Console.WriteLine();
            }*/
            

            return this;
        }



        public Matrix Transpose()
        {
          //  Console.WriteLine("This operation creates the transpose of the matrix");
            Matrix TransposeMatrix = new Matrix(Columns,Rows);
            for(int i=0;i< Rows; ++i)
            {
                for(int j=0;j<Columns;++j)
                {
                    TransposeMatrix.MatrixArray[j, i] = MatrixArray[i, j];
                }
            }

           /* for (int i = 0; i < TransposeMatrix.Rows; ++i)
            {
                for (int j = 0; j < TransposeMatrix.Columns; j++)
                {
                    Console.Write(TransposeMatrix.MatrixArray[i, j] + " ");
                }
                Console.WriteLine();
            }*/
            return TransposeMatrix;
        }


        
        public static double DET(int n, double[,] Mat)
        {
           double d = 0;
            int k, i, j, subi, subj;
            double[,] SUBMat = new double[n, n];
            if (n == 2)
            {
                return ((Mat[0, 0] * Mat[1, 1]) - (Mat[1, 0] * Mat[0, 1]));
            }
            else
            {
                for (k = 0; k < n; k++)
                {
                    subi = 0;
                    for (i = 1; i < n; i++)
                    {
                        subj = 0;
                        for (j = 0; j < n; j++)
                        {
                            if (j == k)
                            {
                                continue;
                            }
                            SUBMat[subi, subj] = Mat[i, j];
                            subj++;
                        }
                        subi++;
                    }
                    //stex aranc explicit casti chtoxec chaskaca xi? sax inta mejy
                    d = d + (int)(Math.Pow(-1, k) * Mat[0, k] * DET(n - 1, SUBMat));
                    
                }
            }
            return Math.Abs(d);
        }
          

        public Matrix Inverse()
        {

            Console.WriteLine("The operation constructs the inverseMatrix");
            if (Rows!=Columns)
            {
                Console.WriteLine("the number ofColumns must be equal to the number of Raws");
                return null;
            }
            if (DET(Columns,MatrixArray) != 0)
            {
                double N = 1 / DET(this.Columns, this.MatrixArray);
                Console.WriteLine();
                Transpose();
                this.ScalarMultiplication(N);
                for (int i = 0; i < Rows; ++i)
                {
                    for (int j = 0; j < Columns; ++j)
                    {
                        Console.Write(MatrixArray[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine(" invalid parametr");
            }
        return this;

        }


       /* public bool Ortogonality()
        {
            Console.WriteLine("The operation determines whether it is Ortogonal or not");
            
        }*/
       
    }
    }


    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks.Dataflow;
using static System.Console;

namespace lab7
{
    internal class MainClass
    {

        public static int[][] CreateMatrix(int n, int m)
        {
            Random random = new Random();
            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    matrix[i][j] = random.Next(-50, 200);
                }
            }
            return matrix;
        }

        public static void Main(string[] args)
        {
            int rows1 = -1;
            int column1 = -1;
            int rows2 = -2;
            int column2 = -2;
            WriteLine("Enter amount of raws and columns without spaces (n,m) ");
            string[] firstDimension = ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
            WriteLine("Enter amount of raws and columns of the second matrix without spaces (n,m) ");
            string[] secondDimension = ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
            try
            {
                rows1 = Convert.ToInt32(firstDimension[0]);
                column1 = Convert.ToInt32(firstDimension[1]);
                rows2 = Convert.ToInt32(secondDimension[0]);
                column2 = Convert.ToInt32(secondDimension[1]);
                if (column1 == rows2)
                {
                    int[][] matrix1 = CreateMatrix(rows1, column1);
                    int[][] matrix2 = CreateMatrix(rows2, column2);

                    WriteLine("Another result");

                    for (int i = 0; i < rows1; i++)
                    {
                        for (int j = 0; j < column2; j++)
                        {
                            int sum = 0;
                            for (int k = 0; k < column1; k++)
                            {
                                sum += matrix1[i][k] * matrix2[k][j];
                            }

                            WriteLine(sum);
                        }
                    }

                    var bufferBlock = new BufferBlock<int[][]>();

                    for (int i = 0; i < rows1; i++)
                    {
                        for (int k = 0; k < column2; k++)
                        {
                            int[][] data = new int[2][];
                            data[0] = matrix1[i];

                            data[1] = new int[rows2];
                            for (int j = 0; j < rows2; j++)
                            {
                                data[1][j] = matrix2[j][k];
                            }
                            bufferBlock.Post(data);
                        }
                    }

                    var actionBlock = new ActionBlock<int[][]>(n =>
                    {
                        int sum = 0;
                        WriteLine("In the block:");
                        for (int i = 0; i < rows2; i++)
                        {

                            sum += n[0][i] * n[1][i];

                        }
                        WriteLine("Sum: " + sum);
                    });


                    for (int i = 0; i <= rows1 * column2; i++)
                    {
                        actionBlock.Post(bufferBlock.Receive());
                    }
                }
                else
                {
                    WriteLine("!!!The number of columns of the first matrix doesn't coincide with the number of raws of the second matrix");
                }
            }
            catch (Exception e)
            {
                WriteLine($"There are mistakes in the input datas\n{e}\n");
            }

        }

    }

}
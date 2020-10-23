using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms
{
    public class FuntionsDefinition : FunctionsInterface
    {
        public int[][] array1Dto2D(int[] array1D, int dim)
        {
            int[][] array2D = new int[dim][];
            int counter = 0;
            for (int i = 0; i < dim; i++)
            {
                array2D[i] = new int[dim];
                for (int j = 0; j < dim; j++)
                {
                    array2D[i][j] = array1D[counter++];
                }
            }
            return array2D;
        }
        public int[] array2Dto1D(int[][] array2D, int dim)
        {
            int[] array1D = new int[dim * dim];
            int counter = 0;
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    array1D[counter++] = array2D[i][j];
                }
            }
            return array1D;
        }
        public int Heuristic(int[][] niz, int dim)
        {
            int h = 0;
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (niz[i][j] == 1)
                    {
                        for (int k = 0; k < dim; k++)
                        {
                            for (int n = j + 1; n < dim; n++)
                            {
                                if (k == i)
                                {
                                    if (niz[k][n] == 1)
                                    {
                                        h++;
                                    }
                                }
                                else if (k + n == i + j)
                                {
                                    if (niz[k][n] == 1)
                                    {
                                        h++;
                                    }
                                }
                                else if (k - i == n - j)
                                {
                                    if (niz[k][n] == 1)
                                    {
                                        h++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return h;
        }
        public int[][] CopyRow(int[][] array, int dim)
        {
            int[][] array2 = new int[dim][];
            for (int i = 0; i < dim; i++)
            {
                array2[i] = new int[dim];
                for (int j = 0; j < dim; j++)
                {
                    array2[i][j] = array[i][j];
                }
            }
            return array2;
        }
        public int[][] rndSuccessor(int[][] array, int dim)
        {
            int row = new Random().Next(0, dim);
            int column = new Random().Next(0, dim);

            while (array[row][column] == 1)
            {
                row = new Random().Next(0, dim);
                column = new Random().Next(0, dim);
            }
            for (int i = 0; i < dim; i++)
            {
                if (array[i][column] == 1)
                {
                    array[i][column] = 0;
                    break;
                }
            }
            array[row][column] = 1;

            return array;
        }
        public int[][] GenerateArray(int dim)
        {
            int[][] array = new int[dim][];
            Array.Clear(array, 0, array.Length);
            Random rnd = new Random();
            int[] rndnNiz = new int[dim];
            for (int i = 0; i < dim; i++)
            {
                array[i] = new int[dim];
                rndnNiz[i] = rnd.Next(0, dim);
            }
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (j == rndnNiz[i])
                    {
                        array[j][i] = 1;
                        break;
                    }
                }
            }
            return array;
        }
        public int[] StringToInt(string stringArray, int dim)
        {
            int[] array = new int[dim * dim];
            for (int i = 0; i < dim * dim; i++)
            {
                array[i] = (int)Char.GetNumericValue(stringArray, i);
            }
            return array;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.Models
{
    public class CommonFunctions
    {
        public static int[][] array1Dto2D(int[] array1D, int dim)
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
    }
}

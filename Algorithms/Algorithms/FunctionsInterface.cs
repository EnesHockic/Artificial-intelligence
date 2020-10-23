using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms
{
    public interface FunctionsInterface
    {
        int[][] array1Dto2D(int[] array1D, int dim);
        int[] array2Dto1D(int[][] array2D, int dim);
        int Heuristic(int[][] niz, int dim);
        int[][] CopyRow(int[][] array, int dim);
        int[] StringToInt(string stringArray, int dim);
        int[][] GenerateArray(int dim);
        int[][] rndSuccessor(int[][] array, int dim);
    }
}

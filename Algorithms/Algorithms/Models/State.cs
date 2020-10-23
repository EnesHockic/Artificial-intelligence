using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.Models
{
    public class State
    {
        public int[][] niz;
        public int h;
        public State(int dim)
        {
            niz = new int[dim][];
        }
    }
}

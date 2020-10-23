using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTac.Models
{
    public class Node
    {
        public char[][] niz;
        public int h;
        public Node()
        {
            niz = new char[3][];
            for (int i = 0; i < 3; i++)
            {
                niz[i] = new char[3];
            }
        }
    }
}

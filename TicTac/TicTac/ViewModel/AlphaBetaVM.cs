using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTac.ViewModel
{
    public enum Player { MIN, MAX };

    public class AlphaBetaVM
    {
        public char[] array { get; set; }
        public List<SelectListItem> depths { get; set; }
        public int depth { get; set; }
        public bool MaxPlayer { get; set; }

        public int playerScore { get; set; }
        public int compScore { get; set; }
        public int equalScore { get; set; }
        public string isLeaf { get; set; }
        public int heuristic { get; set; }
        public Player player { get; set; }
    }
}

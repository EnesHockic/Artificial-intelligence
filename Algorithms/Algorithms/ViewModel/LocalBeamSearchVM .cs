using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.ViewModel
{
    public class LocalBeamSearchVM
    {
        public int dimension { get; set; }
        public int[] array { get; set; }
        public int heuristic { get; set; }
        public int counter { get; set; }
        public int maxCounter { get; set; }
        public int nmbrStates { get; set; }
        public List<SelectListItem> dimensions { get; set; }
    }
}

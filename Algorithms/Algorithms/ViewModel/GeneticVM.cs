﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.ViewModel
{
    public class GeneticVM
    {
        public int dimension { get; set; }
        public int[] array { get; set; }
        public int heuristic { get; set; }
        public int counter { get; set; }
        public List<SelectListItem> dimensions { get; set; }
        public int populationSize { get; set; }
        public int elitism { get; set; }
        public double crossoverProb { get; set; }
        public double mutationProb { get; set; }
        public int nmbrGenerations { get; set; }
    }
}

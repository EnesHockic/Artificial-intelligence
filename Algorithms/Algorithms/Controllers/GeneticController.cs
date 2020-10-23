using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Algorithms.Models;
using Algorithms.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Algorithms.Controllers
{
    public class GeneticController : Controller
    {
        private FunctionsInterface _IFunctions;
        public GeneticController(FunctionsInterface IFunctions)
        {
            _IFunctions = IFunctions;
        }
        public IActionResult Index()
        {
            int[] a = new int[16] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            GeneticVM VM = new GeneticVM()
            {
                array = a,
                dimension = 4,
                heuristic =_IFunctions.Heuristic(_IFunctions.array1Dto2D(a, 4), 4),
                dimensions = new List<SelectListItem>()
                {
                    new SelectListItem{Text="4x4",Value="4"},
                    new SelectListItem{Text="5x5",Value="5"},
                    new SelectListItem{Text="6x6",Value="6"},
                    new SelectListItem{Text="7x7",Value="7"},
                    new SelectListItem{Text="8x8",Value="8"},
                    new SelectListItem{Text="9x9",Value="9"},
                    new SelectListItem{Text="10x10",Value="10"},
                    new SelectListItem{Text="11x11",Value="11"},
                    new SelectListItem{Text="12x12",Value="12"},
                },

            };

            return View(VM);
        }
        public IActionResult GenerateRandomState(int dim, int populationSize, int elitism, int crossoverProb, int mutationProb, int nmbrGenerations)
        {
            int[][] Array = (_IFunctions.GenerateArray(dim));

            GeneticVM VM = new GeneticVM()
            {
                array = _IFunctions.array2Dto1D(Array, dim),
                dimension = dim,
                heuristic = _IFunctions.Heuristic(Array, dim),
                crossoverProb = crossoverProb,
                elitism = elitism,
                mutationProb = mutationProb,
                nmbrGenerations = nmbrGenerations,
                populationSize = populationSize,
                dimensions = new List<SelectListItem>()
                {
                    new SelectListItem{Text="4x4",Value="4"},
                    new SelectListItem{Text="5x5",Value="5"},
                    new SelectListItem{Text="6x6",Value="6"},
                    new SelectListItem{Text="7x7",Value="7"},
                    new SelectListItem{Text="8x8",Value="8"},
                    new SelectListItem{Text="9x9",Value="9"},
                    new SelectListItem{Text="10x10",Value="10"},
                    new SelectListItem{Text="11x11",Value="11"},
                    new SelectListItem{Text="12x12",Value="12"},
                }

            };

            return View("Index", VM);
        }
        static int rouletteSelection(List<State> chromosomes, int k)
        {
            int i = -1;
            int sum = 0;
            for (int j = 0; j < k; j++) 
            {
                sum += chromosomes[j].h;
            }
            int a = new Random().Next(0, sum);
            sum = 0;

            do
            {
                i++;
                sum += chromosomes[i].h;
            } while (sum < a);

            return i;
        }
        public void Crossover(State C1, State C2, int dim)
        {
            int x = new Random().Next(0, dim);
            int y = new Random().Next(0, dim);

            if (y < x)
            {
                int temp = y;
                y = x;
                x = temp;
            }
            for (int i = x; i < y + 1; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (C1.niz[j][i] == 1 || C2.niz[j][i] == 1)
                    {
                        int temp = C1.niz[j][i];
                        C1.niz[j][i] = C2.niz[j][i];
                        C2.niz[j][i] = temp;
                    }
                }
            }
            C1.h = _IFunctions.Heuristic(C1.niz, dim);
            C2.h = _IFunctions.Heuristic(C2.niz, dim);
        }
        public void Mutation(State Cm, int dim)
        {
            int col1 = new Random().Next(0, dim);
            int col2;
            do
            {
                col2 = new Random().Next(0, dim);
            } while (col2 == col1);

            int temp;
            for (int i = 0; i < dim; i++)
            {
                temp = Cm.niz[i][col1];
                Cm.niz[i][col1] = Cm.niz[i][col2];
                Cm.niz[i][col2] = temp;
            }
            Cm.h = _IFunctions.Heuristic(Cm.niz, dim);
        }
        public IActionResult GeneticA(string stringArray, int dim, int populationSize, int elitism, double crossoverProb, double mutationProb, int nmbrGenerations)
        {
            int[] array = _IFunctions.StringToInt(stringArray, dim);
            int[][] Array = _IFunctions.array1Dto2D(array,dim);

            List<State> chromosomes = new List<State>();

            chromosomes.Add(new State(dim));    //adding initial state to chromosomes/random states
            chromosomes[0].niz = Array;
            chromosomes[0].h = _IFunctions.Heuristic(Array, dim);
            for (int i = 1; i < populationSize; i++) //adding rest of random chromosomes/random states
            {
                chromosomes.Add(new State(dim));
                chromosomes[i].niz = _IFunctions.GenerateArray(dim);
                chromosomes[i].h = _IFunctions.Heuristic(chromosomes[i].niz, dim);
            }

            bool promjena;
            State bestChromosome;
            int brojac = 0;
            while (nmbrGenerations > 0)//do until we go through all generations
            {
                promjena = true;
                while (promjena)    //sort chromosomes by h
                {
                    promjena = false;
                    for (int i = 0; i < populationSize - 1; i++)
                    {
                        if (chromosomes[i].h > chromosomes[i + 1].h)
                        {
                            State s = chromosomes[i];
                            chromosomes[i] = chromosomes[i + 1];
                            chromosomes[i + 1] = s;
                            promjena = true;
                        }
                    }
                }
                bestChromosome = chromosomes[0];
                if (bestChromosome.h == 0) //if we find solution 
                    break;
                List<State> chromsToAdd = new List<State>();
                for (int i = 0; i < populationSize * elitism / 100; i++)
                {
                    chromsToAdd.Add(chromosomes[i]);    //adding elite chromosomes to the next generation
                }
                for (int i = chromsToAdd.Count() / 2; i < populationSize / 2; i++)//adding the rest of chromosomes to the next generation
                {
                    int k = rouletteSelection(chromosomes, populationSize);//roulette Selection- select a parent
                    State C1 = chromosomes[k];
                    int n;
                    do
                    {
                        n = rouletteSelection(chromosomes, populationSize);//select second parent
                    } while (n == k);//restriction not to have same chromosome as two parents
                    State C2 = chromosomes[n];
                    State C1c = C1;
                    State C2c = C2;
                    if (new Random().NextDouble() < crossoverProb)//if the propability is high enough we do the crossover between two parents
                    {
                        Crossover(C1c, C2c, dim);
                    }
                    State C1m = C1c;
                    State C2m = C2c;
                    if (new Random().NextDouble() < mutationProb)//if the propability is high enough we do the mutation of each of the parents
                    {
                        Mutation(C1m, dim);
                        Mutation(C2m, dim);
                    }
                    chromsToAdd.Add(C1m);
                    chromsToAdd.Add(C2m);
                }
                brojac++;
                chromosomes = chromsToAdd;
                nmbrGenerations--;
            }

            if (chromosomes[0].h != 0)
            {
                promjena = true;
                while (promjena)    //because on the end of while loop we don't sort the final generation, so we do it here to 
                {
                    promjena = false;
                    for (int i = 0; i < populationSize - 1; i++)
                    {
                        if (chromosomes[i].h > chromosomes[i + 1].h)
                        {
                            State s = chromosomes[i];
                            chromosomes[i] = chromosomes[i + 1];
                            chromosomes[i + 1] = s;
                            promjena = true;
                        }
                    }
                }
            }
            GeneticVM VM = new GeneticVM()
            {
                array = _IFunctions.array2Dto1D(chromosomes[0].niz, dim),
                dimension = dim,
                heuristic = chromosomes[0].h,
                crossoverProb = crossoverProb,
                elitism = elitism,
                mutationProb = mutationProb,
                nmbrGenerations = nmbrGenerations,
                populationSize = populationSize,
                dimensions = new List<SelectListItem>()
                {
                    new SelectListItem{Text="4x4",Value="4"},
                    new SelectListItem{Text="5x5",Value="5"},
                    new SelectListItem{Text="6x6",Value="6"},
                    new SelectListItem{Text="7x7",Value="7"},
                    new SelectListItem{Text="8x8",Value="8"},
                    new SelectListItem{Text="9x9",Value="9"},
                    new SelectListItem{Text="10x10",Value="10"},
                    new SelectListItem{Text="11x11",Value="11"},
                    new SelectListItem{Text="12x12",Value="12"},
                },
                counter = brojac
            };
            return PartialView("GeneticDone", VM);
        }
    }
}
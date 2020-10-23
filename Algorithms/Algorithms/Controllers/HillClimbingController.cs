using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Algorithms.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Algorithms.Controllers
{
    public class HillClimbingController : Controller
    {
        private FunctionsInterface _IFunctions;
        public HillClimbingController(FunctionsInterface IFunctions)
        {
            _IFunctions = IFunctions;
        }
        
        public IActionResult Index()
        {
            int[] a = new int[16] { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}; //For every angorithm we generate initial array 4x4
            HillClimbingVM VM = new HillClimbingVM()                  
            {
                array = a,
                dimension =4,
                heuristic=_IFunctions.Heuristic(_IFunctions.array1Dto2D(a,4),4),
                dimensions=new List<SelectListItem>()
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
        public IActionResult GenerateRandomState(int dim,int stepsInSameState)
        {
            int[][] array = _IFunctions.GenerateArray(dim); //Generates random state

            HillClimbingVM VM = new HillClimbingVM()
            {
                array = _IFunctions.array2Dto1D(array,dim),
                dimension = dim,
                heuristic = _IFunctions.Heuristic(array,dim),   //Heuristic function calculates heuristic of this array
                stepsInSameState= stepsInSameState,
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
            
            return View("Index",VM);
        }
        
        public int[][] GetBestH(int[][] array, int dim,int startH)
        {
            int h = startH;
            int h2;
            int[][] array2 = _IFunctions.CopyRow(array,dim);
            int[][] nizFinal = _IFunctions.CopyRow(array,dim);
            List<int> Is = new List<int>();
            List<int> Js = new List<int>();
            List<int> Hs = new List<int>();
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (array[i][j] != 1)   //searching space where the queen is not in for each column
                    {
                        array2[i][j] = 1;   //setting queen in new position
                        for (int k = 0; k < dim; k++)
                        {
                            if (array2[k][j] == 1 && i != k)
                            {
                                array2[k][j] = 0;   //remove old position for queen
                                break;
                            }

                        }

                        h2 = _IFunctions.Heuristic(array2, dim); //Calculate heurstic for array with new position of queen
                        if (h2 < h)
                        {
                            h = h2;
                            nizFinal = _IFunctions.CopyRow(array2, dim);
                        }
                        else if (h2 == h)
                        {
                            Is.Add(i);
                            Js.Add(j);
                            Hs.Add(h2);
                        }
                        array2 = _IFunctions.CopyRow(array, dim);
                    }
                }
            }
            if (h >=startH)     // if there are states with same heuristic we randomly pick state 
            {
                for (int i = 0; i < Hs.Count(); i++)
                {
                    if (Hs[i] != h)
                    {
                        Is.RemoveAt(i);
                        Js.RemoveAt(i);
                        Hs.RemoveAt(i);
                    }
                }
                int rnd = new Random().Next(0, Is.Count());
                for (int i = 0; i < dim; i++)
                {
                    if (nizFinal[i][Js[rnd]] == 1)
                    {
                        nizFinal[i][Js[rnd]] = 0;
                        break;
                    }
                }
                nizFinal[Is[rnd]][Js[rnd]] = 1;
            }
            return nizFinal;
        }
        
        public IActionResult HillClimbingA(string stringArray,int dim,int stepsInSameState)
        {
            int[] array = _IFunctions.StringToInt(stringArray, dim);
            int[][] Array = new int[dim][];
            
            Array = _IFunctions.array1Dto2D(array, dim);
            int h = _IFunctions.Heuristic(Array,dim);
            int h2 = 1000;
            int[][] array2;
            int brojac = 0;
            int brojac2 = 0;
            while (h != 0 && stepsInSameState > brojac)
            {
                array2 = GetBestH(Array, dim,h); //Searching for next state with the best heuristic
                h2 = _IFunctions.Heuristic(array2,dim);
                if(h2>=h)
                {
                    brojac++; //if we don't have better solution we keep the state with same h for stepsInSameState number of itterations
                }
                if (h2 <= h)
                {
                    h = h2;
                    Array = _IFunctions.CopyRow(array2,dim); 
                    h2 = 1000;
                }
                brojac2++;
            }
            HillClimbingVM VM = new HillClimbingVM()
            {
                array = _IFunctions.array2Dto1D(Array, dim),
                dimension = dim,
                heuristic = _IFunctions.Heuristic(Array, dim),
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
                counter=brojac2,
                stepsInSameState=stepsInSameState
            };
            return PartialView("HillClimbingDone",VM);
        }
    }
}
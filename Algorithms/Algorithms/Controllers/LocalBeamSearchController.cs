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
    public class LocalBeamSearchController : Controller
    {
        private FunctionsInterface _IFunctions;
        public LocalBeamSearchController(FunctionsInterface IFunctions)
        {
            _IFunctions = IFunctions;
        }
        
        public IActionResult Index()
        {
            int[] a = new int[16] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            LocalBeamSearchVM VM = new LocalBeamSearchVM()
            {
                array = a,
                dimension = 4,
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
            return View(VM);
        }
        public IActionResult GenerateRandomState(int dim,int states,int maxCounter)
        {
            int[][] array = _IFunctions.GenerateArray(dim);
            
            LocalBeamSearchVM VM = new LocalBeamSearchVM()
            {
                array = _IFunctions.array2Dto1D(array, dim),
                dimension = dim,
                heuristic = _IFunctions.Heuristic(array, dim),
                nmbrStates=states,
                maxCounter=maxCounter,
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

            return View("Index", VM);
        }
        
        public IActionResult LocalBeamSearchA(string stringArray, int dim,int states,int maxCounter)
        {
            int[] array = _IFunctions.StringToInt(stringArray, dim);
            int[][] Array = _IFunctions.array1Dto2D(array, dim);

            State[] BestStates = new State[states];
            for (int i = 0; i < states; i++)    //generating k random states
            {
                BestStates[i] = new State(dim);
                BestStates[i].niz= _IFunctions.GenerateArray(dim);
                BestStates[i].h = _IFunctions.Heuristic(BestStates[i].niz,dim);
            }
            bool change = true;
            while (change)  //sort initial states
            {
                change = false;
                for (int i = 0; i < states - 1; i++)
                {
                    if (BestStates[i].h > BestStates[i + 1].h)
                    {
                        State s = BestStates[i];
                        BestStates[i] = BestStates[i + 1];
                        BestStates[i + 1] = s;
                        change = true;
                    }
                }
            }
            State[] allStates = new State[states * states];
            int counter2 = 0;
            while (BestStates[0].h != 0 && counter2 < maxCounter) // do until we find the state with h0, or until the counter reaches final status
            {
                int counter = 0;

                for (int i = 0; i < states; i++)
                {
                    for (int j = 0; j < states; j++)
                    {
                        allStates[counter] = new State(dim);
                        allStates[counter].niz =_IFunctions.rndSuccessor(_IFunctions.CopyRow(BestStates[j].niz,dim),dim); //for k states we are making k random single moves
                        allStates[counter].h = _IFunctions.Heuristic(allStates[counter].niz,dim);
                        counter++;
                    }
                }

                change = true;  //sort expanded array
                while (change)
                {
                    change = false;
                    for (int i = 0; i < states * states - 1; i++)
                    {
                        if (allStates[i].h > allStates[i + 1].h)
                        {
                            State s = allStates[i];
                            allStates[i] = allStates[i + 1];
                            allStates[i + 1] = s;
                            change = true;
                        }
                    }
                }
                for (int i = 0; i < states; i++)    //selecting k best states
                {
                    BestStates[i].niz = _IFunctions.CopyRow(allStates[i].niz,dim);
                    BestStates[i].h = _IFunctions.Heuristic(allStates[i].niz,dim);
                }
                counter2++;
            }
            LocalBeamSearchVM VM = new LocalBeamSearchVM()
            {
                array = _IFunctions.array2Dto1D(BestStates[0].niz, dim),
                dimension = dim,
                heuristic = _IFunctions.Heuristic(BestStates[0].niz, dim),
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
                counter = counter2,
                nmbrStates=states,
                maxCounter=maxCounter
                
            };
            return PartialView("LocalBeamSearchDone", VM);
        }
    }
}
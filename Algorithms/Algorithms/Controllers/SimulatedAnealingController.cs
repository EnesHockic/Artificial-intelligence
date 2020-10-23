using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Algorithms.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Algorithms.Controllers
{
    public class SimulatedAnealingController : Controller
    {
        private FunctionsInterface _IFunctions;
        public SimulatedAnealingController(FunctionsInterface IFunctions)
        {
            _IFunctions = IFunctions;
        }
        
        public IActionResult Index()
        {
            int[] a = new int[16] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            SimulatedAnealingVM VM = new SimulatedAnealingVM()
            {
                array = a,
                dimension = 4,
                heuristic = 0,
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
        public IActionResult GenerateRandomState(int dim, int T0, int coolingFactor)
        {
            int[][] array = _IFunctions.GenerateArray(dim);
            SimulatedAnealingVM VM = new SimulatedAnealingVM()
            {
                array =_IFunctions.array2Dto1D(array, dim),
                dimension = dim,
                heuristic = _IFunctions.Heuristic(array, dim),
                T0=T0,
                coolingFactor=coolingFactor,
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
        
        public IActionResult SimulatedAnealingA(string stringArray, int dim, int T0,int coolingFactor)
        {
            int[] array = _IFunctions.StringToInt(stringArray, dim);
            int[][] Array = _IFunctions.array1Dto2D(array, dim);

            int[][] array2;
            int deltaH;
            int Hs = 1;
            int counter = 0;
            while (T0 > 0 && Hs != 0) //do until the temperature reaches 0, or we found state with h0
            {
                array2 = _IFunctions.rndSuccessor(Array,dim);//make single random move
                Hs = _IFunctions.Heuristic(array2,dim);
                deltaH = Hs - _IFunctions.Heuristic(Array,dim); 

                if (deltaH < 0) //if the random state is better than previous state we use it as current state
                {
                    Array = _IFunctions.CopyRow(array2,dim);
                }
                else if (Math.Pow(2.71828, -(deltaH / T0)) > new Random().NextDouble()) //if the state is worse than previous state, we calculate propability
                {                                                                       //for selecting it anyway            
                    Array = _IFunctions.CopyRow(array2,dim);
                }
                T0 -= coolingFactor;    //decreasing temperature
                counter++;
            }
            SimulatedAnealingVM VM = new SimulatedAnealingVM()
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
                counter = counter,
                T0=T0,
                coolingFactor=coolingFactor
            };
            return PartialView("SimulatedAnealingDone", VM);
        }
    }
}
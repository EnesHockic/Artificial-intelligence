using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TicTac.Models;
using TicTac.ViewModel;

namespace TicTac.Controllers
{
    public class AlphaBetaController : Controller
    {
        public IActionResult Index(int Depth, Player player=(Player)0, int PlayerScore=0, int EqualScore=0, int CompScore=0)
        {
             
            //char[] array;
            //if (HumanOnMove)
            //{
                char []array  = new char[9] {'0', '0', '0', '0', '0', '0', '0', '0', '0' };
            Node s=new Node();
            if(player==(Player)1)
            {
                char[][] Array = new char[3][];
                Array[0] = new char[3] { '0', '0', '0' };
                Array[1] = new char[3] { '0', '0', '0' };
                Array[2] = new char[3] { '0', '0', '0' };
                s.niz = CopyRow(Array);
                s.h = Heuristic(s.niz);
                List<object> result = alphabet(s, Depth, int.MinValue, int.MaxValue, (Player)1);
                s = (Node)result[1];
                s.h = Heuristic(s.niz);
                int brojac = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        array[brojac++]=s.niz[i][j];
                    }
                }
            }
            
            AlphaBetaVM VM = new AlphaBetaVM()
            {
                array = array,
                depth=Depth,
                player=player,
                isLeaf="false",
                playerScore=PlayerScore,
                compScore=CompScore,
                equalScore=EqualScore,
                depths = new List<SelectListItem>()
                {
                    new SelectListItem{Text="Too Easy (1)",Value="1"},
                    new SelectListItem{Text="Easy (2)",Value="2"},
                    new SelectListItem{Text="Simple (3)",Value="3"},
                    new SelectListItem{Text="Medium (4)",Value="4"},
                    new SelectListItem{Text="Harder (5)",Value="5"},
                    new SelectListItem{Text="Hard (6)",Value="6"},
                    new SelectListItem{Text="Very difficult (7)",Value="7"},
                    new SelectListItem{Text="Extreme (8)",Value="8"},
                    new SelectListItem{Text="Impossible (9)",Value="8"}
                }
            };
            return View(VM);
        }
        public IActionResult NextPlayer(int Depth)
        {

            return View();
        }
        public char[][] StringToChar2D(string stringArray)
        {
            char[][] array = new char[3][];
            int brojac = 0;
            for (int i = 0; i <3; i++)
            {
                array[i] = new char[3];
                for (int j = 0; j < 3; j++)
                {
                    array[i][j] = stringArray[brojac++];
                }
            }
            return array;
        }
        public static bool IsLeaf(Node s)
        {
            if (s.h == 1000 || s.h == -1000)
                return true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (s.niz[i][j] == '0')
                        return false;
                }
            }
            return true;
        }
        static char[][] CopyRow(char[][] niz)
        {
            char[][] niz2 = new char[3][];
            for (int i = 0; i < 3; i++)
            {
                niz2[i] = new char[3];
                for (int j = 0; j < 3; j++)
                {
                    niz2[i][j] = niz[i][j];
                }
            }
            return niz2;
        }
        public static int Heuristic(char[][] niz)
        {
            int h;
            int sumX = 0;
            int sumO = 0;
            int brojacX = 0;
            int brojacO = 0;
            int brojacXO = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (niz[i][j] == 'X')
                    {
                        brojacX++;
                    }
                    else if (niz[i][j] == 'O')
                    {
                        brojacO++;
                    }
                    else
                    {
                        brojacXO++;
                    }
                }
                if (brojacX == 3)
                {
                    return 1000;
                }
                else if (brojacO == 3)
                    return -1000;
                else if (brojacXO == 3)
                {
                    sumO++;
                    sumX++;
                }
                else if (brojacX + brojacXO == 3)
                    sumX++;
                else if (brojacO + brojacXO == 3)
                    sumO++;
                brojacO = 0;
                brojacX = 0;
                brojacXO = 0;
            }
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (niz[i][j] == 'X')
                    {
                        brojacX++;
                    }
                    else if (niz[i][j] == 'O')
                    {
                        brojacO++;
                    }
                    else
                    {
                        brojacXO++;
                    }
                }
                if (brojacX == 3)
                {
                    return 1000;
                }
                else if (brojacO == 3)
                    return -1000;
                else if (brojacXO == 3)
                {
                    sumO++;
                    sumX++;
                }
                else if (brojacX + brojacXO == 3)
                    sumX++;
                else if (brojacO + brojacXO == 3)
                    sumO++;
                brojacO = 0;
                brojacX = 0;
                brojacXO = 0;
            }
            for (int i = 0; i < 3; i++)
            {
                if (niz[i][i] == 'X')
                {
                    brojacX++;
                }
                else if (niz[i][i] == 'O')
                {
                    brojacO++;
                }
                else
                {
                    brojacXO++;
                }
            }
            if (brojacX == 3)
            {
                return 1000;
            }
            else if (brojacO == 3)
                return -1000;
            else if (brojacXO == 3)
            {
                sumO++;
                sumX++;
            }
            else if (brojacX + brojacXO == 3)
                sumX++;
            else if (brojacO + brojacXO == 3)
                sumO++;
            brojacO = 0;
            brojacX = 0;
            brojacXO = 0;
            int n = 2;
            for (int i = 0; i < 3; i++)
            {
                if (niz[i][n] == 'X')
                {
                    brojacX++;
                }
                else if (niz[i][n] == 'O')
                {
                    brojacO++;
                }
                else
                {
                    brojacXO++;
                }
                n--;
            }
            if (brojacX == 3)
            {
                return 1000;
            }
            else if (brojacO == 3)
                return -1000;
            else if (brojacXO == 3)
            {
                sumO++;
                sumX++;
            }
            else if (brojacX + brojacXO == 3)
                sumX++;
            else if (brojacO + brojacXO == 3)
                sumO++;
            h = sumX - sumO;
            return h;
        }
        public static List<Node> PossibleMoves(Node s, Player p)
        {
            List<Node> possibleMoves = new List<Node>();
            int brojac = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (s.niz[i][j] == '0')
                    {
                        possibleMoves.Add(new Node());
                        possibleMoves[brojac].niz = CopyRow(s.niz);
                        if (p == (Player)0)
                        {
                            possibleMoves[brojac].niz[i][j] = 'O';
                        }
                        else
                        {
                            possibleMoves[brojac].niz[i][j] = 'X';
                        }
                        possibleMoves[brojac].h = Heuristic(possibleMoves[brojac].niz);
                        brojac++;
                    }
                }
            }
            return possibleMoves;
        }
        public static List<object> alphabet(Node node, int depth, int α, int ß
            , Player player)
        {
            if (depth == 0 || IsLeaf(node)) //
                return new List<object>() { node.h, node }; //if we found the Leaf or we came to the marked depth we are returning that node
            if (player == (Player)1)//If the maximizing player is on move we are calculating next move with the highest heuristi(state with highest possibility of winning the game)
            {
                int value = int.MinValue;
                List<Node> children = PossibleMoves(node, player);  //Calculating all possible moves for next player
                Node move = null;
                foreach (var child in children)
                {
                    List<object> result = alphabet(child, depth - 1, α, ß, (Player)0);//for every child we are looking for the one with highest heuristic
                    if ((int)result[0] > value)
                    {
                        value = (int)result[0];
                        move = child;
                    }
                    if (value > α)
                    {
                        α = value;
                        move = child;
                    }
                    if (α >= ß)
                        break;
                }
                return new List<object>() { value, move };
            }
            else
            {
                int value = int.MaxValue;
                List<Node> children = PossibleMoves(node, player);
                Node move = null;
                foreach (var child in children)
                {
                    List<object> result = alphabet(child, depth - 1, α, ß, (Player)1);
                    if ((int)result[0] < value)
                    {
                        value = (int)result[0];
                    }
                    if (value < ß)
                    {
                        ß = value;
                        move = child;
                    }
                    if (α >= ß)
                        break;
                }
                return new List<object>() { value, move };
            }
        }
        public static char[] Char2Dto1D(char[][] Array)
        {
            char[] array = new char[9];
            int brojac = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[brojac] = Array[i][j];
                    brojac++;
                }
            }
            return array;
        }
        public IActionResult AlphaBetaA(string stringArray,int depth,Player player,int PlayerScore, int EqualScore,int CompScore)
        {
            char[][] array = StringToChar2D(stringArray);
            Node s=new Node();
            s.niz = CopyRow(array);
            s.h = Heuristic(s.niz);
            List<object> result = alphabet(s, depth, int.MinValue, int.MaxValue, player);
            s = (Node)result[1];
            s.h = Heuristic(s.niz);
            if (IsLeaf(s))
            {
                player = (player == (Player)0 ? (Player)1 : (Player)0);
                if (s.h == 1000 && player == (Player)1)
                    PlayerScore ++;
                else if (s.h == -1000 && player == (Player)1)
                    CompScore ++;
                else if (s.h == 1000 && player == (Player)0)
                    CompScore ++;
                else if (s.h == -1000 && player == (Player)0)
                    PlayerScore ++;
                else
                    EqualScore ++;
            }
            AlphaBetaVM VM = new AlphaBetaVM()
            {
                array = Char2Dto1D(CopyRow(s.niz)),
                player = player,
                heuristic = s.h,
                isLeaf = (IsLeaf(s) ? "true": "false"),
                depth=depth,
                playerScore=PlayerScore,
                compScore=CompScore,
                equalScore=EqualScore,
                depths = new List<SelectListItem>()
                {
                    new SelectListItem{Text="Too Easy (1)",Value="1"},
                    new SelectListItem{Text="Easy (2)",Value="2"},
                    new SelectListItem{Text="Simple (3)",Value="3"},
                    new SelectListItem{Text="Medium (4)",Value="4"},
                    new SelectListItem{Text="Harder (5)",Value="5"},
                    new SelectListItem{Text="Hard (6)",Value="6"},
                    new SelectListItem{Text="Very difficult (7)",Value="7"},
                    new SelectListItem{Text="Extreme (8)",Value="8"},
                    new SelectListItem{Text="Impossible (9)",Value="8"}
                }
            };
            
            return PartialView("AlphaBetaA",VM);
        }
    }//U indexu da se prihvati array kojeg vrati partial view
}
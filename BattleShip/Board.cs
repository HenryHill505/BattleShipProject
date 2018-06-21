using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Board
    {
        public int height;
        public int width;
        public bool[,] shotResults;

        public Board(int height, int width)
        {
            this.height = height;
            this.width = width;
            this.shotResults = new bool[height, width];
        }

        public void DisplayToOwner() {
            for (int i = 0; i<height; i++)
            {
                for (int j = 0; j<width; j++)
                {
                    Console.Write(" ~");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

        public void DisplayToOpponent()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    switch (shotResults[i, j])
                    {
                        case true:
                            Console.Write(" x");
                            break;
                        case false:
                            Console.Write(" o");
                            break;
                        default:
                            Console.Write(" ~");
                            break;
                    }
                    
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}

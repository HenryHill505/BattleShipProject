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

        public Board(int height, int width)
        {
            this.height = height;
            this.width = width;
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
    }
}

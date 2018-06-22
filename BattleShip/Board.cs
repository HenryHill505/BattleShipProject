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
        public int[,] shotResults;
        public Destroyer destroyer;
        public Submarine submarine;
        public Battleship battleship;
        public AircraftCarrier aircraftCarrier;

        public Board(int height, int width)
        {
            this.height = height;
            this.width = width;
            this.shotResults = new int[height, width];
            this.destroyer = new Destroyer();
            this.submarine = new Submarine();
            this.battleship = new Battleship();
            this.aircraftCarrier = new AircraftCarrier();
        }

        public string DecideGridCharacter(int verticalPosition, int horizontalPosition)
        {

        }

        public void DisplayToOwner() {

            WriteTopGridNumbers();
            for (int i = 0; i<height; i++)
            {                
                for (int j = 0; j<width; j++)
                {
                    Console.Write(" |~");
                }
                Console.Write(" |" + i);
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
                        case 0:
                            Console.Write(" ~");
                            break;
                        case 1:
                            Console.Write(" x");
                            break;
                        case -1:
                            Console.Write(" 0");
                            break;
                    }
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

        public void WriteTopGridNumbers()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.Write(" |" + i);
            }
            for (int i = 11; i < width; i++)
            {
                Console.Write("|" + i);
            }
            Console.WriteLine(" ");

        }
    }
}

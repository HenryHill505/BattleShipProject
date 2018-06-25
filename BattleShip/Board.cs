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
        public bool[,] shotsTaken;
        public Ship[] unplacedShips;
        public List<Ship> placedShips;
        public Destroyer destroyer;
        public Submarine submarine;
        public Battleship battleship;
        public AircraftCarrier aircraftCarrier;

        public Board(int height, int width)
        {
            this.height = height;
            this.width = width;
            this.shotsTaken = new bool[height, width];
            this.destroyer = new Destroyer();
            this.submarine = new Submarine();
            this.battleship = new Battleship();
            this.aircraftCarrier = new AircraftCarrier();
            this.unplacedShips = new Ship[] { destroyer, submarine, battleship, aircraftCarrier };
            this.placedShips = new List<Ship>();
        }

        public string DecideGridCharacter(int verticalPosition, int horizontalPosition, bool DisplayShips)
        {
            try
            {   
                foreach(Ship placedShip in placedShips)
                {
                    if (placedShip.IsSpaceOcuppied(verticalPosition, horizontalPosition))
                    {
                        if (shotsTaken[verticalPosition, horizontalPosition])
                        {
                            return " |X";
                        } else if (DisplayShips)
                        {
                            return " |o";
                        }
                        else
                        {
                            return " |~";
                        }
                    }
                }
                if (shotsTaken[verticalPosition, horizontalPosition])
                {
                    return " |.";
                } else
                {
                    return " |~";
                }                
                if (destroyer.IsSpaceOcuppied(verticalPosition, horizontalPosition) || submarine.IsSpaceOcuppied(verticalPosition, horizontalPosition) || battleship.IsSpaceOcuppied(verticalPosition, horizontalPosition) || aircraftCarrier.IsSpaceOcuppied(verticalPosition, horizontalPosition))
                {
                    return " |o";
                }
                else
                {
                    return " |~";
                }
            }
            catch
            {
                return " |~";
            }
        }

        public void DisplayToOwner() {

            WriteTopGridNumbers();
            for (int i = 0; i<height; i++)
            {                
                for (int j = 0; j<width; j++)
                {
                    Console.Write(DecideGridCharacter(i,j,true));
                }
                Console.Write(" |" + i);
                Console.WriteLine("");
            }
        }

        public void DisplayToOpponent()
        {
            WriteTopGridNumbers();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(DecideGridCharacter(i, j, false));
                }
                Console.Write(" |" + i);
                Console.WriteLine("");
            }
        }
    

        public void PlaceShips()
        {   
            foreach (Ship unplacedShip in unplacedShips){
                do
                {
                    DisplayToOwner();

                    unplacedShip.PlaceShip(height, width);
 
                } while (isShipPlacementInvalid(unplacedShip));
                placedShips.Add(unplacedShip);
            }
        }

        public bool isShipPlacementInvalid(Ship ship)
        {
            for (int i = 0; i < ship.verticalCoordinates.Count(); i++)
            {
                for (int j = 0; j < ship.horizontalCoordinates.Count(); j++)
                {
                    //Console.WriteLine("That space is already occupied");
                    if (isSpaceOccupied(ship.verticalCoordinates[i], ship.horizontalCoordinates[j]))
                    {
                        Console.WriteLine($"That space is already occupied. Pick another space for {ship.type}");
                        return true;
                    }
                }
            }
            return false;
        }

        public bool isSpaceOccupied(int verticalCoordinate, int horizontalCoordinate)
        {
            try
            {
                foreach (Ship placedShip in placedShips)
                {
                    if (placedShip.IsSpaceOcuppied(verticalCoordinate, horizontalCoordinate))
                    {
                        return true;
                    }
                }
                return false;
            }

            catch
            {
                return false;
            }
        }

        public void ReceiveShot(int verticalCoordinate, int horizontalCoordinate)
        {
            if (isSpaceOccupied(verticalCoordinate, horizontalCoordinate))
            {
                foreach (Ship placedShip in placedShips)
                {
                    if (placedShip.IsSpaceOcuppied(verticalCoordinate, horizontalCoordinate))
                    {
                        Console.WriteLine($"{placedShip.type} is hit!");
                        placedShip.TakeHit();
                    }
                }
            }
            else
            {
                Console.WriteLine("You missed!");
            }
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

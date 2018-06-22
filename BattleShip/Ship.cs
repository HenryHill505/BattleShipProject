using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public abstract class Ship
    {
        public string type;
        public int hitSpaces;
        public int[] verticalCoordinates;
        public int[] horizontalCoordinates;

        public Ship()
        {
        }

        public virtual void PlaceShip()
        {
            Console.WriteLine("Pick the y coordinate for the Ship's stern");
            int sternVerticalCoordinate = int.Parse(Console.ReadLine());
            Console.WriteLine("Pick the x coordinate for the ship's stern");
            int sternHorizontalCoordinate = int.Parse(Console.ReadLine());

            Console.WriteLine("Is the ship pointed up, down, left, or right");
            string shipDirection = Console.ReadLine();
            switch (shipDirection)
            {
                case "up":
                    verticalCoordinates = new int[hitSpaces];
                    horizontalCoordinates = new int[1];
                    for (int i = 0; i < hitSpaces; i++)
                    {
                        verticalCoordinates[i] = sternVerticalCoordinate - i;
                    }
                    horizontalCoordinates[0] = sternHorizontalCoordinate;
                    break;
                case "down":
                    verticalCoordinates = new int[hitSpaces];
                    horizontalCoordinates = new int[1];
                    for (int i = 0; i < hitSpaces; i++)
                    {
                        verticalCoordinates[i] = sternVerticalCoordinate + i;
                    }
                    horizontalCoordinates[0] = sternHorizontalCoordinate;
                    break;
                case "left":
                    verticalCoordinates = new int[1];
                    horizontalCoordinates = new int[hitSpaces];
                    verticalCoordinates[0] = sternVerticalCoordinate;
                    for (int i = 0; i < hitSpaces; i++)
                    {
                        horizontalCoordinates[i] = sternHorizontalCoordinate - i;
                    }
                    break;
                case "right":
                    verticalCoordinates = new int[1];
                    horizontalCoordinates = new int[hitSpaces];
                    verticalCoordinates[0] = sternVerticalCoordinate;
                    for (int i = 0; i < hitSpaces; i++)
                    {
                        horizontalCoordinates[i] = sternHorizontalCoordinate + i;
                    }
                    break;
            }
            Console.WriteLine("Vertical Coordinates: ");
            foreach (int coordinate in verticalCoordinates)
            {
                Console.WriteLine($"{coordinate}, ");
            }

            Console.WriteLine("Horizontal Coordinates: ");
            foreach (int coordinate in horizontalCoordinates)
            {
                Console.WriteLine($"{coordinate}, ");
            }
            Console.ReadLine();
        }

        public virtual bool IsSpaceOcuppied(int verticalCoordinate, int horizontalCoordinate)
        {
            if ((Array.IndexOf(verticalCoordinates,verticalCoordinate) != -1) && (Array.IndexOf(horizontalCoordinates, horizontalCoordinate) != -1)){
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

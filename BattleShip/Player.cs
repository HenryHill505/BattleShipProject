using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Player
    {
        public string name;
        public Board board;

        public Player()
        {
            this.board = new Board(20,20);
        }

        public void Shoot(Player targetPlayer)
        {
            try
            {
                Console.WriteLine("Enter the x coordinate for your shot");
                int horizontalCoordinate = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the y coordinate for your shot");
                int verticalCoordinate = int.Parse(Console.ReadLine());
                if (!targetPlayer.board.shotsTaken[verticalCoordinate, horizontalCoordinate])
                {
                    targetPlayer.board.ReceiveShot(verticalCoordinate, horizontalCoordinate);
                    targetPlayer.board.shotsTaken[verticalCoordinate, horizontalCoordinate] = true;
                }
                else
                {
                    Console.WriteLine("You have already fired at this location. Pick another set of coordinates");
                    Shoot(targetPlayer);
                }
            }
            catch
            {
                Shoot(targetPlayer);
            }
        }
    }
}

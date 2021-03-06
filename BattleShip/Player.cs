﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Player
    {
        public bool hasLost;
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
                Console.Write("Your ships: ");
                board.DisplayShipsRemaining();
                targetPlayer.board.DisplayToOpponent();
                Console.WriteLine("Enter the x coordinate for your shot");
                int horizontalCoordinate = int.Parse(Console.ReadLine())-1;
                Console.WriteLine("Enter the y coordinate for your shot");
                int verticalCoordinate = int.Parse(Console.ReadLine())-1;
                if (!targetPlayer.board.shotsTaken[verticalCoordinate, horizontalCoordinate])
                {
                    targetPlayer.board.ReceiveShot(verticalCoordinate, horizontalCoordinate);
                    targetPlayer.board.shotsTaken[verticalCoordinate, horizontalCoordinate] = true;
                }
                else
                {
                    UI.ClearPause("You have already fired at this location. Pick another set of coordinates");
                    Shoot(targetPlayer);
                }
                foreach (Ship ship in targetPlayer.board.placedShips)
                {
                    if (ship.isDestroyed)
                    {
                        targetPlayer.hasLost = true;
                    }
                    else
                    {
                        targetPlayer.hasLost = false;
                        break;
                    }
                }
            }
            catch
            {
                UI.ClearPause("Error. Re-enter coordinates");
                Shoot(targetPlayer);
            }
        }
    }
}

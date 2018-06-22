using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class GameMaster
    {
        Player player1 = new Player();
        Player player2 = new Player();



        public void NamePlayers()
        {
            Console.WriteLine("Player1, enter your name");
            player1.name = Console.ReadLine();
            Console.WriteLine("Player2, enter your name");
            player2.name = Console.ReadLine();
        }

        public void SetPieces()
        {
            Console.WriteLine($"{player1.name}, set your pieces");
            player1.board.PlaceShips();
            Console.WriteLine($"{player2.name}, set your pieces");
            player2.board.PlaceShips();
        }

        public void RunGame()
        {
            NamePlayers();
            SetPieces();
            RunRound();
        }

        public void RunRound()
        {
            player1.Shoot(player2);
            player2.Shoot(player1);
        }

    }
}

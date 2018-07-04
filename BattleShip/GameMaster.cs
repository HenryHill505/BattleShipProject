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


        public void DisplayGameResults()
        {
            if (player1.hasLost)
            {
                Console.WriteLine($"{player2.name} has won!");
            }
            else if (player2.hasLost)
            {
                Console.WriteLine($"{player1.name} has won!");
            }
            Console.ReadLine();
        }

        public void NamePlayers()
        {
            Console.WriteLine("Player1, enter your name");
            player1.name = Console.ReadLine();
            Console.WriteLine("Player2, enter your name");
            player2.name = Console.ReadLine();
        }

        public void SetPieces()
        {
            UI.ClearPause($"{player1.name}'s turn to place ships");
            player1.board.PlaceShips();
            UI.ClearPause($"{player2.name}'s turn to place ships");
            player2.board.PlaceShips();
        }

        public void RunGame()
        {
            NamePlayers();
            SetPieces();
            while (!player1.hasLost && !player2.hasLost)
            {
                RunRound();
            }
            DisplayGameResults();            
        }

        public void RunRound()
        {
            Console.WriteLine($"{player1.name}'s turn");
            player1.board.DisplayToOwner();
            player1.Shoot(player2);
            if (!player2.hasLost)
            {
                Console.WriteLine($"{player2.name}'s turn");
                player2.board.DisplayToOwner();
                player2.Shoot(player1);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Board gameBoard = new Board(20,20);
            gameBoard.DisplayToOwner();

        }
    }
}

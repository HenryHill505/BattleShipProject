using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Battleship : Ship
    {
        public Battleship()
        {
            type = "Battleship";
            hitSpaces = 4;
        }
    }
}

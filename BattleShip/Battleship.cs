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
            this.type = "Battleship";
            this.hitSpaces = 4;
        }
    }
}

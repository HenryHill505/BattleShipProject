using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Destroyer : Ship
    {
        public Destroyer()
        {
            this.type = "Destroyer";
            this.hitSpaces = 2;
        }
    }
}

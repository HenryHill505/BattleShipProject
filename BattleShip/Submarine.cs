using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Submarine : Ship
    {
        public Submarine()
        {
            this.type = "Submarine";
            this.hitSpaces = 3;
        }
    }
}

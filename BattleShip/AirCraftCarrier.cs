using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class AircraftCarrier : Ship
    {

        public AircraftCarrier()
        {
            this.type = "Aircraft Carrier";
            this.hitSpaces = 5;
        }
    }
}

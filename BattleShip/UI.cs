using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public static class UI
    {
        public static void ClearPause(string input)
        {
            Console.Clear();
            Console.WriteLine(input);
            Console.ReadLine();
            Console.Clear();
        }

        public static void PauseClear()
        {
            Console.ReadLine();
            Console.Clear();
        }
    }
}

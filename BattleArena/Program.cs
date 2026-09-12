using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var Raymond = new Raymond(100, 30, 3);
            var Kirk = new Cods(200, 15, 5);
            var Cods = new Kirk(150, 30, 10);
            Cods.DisplayStatus();
            Kirk.DisplayStatus();
            Raymond.DisplayStatus();

            while (Raymond.IsAlive && Kirk.IsAlive && Cods.IsAlive)
            {
                Console.WriteLine("\n\n----------------------------------------------");
                Raymond.Attack(Kirk);
                Kirk.DisplayStatus();
                Console.WriteLine("----------------------------------------------");
                Cods.Attack(Raymond);
                Raymond.DisplayStatus();
                Console.WriteLine("----------------------------------------------");
                Kirk.Attack(Cods);
                Cods.DisplayStatus();
            }

            Console.ReadKey();
        }
    }
}

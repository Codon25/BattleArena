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
            int round = 1;
            Warrior Raymond = new Warrior("Raymond", 100, 30, "Dinuraan");
            Warrior Kirk = new Warrior("Kirk", 200, 15, "Dinaganan");
            Warrior Cods = new Warrior("Cods", 150, 30, "Fire Ball");

            Raymond.DisplayStats();
            Kirk.DisplayStats();
            Cods.DisplayStats();
             
            while(Raymond.IsAlive && Kirk.IsAlive && Cods.IsAlive)
            {
                Console.WriteLine($"------Round {round}------");
                Raymond.Attack(Kirk);
                Kirk.Attack(Cods);
                Cods.Attack(Raymond);
                Console.WriteLine("----------------");
                round++;
            }

            Console.ReadKey();
        }
    } 
}

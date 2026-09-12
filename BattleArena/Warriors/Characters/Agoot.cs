using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena.Warriors.Characters
{
    public class Agoot : Warrior
    {
        public Agoot(string name, int health, int attackPower, WarriorType warriorType) 
            : base(name, health, attackPower, warriorType)
        {

        }

        public override void Attack(Warrior target)
        {
            throw new NotImplementedException();
        }
    }
}

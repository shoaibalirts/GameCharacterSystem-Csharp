using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GameCharacterSystem
{
    public class Dragon : Character
    {
        public Dragon(string name, int health, int attack, int defense)
            : base(name, health, attack, defense)
        {
            // no additional code required as per specification 
        }

        public void BreatheFire(Character target)
        {
            var damage = attack * 4 - target.defense;
            if (damage > 0)
            {
                target.health -= damage;
                Console.WriteLine($"{name} breathes fire on {target.name} for {damage} damage!");
            }
            else
            {
                Console.WriteLine($"{name}'s fire has no effect on {target.name}.");
            }
        }

        public override void Attack(Character target)
        {
            int damage = attack * 2 - target.defense;
            if (damage > 0)
            {
                target.health -= damage;
                Console.WriteLine($"{name} attacks {target.name} for {damage} damage!");
            }
            else
            {
                Console.WriteLine($"{name}'s attack has no effect on {target.name}.");
            }
        }

        public override void Defend()
        {
            defense += 10;
            Console.WriteLine($"{name} defends and gains 10 defense.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacterSystem
{
    public class Game
    {
        public void Battle(Character c1, Character c2)
        {
            Console.WriteLine("$--- Battle between {c1.name} and {c2.name} ---");
            while (c1.health > 0 && c2.health > 0)
            {
                c1.Attack(c2);
                if (c2.health > 0)
                {
                    c2.Attack(c1);
                }
            }

            if (c1.health <= 0)
            {
                Console.WriteLine($"{c2.name} wins!");
            }
            else
            {
                Console.WriteLine($"{c1.name} wins!");
            }
            
           
        }
    }
}

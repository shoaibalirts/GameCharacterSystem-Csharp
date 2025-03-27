using System;

namespace GameCharacterSystem
{
    public class Mage : Warrior
    {
        public Mage(string name, int health, int attack, int defense)
            : base(name, health, attack, defense)
        {
            // no additional code required as per specification
        }

        public void CastSpell(Character target)
        {
            int damage = attack * 3 - target.defense;
            if (damage > 0)
            {
                target.health -= damage;
                Console.WriteLine($"{name} casts a spell on {target.name} for {damage} damage!");
            }
            else 
            {
                Console.WriteLine($"{name}'s spell has no effect on {target.name}.");
            }

        }

        public sealed override void Defend()
        {
            Console.WriteLine($"{name} cannot defend!");
        }
    }
}
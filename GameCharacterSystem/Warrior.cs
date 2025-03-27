using System;

namespace GameCharacterSystem
{
    public class Warrior : Character
    {
        public Warrior(string name, int health, int attack, int defense)
            :base(name, health, attack, defense)
        {
            // no additional code required as per specification
        }

        public void Charge(Character target)
        {
            var damage = attack * 2 - target.defense;
            if (damage > 0)
            {
                target.health -= damage;
                Console.WriteLine($"{name} charges {target.name} for {damage} damage!");
            }
            else
            {
                Console.WriteLine($"{name}'s charge has no effect on {target.name}.");
            }
        }

        public override void Defend()
        {
            defense += 5;
            Console.WriteLine($"{name} defends and gains 5 defense.");
        }
    }
}
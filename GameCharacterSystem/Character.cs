using System;

namespace GameCharacterSystem
{
    public class Character
    {
        public string name;
        public int health;
        public int attack;
        public int defense;

        public Character(string name, int health, int attack, int defense)
        {
            this.name = name;
            this.health = health;
            this.attack = attack;
            this.defense = defense;
        }

        public virtual void Attack(Character target)
        {
            int damage = attack - target.defense;
            if (damage > 0)
            {
                target.health -= damage; // target.health = target.health - damage
                Console.WriteLine($"{name} attacks {target.name} for {damage} damage!");
            }
            else 
            {
                Console.WriteLine($"{name}'s attack has no effect on {target.name}");
            }
        }

        public virtual void Defend()
        {
            Console.WriteLine($"{name} defends.");
        }
    }
}
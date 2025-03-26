# Game Character System
#### Objectives
- Understand and apply inheritance and polymorphism in C#.
- Use constructors to chain initialization of base classes and derived classes.
- Implement method overriding and method hiding to modify behaviors in derived classes.
- Write a system that models interactions between characters using specific methods and behaviors.

#### Requirements
- You will create a character-based battle system consisting of a base class and derived classes, following these instructions:

#### Base Class: Character
- The Character class serves as the foundation for all other character types. It should include:

Properties:

string name - The name of the character.

int health - The health points of the character.

int attack - The attack value of the character.

int defense - The defense value of the character.

Constructor:

Initializes the name, health, attack, and defense properties.

Methods:

virtual void Attack(Character target)

Calculates the damage dealt to the target character using the formula:
damage = attack - target.defense.

If damage > 0: Decreases the target's health by the calculated damage and prints:
"[name] attacks [target.name] for [damage] damage!".

If damage <= 0: Prints:
"[name]'s attack has no effect on [target.name].".

virtual void Defend()

Prints:
"[name] defends."



Derived Classes
You will create three derived classes from Character: Warrior, Mage, and Dragon. Each class will add unique behavior.

1. Class: Warrior
The Warrior represents a strong melee fighter.

Constructor:

Inherits from the Character class and initializes the base class constructor with values for name, health, attack, and defense.

Additional Methods:

void Charge(Character target)

Deals double the Warrior's attack value as damage:
damage = attack * 2 - target.defense.

If damage > 0: Decreases the target's health by the calculated damage and prints:
"[name] charges [target.name] for [damage] damage!".

If damage <= 0: Prints:
"[name]'s charge has no effect on [target.name]."

Overridden Methods:

override void Defend()

Increases the Warrior's defense by 5 and prints:
"[name] defends and gains 5 defense."



2. Class: Mage
The Mage represents a spellcaster with high magical damage.

Constructor:

Inherits from the Character class and initializes the base class constructor with values for name, health, attack, and defense.

Additional Methods:

void CastSpell(Character target)

Deals three times the Mage's attack value as damage:
damage = attack * 3 - target.defense.

If damage > 0: Decreases the target's health by the calculated damage and prints:
"[name] casts a spell on [target.name] for [damage] damage!".

If damage <= 0: Prints:
"[name]'s spell has no effect on [target.name]."

Overridden Methods:

sealed override void Defend()

Prevents further overriding in derived classes.

Prints:
"[name] cannot defend!"



3. Class: Dragon
The Dragon represents a powerful mythical creature.

Constructor:

Inherits from the Character class and initializes the base class constructor with values for name, health, attack, and defense.

Additional Methods:

void BreatheFire(Character target)

Deals four times the Dragon's attack value as damage:
damage = attack * 4 - target.defense.

If damage > 0: Decreases the target's health by the calculated damage and prints:
"[name] breathes fire on [target.name] for [damage] damage!".

If damage <= 0: Prints:
"[name]'s fire has no effect on [target.name]."

Overridden Methods:

override void Attack(Character target)

Doubles the Dragon's attack value during an attack:
damage = attack * 2 - target.defense.

If damage > 0: Decreases the target's health by the calculated damage and prints:
"[name] attacks [target.name] for [damage] damage!".

If damage <= 0: Prints:
"[name]'s attack has no effect on [target.name]."

override void Defend()

Increases the Dragon's defense by 10 and prints:
"[name] defends and gains 10 defense."



Class: Game
This class simulates a battle between characters.

Methods:

void Battle(Character c1, Character c2)

Simulates a turn-based battle between two characters until one character's health drops to 0 or below.

Prints a message at the start:
"--- Battle between [c1.name] and [c2.name] ---".

On each turn:

Character 1 attacks Character 2.

If Character 2 is still alive, it attacks Character 1.

At the end of the battle, prints the winner's name.



Main Method
Create one object of each type (Warrior, Mage, Dragon) with appropriate values for name, health, attack, and defense.

Test the Attack, Defend, Charge, CastSpell, and BreatheFire methods for these objects.

Use the Game class to simulate battles between characters and display the results.



Expected Output Example
Arthur attacks Merlin for 15 damage!
Merlin cannot defend!
Smaug breathes fire on Arthur for 110 damage!
Smaug defends and gains 10 defense.
Arthur defends and gains 5 defense.
--- Battle between Arthur and Merlin ---
Merlin wins!
--- Battle between Smaug and Arthur ---
Smaug wins!
--- Battle between Merlin and Smaug ---
Merlin's attack has no effect on Smaug.
Smaug attacks Merlin for 60 damage!
Smaug wins!


Notes for Students
Ensure all methods strictly follow the behaviors defined here.

Pay attention to method overriding and the use of sealed and override.

Test thoroughly to ensure all interactions work as expected.

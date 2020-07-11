using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCodes.WarriorGame
{
    class Warrior
    {
        private const int GOOD_GUY_STARTING_HEALTH = 20; //Const
        private const int BAD_GUY_STARTING_HEALTH = 20; //Const

        private readonly Faction FACTION; //readonly so no one can change it. is defined i constructor
        private int health;
        private string name;
        private bool isAlive;      //fields

        public bool IsAlive         //property
        { get { return isAlive; } }

        private Weapon weapon;   //datatype named weapon
        private Armor armor;       //datatype named armor




        public Warrior(string name, Faction faction) //constructor with two args
        {
            this.name = name;     //we set that the name in arg is equal to the name field
            FACTION = faction;   //here we set the value of our readonly FACTION

            isAlive = true;     //Bcs when the warrior is created it is alive

            switch (faction)            //SWITCH
            {
                case Faction.GoodGuy:   //case for the goodGuy
                    weapon = new Weapon(faction); //gives the good guy a weapon and armor
                    armor = new Armor(faction);
                    health = GOOD_GUY_STARTING_HEALTH;  //gives a starting health
                    break;

                case Faction.BadGuy:    //case for the badGuy
                    weapon = new Weapon(faction);   //gives the bad guy a weapon
                    armor = new Armor(faction);   //and armor
                    health = BAD_GUY_STARTING_HEALTH;  //and start health
                    break;

                default:
                    break;
            }
        }

        public void Attack(Warrior enemy) //method with one argument
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoints; //vi tar damage til våpne til den gitte warrioren og lagrer det i en int kalt damage
            enemy.health -= damage;
            AttackResult(enemy, damage);
        }

        public void AttackResult(Warrior enemy, int damage)
        {
            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                Tools.colorfulWriteLine($"{enemy.name} is dead. ", ConsoleColor.Red);
                Tools.colorfulWriteLine($"{name} is the winner", ConsoleColor.Green);
            }
            else
            {
                Console.WriteLine($"{name} attacked {enemy.name}. {damage} was inflicted to {enemy.name}. Remaining health of {enemy.name} is {enemy.health}");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCodes.WarriorGame
{
    class GameProgram
    {
        static Random random = new Random(); //Nytt random nummer
        public static void Main(string[] args)
        {

            Warrior goodGuy = new Warrior("Albert", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Chicko", Faction.BadGuy);

            while (goodGuy.IsAlive == true && badGuy.IsAlive == true)

            {
                if (random.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
                Thread.Sleep(200);

            }
        }

    }
}

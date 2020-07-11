using System;
using System.Collections.Generic;
using System.Text;


namespace DesignPatternCodes.WarriorGame
{
    class Armor
    {
        private const int GOOD_GUY_ARMOR = 5;   //const, its always 5
        private const int BAD_GUY_ARMOR = 5;     //same here
        private int armorPoints;                                 //int for armorPoints

        public int ArmorPoints                 //Porperty for armorPoints
        {
            get { return armorPoints; }   //readonly, kun mulig å returnere verdien
        }

        public Armor(Faction faction)  //Constructor med ett argument.
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    armorPoints = GOOD_GUY_ARMOR;
                    break;

                case Faction.BadGuy:
                    armorPoints = BAD_GUY_ARMOR;
                    break;

                default:
                    break;
            }
        }

    }
}

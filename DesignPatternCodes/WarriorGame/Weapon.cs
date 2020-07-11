using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCodes.WarriorGame
{
    class Weapon
    {
        private const int GOOD_GUY_DAMAGE = 5; //CMD + R + R -> lar deg forandre alle som har d navnet
        private const int BAD_GUY_DAMAGE = 5;
        private int damage;

        public int Damage
        {
            get { return damage; }
        }

        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    damage = GOOD_GUY_DAMAGE;
                    break;

                case Faction.BadGuy:
                    damage = BAD_GUY_DAMAGE;
                    break;

                default:
                    break;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateDamageWithArrows
{
    class WeaponDamage
    {
        private int roll;

        /// <summary>
        /// Sets or gets the 3d6 roll.
        /// </summary>
        public int Roll { get { return roll; } set { roll = value; CalculateDamage(); } }


        private bool flaming;
        /// <summary>
        /// True if sword is flaming. False otherwise.
        /// </summary>
        public bool Flaming { get { return flaming; } set { flaming = value; CalculateDamage(); } }

        private bool magic;

        /// <summary>
        /// True if sword is magic. False otherwise.
        /// </summary>
        public bool Magic { get { return magic; } set { magic = value; CalculateDamage(); } }

        /// <summary>
        /// Contains the calculated damage.
        /// </summary>
        public int Damage { get; protected set; }

        public WeaponDamage (int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }

        protected virtual void CalculateDamage()
        {
            //Subclasses override this
            Console.WriteLine("Such meine dich if you can read dis.");
        }
    }

    }

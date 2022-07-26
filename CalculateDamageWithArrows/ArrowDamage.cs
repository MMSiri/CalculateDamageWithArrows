using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateDamageWithArrows
{
    class ArrowDamage
    {
        /// <summary>
        /// Constructor calcs damage based on default Magic and Flaming values and a starting 3d6 roll.
        /// </summary>
        /// <param name="startingRoll">starting 3d6 roll</param>
        public ArrowDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }


        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;

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
        public int Damage { get; private set; }

        /// <summary>
        /// Calcs damage based on current properties.
        /// </summary>
        private void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic) baseDamage *= MAGIC_MULTIPLIER;
            if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);
        }
    }
}

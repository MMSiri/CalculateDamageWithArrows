using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateDamageWithArrows
{
    class SwordDamage : WeaponDamage
    {
        /// <summary>
        /// Constructor calcs damage based on default Magic and Flaming values and a starting 3d6 roll.
        /// </summary>
        /// <param name="startingRoll">starting 3d6 roll</param>
        public SwordDamage(int startingRoll) : base(startingRoll)
        {

        }

        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        /// <summary>
        /// Calcs damage based on current properties.
        /// </summary>
        protected override void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = 1.75M;

            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;
        }
    }
}

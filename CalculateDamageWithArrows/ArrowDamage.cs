using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateDamageWithArrows
{
    class ArrowDamage : WeaponDamage
    {
        /// <summary>
        /// Constructor calcs damage based on default Magic and Flaming values and a starting 3d6 roll.
        /// </summary>
        /// <param name="startingRoll">starting 3d6 roll</param>
        public ArrowDamage(int startingRoll) : base(startingRoll)
        {

        }

        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;

        /// <summary>
        /// Calcs damage based on current properties.
        /// </summary>
        protected override void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic) baseDamage *= MAGIC_MULTIPLIER;
            if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);
        }
    }
}

using System;

namespace CalculateDamageWithArrows
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter '0' for no Magic/Flaming, '1' for Magic, '2' for Flaming, '3' for Both, any other key to exit:");
                char input = Console.ReadKey(false).KeyChar;
                if (input != '0' && input != '1' && input != '2' && input != '3') return;


                Console.Write("\n'S' for Sword, 'A' for Arrow, any other key to exit: ");
                char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);

                switch (weaponKey)
                {
                    case 'S':
                        WeaponDamageOutput(input, weaponKey);
                        break;

                    case 'A':
                        WeaponDamageOutput(input, weaponKey);
                        break;

                    default:
                        return;
                }

            }
        }

        private static int RollDice(int numberOfRolls)
        {
            int diceTotal = 0;
            for (int i = 0; i < numberOfRolls; i++)
            {
                diceTotal += random.Next(1, 7);
            }
            return diceTotal;
        }

        private static void WeaponDamageOutput(char damageKey, char weaponKey)
        {
            SwordDamage swordDamage = new SwordDamage(RollDice(3));
            ArrowDamage arrowDamage = new ArrowDamage(RollDice(1));

            if (weaponKey == 'S') 
            { 
                swordDamage.Roll = RollDice(3);
                swordDamage.Magic = (damageKey == '1' || damageKey == '3');
                swordDamage.Flaming = (damageKey == '2' || damageKey == '3');
                Console.WriteLine('\n' + $"Rolled {swordDamage.Roll} for {swordDamage.Damage}HP of damage");
            }

            if (weaponKey == 'A')
            {
                arrowDamage.Roll = RollDice(1);
                arrowDamage.Magic = (damageKey == '1' || damageKey == '3');
                arrowDamage.Flaming = (damageKey == '2' || damageKey == '3');
                Console.WriteLine('\n' + $"Rolled {arrowDamage.Roll} for {arrowDamage.Damage}HP of damage");
            }
        }
        }
    }

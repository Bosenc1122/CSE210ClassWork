using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFighter
{
    class Paladin : Player
    {
        public override string PlayerClass { get; protected set; } = "Paladin";
        public override string HealItemsType { get; protected set; } = "Healing Prayer";
        public override string _name { get; protected set; }
        protected override double _accuracyP { get; } = 0.80;
        public override short HealItems { get; set; } = 6;
        public double HealChance { get; set; } = 0.50;

       public override void GiveDmg(Npc name)
        {
            //Check player accuracy 'IsSuccessful' method is true.
            if (IsSuccessful())
            {
                short dmg = GameFunctions.RndNext(16, 28);
                name.Health -= dmg;

                //clamp health to not go below 0
                if (name.Health < 0) name.Health = 0;
                else
                {
                    GameFunctions.AddToCombatLog($"{_name} slashes their sword for {dmg} damage.");
                }
            }
            else
            {
                GameFunctions.AddToCombatLog($"{_name} missed!");
            }
        }

        public override void HealSelf()
        {
            short heal = GameFunctions.RndNext(30, 90);
            short newHealth = (short)(Health + heal);

            if (newHealth > 100) newHealth = 100;

            if (Health > 0)
            {
                Health = newHealth;
                GameFunctions.AddToCombatLog($"{_name} used Health Potion for {heal} health.");
                HealItems--;
            }
            else
            {
                Health = 0;
            }
        }

        public override void SpecialMove(Npc name)
        {
            if (SpecialMoves > 0)
            {
                short dmg = GameFunctions.RndNext(170, 350);
                GameFunctions.AddToCombatLog($"You call forth the power of your deity against {name.NpcRace} for {dmg} damage!");
                name.Health -= dmg;
                SpecialMoves--;
            }
            else
            {
                GameFunctions.AddToCombatLog("You're out of special moves!");
            }
        }
    }
}
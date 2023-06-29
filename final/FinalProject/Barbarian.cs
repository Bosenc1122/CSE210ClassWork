using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFighter
{
    class Barbarian : Player
    {
        public override string PlayerClass { get; protected set; } = "Barbarian";
        public override string HealItemsType { get; protected set; } = "Healing Leg of Lamb";
        public override string _name { get; protected set; }
        protected override double _accuracyP { get; } = 0.60;
        public override short HealItems { get; set; } = 4;
        public double HealChance { get; set; } = 0.50;

       public virtual void GiveDmg(Npc name)
        {
            //Check player accuracy 'IsSuccessful' method is true.
            if (IsSuccessful())
            {
                short dmg = GameFunctions.RndNext(20, 35);
                name.Health -= dmg;

                //clamp health to not go below 0
                if (name.Health < 0) name.Health = 0;
                else
                {
                    GameFunctions.AddToCombatLog($"{_name} smashes axe down for {dmg} damage.");
                }
            }
            else
            {
                GameFunctions.AddToCombatLog($"{_name} missed!");
            }
        }

        public override void HealSelf()
        {
            short heal = GameFunctions.RndNext(40, 60);
            short newHealth = (short)(Health + heal);

            if (newHealth > 100) newHealth = 100;

            if (Health > 0)
            {
                Health = newHealth;
                GameFunctions.AddToCombatLog($"{_name} ate a Lamb Leg for {heal} health.");
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
                short dmg = GameFunctions.RndNext(200, 300);
                GameFunctions.AddToCombatLog($"You yell summoning great inner strenghth and throw your axe which crushes the {name.NpcRace} for {dmg} damage!");
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
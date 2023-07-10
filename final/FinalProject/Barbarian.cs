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
        protected override double _accuracyP { get; } = 0.65;
        public override short HealItems { get; set; } = 4;
        public double HealChance { get; set; } = 0.50;

       public override void GiveDmg(Npc name)
        {
            
            if (IsSuccessful())
            {
                short dmg = GameFunctions.RndNext(25, 50);
                name.Health -= dmg;

                
                if (name.Health < 0) name.Health = 0;
                else
                {
                    GameFunctions.AddToCombatLog($"{_name} smashes axe down for {dmg} damage.");
                    if (dmg >= 49)
                    {
                        GameFunctions.AddToCombatLog($"{_name} gets a critical hit on {name.NpcRace} for another 50 damage");
                        dmg += 50;
                    }
                    else
                    {
                        
                    }
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
                short dmg = GameFunctions.RndNext(220, 340);
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
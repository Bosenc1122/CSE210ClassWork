using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFighter
{
    class Ranger : Player
    {
        public override string PlayerClass { get; protected set; } = "Ranger";
        public override string HealItemsType { get; protected set; } = "Health Potion";
        public override string _name { get; protected set; }
        protected override double _accuracyP { get; } = 0.95;
        public override short HealItems { get; set; } = 7;
        public double HealChance { get; set; } = 0.70;

       public override void GiveDmg(Npc name)
        {
           
            if (IsSuccessful())
            {
                short dmg = GameFunctions.RndNext(15, 26);
                name.Health -= dmg;

                
                if (name.Health < 0) name.Health = 0;
                else
                {
                    GameFunctions.AddToCombatLog($"{_name} shoots arrow for {dmg} damage.");
                    if (dmg <= 22)
                    {
                        GameFunctions.AddToCombatLog($"{_name}'s animal companion attacks {name.NpcRace} for another 10 damage");
                        name.Health -= 10;
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
            short heal = GameFunctions.RndNext(50, 75);
            short newHealth = (short)(Health + heal);

            if (newHealth > 100) newHealth = 100;

            if (Health > 0)
            {
                Health = newHealth;
                GameFunctions.AddToCombatLog($"{_name} drank Health Potion for {heal} health.");
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
                short dmg = GameFunctions.RndNext(180, 290);
                GameFunctions.AddToCombatLog($"You call your animal companion and it attacks the {name.NpcRace} for {dmg} damage!");
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
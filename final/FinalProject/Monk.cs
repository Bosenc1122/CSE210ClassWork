using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFighter
{
    class Monk : Player
    {
        public override string PlayerClass { get; protected set; } = "Monk";
        public override string HealItemsType { get; protected set; } = "Healing Aura";
        public override string _name { get; protected set; }
        protected override double _accuracyP { get; } = 0.95;
        public override short HealItems { get; set; } = 5;
        public double HealChance { get; set; } = 0.70;

       public override void GiveDmg(Npc name)
        {
            
            if (IsSuccessful())
            {
                short dmg = GameFunctions.RndNext(13, 25);
                name.Health -= dmg;

                
                if (name.Health < 0) name.Health = 0;
                else
                {
                    GameFunctions.AddToCombatLog($"{_name} throws a strong punch for {dmg} damage.");
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
                GameFunctions.AddToCombatLog($"{_name} used Healing Aura for {heal} health.");
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
                short dmg = GameFunctions.RndNext(140, 270);
                GameFunctions.AddToCombatLog($"You jump up  and come down with a powerful axe kick which hits the {name.NpcRace} for {dmg} damage!");
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
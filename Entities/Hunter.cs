using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJDIOGFT.Entities
{
    internal class Hunter : Hero
    {
        public Hunter(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Piercing Arrow";
        }
        public string Attack(int Bonus)
        {

            if (Bonus > 8)
            {
                return this.Name + " Attacked used Piercing Arrow with bonus " + Bonus;
            }
            else
            {
                return this.Name + " Attacked used Hail of Arrows " + Bonus;
            }
        }
    }
}

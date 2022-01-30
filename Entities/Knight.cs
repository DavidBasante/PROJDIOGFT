using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJDIOGFT.Entities
{
    internal class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Attacked with sword";
        }
        public string Attack(int Bonus)
        {

            if (Bonus > 8)
            {
                return this.Name + " Attacked with two swords with fury " + Bonus;
            }
            else
            {
                return this.Name + "  Attacked with two swords" + Bonus;
            }
        }
    }
}

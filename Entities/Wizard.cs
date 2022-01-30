using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJDIOGFT.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
       public override string Attack()
        {
            return this.Name + " Used Cosmic Explosion";
        }

        public string Attack(int Bonus){

            if (Bonus > 8){
                return this.Name + " Used Cosmic Explosion with bonus " + Bonus;
            }
            else
            {
                return this.Name + " Used Tormented Shadow with bonus" + Bonus;
            }

        }
    }
}

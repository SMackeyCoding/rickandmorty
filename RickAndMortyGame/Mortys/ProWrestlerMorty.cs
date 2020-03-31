using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RickAndMortyGame.Attack;

namespace RickAndMortyGame.Mortys
{
    class ProWrestlerMorty : IMorty
    {
        public int Health { get; set; } = 25;

        public Attack Attack()
        {
            return new Attack(10, 20, DamageType.Bludgeoning);
        }

        public void Hurt(Attack damage)
        {
            if (damage.Type == DamageType.Piercing || damage.Type == DamageType.Fire)
            {
                damage.Damage = (int)Math.Floor((double)damage.Damage * 2);
            }
            else if (damage.Type == DamageType.Bludgeoning || damage.Type == DamageType.Psych)
            {
                damage.Damage = (int)Math.Ceiling(damage.Damage * 0.5);
            }
            Health -= damage.Damage;
        }

        public void Scream()
        {
            Console.WriteLine("I'M GONNA BRING THE PAIN, OHHHH YEAHHHHH!!!");
        }
    }
}

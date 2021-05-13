using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pair_Programming.Attack;
namespace Pair_Programming
{
    public interface Boss
    {
        int Health { get; }
        void Scream();
        void Hurt(int damage);
        int Attack(Attack attack);
        Attack attack();
    }
    public class SubBoss : DungeonGame
    {
        private string Slashing;
        public int Health { get; set; } = 25;
        public void Scream()
        {
            Console.WriteLine("YOU DO NOT BELONG HERE. GET OUT!");
        }
        public void Hurt(Attack attack)
        {
            Health -= attack.Damage;
        }
        public Attack Enemy()
        {
            return new Attack(5, 10, DamageType.Slashing, "Flash Attack");
        }
        public Attack ShockAttack()
        {
            return new Attack(8, 10, DamageType.Shocking, "Shock of Death");
        }
        public Attack FireAttack()
        {
            return new Attack(9, 10, DamageType.Fire, "Light up your life");
        }
    }
}
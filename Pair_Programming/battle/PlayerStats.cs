using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pair_Programming.Attack;
namespace Pair_Programming
{
    public interface IPlayer
    {
        int Health { get; }

    }

    public class PlayerStats : IPlayer
    {

        public int Health => 50;

        public Attack BroomAttack()
        {
            return new Attack(6, DamageType.Bludgeoning, "Swish Swish");
        }

        public Attack RustySwordAttack()
        {
            return new Attack(15, DamageType.Sword, "Rusty Sword Attack");
        }

        public Attack SaberAttack()
        {
            return new Attack(25, DamageType.Sword, "Sword attack");
        }

    }

}

using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Bow : Weapon
    {
        public int range;

        public void Shoot()
        {

        }

        public override void Equip(Player player)
        {
            base.Equip(player);
        }

        public override void DealDamage(Entity target)
        {
            base.DealDamage(target);
        }
    }
}

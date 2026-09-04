using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Sword : Weapon
    {
        public int bladeLength;

        public void Slash()
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

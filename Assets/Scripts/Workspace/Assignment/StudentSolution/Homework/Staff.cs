using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Staff : Weapon
    {
        public int magicPower;

        public void CastSpell()
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

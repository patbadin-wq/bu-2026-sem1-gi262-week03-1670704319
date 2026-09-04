using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Mage : RangeEnemy
    {
        public int mana;
        public override void Attack (Entity target)
        {
            base.Attack(target);
        }
        public void CastSpell(Entity target)
        {

        }
    }
}

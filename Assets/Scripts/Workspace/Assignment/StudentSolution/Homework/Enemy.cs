using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Enemy : Entity
    {
        public int damage;
        protected int aiLevel;

        public virtual void Attack(Entity traget)
        {

        }

        protected virtual void Patrol()
        {

        }
    }
}

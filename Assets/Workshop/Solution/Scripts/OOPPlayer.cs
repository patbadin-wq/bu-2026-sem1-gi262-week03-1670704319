using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

namespace Solution
{

    public class OOPPlayer : Character
    {
        private InputAction moveAction;

        public void Start()
        {
            moveAction = InputSystem.actions.FindAction("Move");
            
        }

        public void Update()
        {
            Vector2 direction = moveAction.ReadValue<Vector2>();
            
            if (moveAction.triggered)
            {
                Move(direction);
            }
           
        }

       

    }

}
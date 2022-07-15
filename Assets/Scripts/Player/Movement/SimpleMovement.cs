using System;
using UnityEngine;

namespace Player.Movement
{
    [RequireComponent(typeof(CharacterController))]
    public sealed class SimpleMovement : MonoBehaviour
    {
        private const string ForwardInputAxis = "Vertical";
        private const string SideInputAxis = "Horizontal";
        
        [SerializeField] private float walkSpeed;
        [SerializeField] private float runSpeed;
            
        private CharacterController _characterController;
        private bool _moving;
        private bool _running;

        public event Action startedWalking;
        public event Action startedRunning;
        
        private void Awake()
        {
            InitComponents();
        }

        private void InitComponents()
        {
            _characterController = GetComponent<CharacterController>();
        }

        private void UpdateMovingState()
        {
            if (Input.GetKeyDown()
        }

        private Vector3 GetMoveDirection()
        {
            float forwardInput = Input.GetAxis(ForwardInputAxis);
            float sideInput = Input.GetAxis(ForwardInputAxis);
            Vector3 moveDirection = new(forwardInput, 0f, sideInput);
            return moveDirection.normalized;
        }
    }
}

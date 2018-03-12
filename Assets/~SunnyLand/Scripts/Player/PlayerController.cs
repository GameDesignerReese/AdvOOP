using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SunnyLand.Player
{
    [RequireComponent(typeof(SpriteRenderer))]
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
        public float speed = 5;
        public float maxVelocity = 2;
        public float rayDistance = 0.5f;
        public float jumpheight = 2;
        public int maxJumpCount = 2;
        public LayerMask groundLayer;

        private Vector3 movDirection;
        public int currentJump;

        private SpriteRenderer rend;
        private Animator anim;
        private Rigidbody2D rigid;

        void Start()
        {
            rend = GetComponent<SpriteRenderer>();
            anim = GetComponent<Animator>();
            rigid = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            movDirection.y += Physics.gravity.y * Time.deltaTime;
        }

        void FixedUpdate()
        {
            DetectGround();
        }

        void OnDrawGizmo()
        {
            Ray groundRay = new Ray(transform.position, Vector3.down);
            Gizmos.DrawLine(groundRay.origin, groundRay.origin + groundRay.direction * rayDistance);
        }

        void DetectGround()
        {
            /*
            Create a ray going down
            Set hit to 2D Raycast
            If hit collider is not null

            Reset currentJump
            */
        }

        void LimitVelocity()
        {

        }

        public void Jump()
        {
            /*
            If current is less than max jump
            Increment currentJump
            Add force to player (using Impulse)
            */
        }

        public void Move(float horizontal)
        {
            /*
            if horizontal > 0
            flip character


            if horizontal < 0
            flip character

            Add force to player in the right direction
            Limit Velocity
            */
        }

        public void Climb()
        {
            //CHALLENGE
        }
    }
}

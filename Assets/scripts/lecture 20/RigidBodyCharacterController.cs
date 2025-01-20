using UnityEngine;
namespace lecture20
{
    public class RigidBodyCharacterController : MonoBehaviour
    {
        public float moveSpeed = 5f;
        public float jumpForce = 5f;
        private Rigidbody rb;

        private Vector3 movementInput;
        private bool jumpInput;

        void Start()
        {

            rb = GetComponent<Rigidbody>();


            rb.mass = 1f;
            rb.drag = 0.5f;
            rb.angularDrag = 10f;
            rb.useGravity = true;
            rb.interpolation = RigidbodyInterpolation.Interpolate;
            rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
            rb.freezeRotation = true;
            rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        }

        void Update()
        {

            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");
            movementInput = new Vector3(moveX, 0f, moveZ);


            jumpInput = Input.GetKeyDown(KeyCode.Space);
        }

        void FixedUpdate()
        {

            if (movementInput.magnitude > 1f)
            {
                movementInput.Normalize();
            }

            Vector3 newVelocity = new Vector3(movementInput.x * moveSpeed, rb.velocity.y, movementInput.z * moveSpeed);
            rb.velocity = newVelocity;


            if (Mathf.Abs(rb.velocity.y) < 0.1f && jumpInput)
            {
                rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
            }
        }
    }


}
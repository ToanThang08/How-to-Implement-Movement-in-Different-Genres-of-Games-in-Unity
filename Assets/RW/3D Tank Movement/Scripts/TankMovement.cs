

using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float tankSpeed;
    public Rigidbody tankRigidBody;
    public float movementInput;
    public float turnInput;

    public float movementSpeed;
    public float turnSpeed;

    void Start()
    {
        tankRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        turnInput = Input.GetAxis("Horizontal");
        movementInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private CharacterController characterController;
    private new Rigidbody rigidbody;
    private float distanceToGround;

    public float speed;
    public float JumpSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        distanceToGround = GetComponent<Collider>().bounds.extents.y;
    }

    private void UpdateMovement()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        Vector3 velocity;

        if (hor != 0 || ver != 0)
        {
            velocity = (transform.forward * ver + transform.right * hor).normalized * speed;
        }
        else
        {
            velocity = Vector3.zero;
        }
        velocity.y = rigidbody.velocity.y;
        rigidbody.velocity = velocity;
    }

    private bool IsGrounded()
    {
        return Physics.BoxCast(transform.position, new Vector3(0.4f, 0f, 0.4f), Vector3.down, Quaternion.identity, distanceToGround + 0.1f);
    }

    private void UpdateJump()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rigidbody.AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);
            //transform.Rotate(new Vector3(30f, 0f, 0f) * Time.deltaTime, 0f, 0f);
        }
        while(IsGrounded())
            transform.Rotate(20f, 0f, 0f);
    }
    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
        UpdateJump();
    }
}

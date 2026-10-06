using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    InputAction jump;

    [SerializeField]
    public float jumpForce = 2f;
    public float jumpCooldown = 1.5f;
    public float gravForce;
    Rigidbody rb;
    [NonSerialized]
    private float jumpTimer;
    private bool isGrounded;
    void Start()
    {
        Physics.gravity = new Vector3(0, gravForce, 0);
        rb = GetComponent<Rigidbody>();
        isGrounded = true;
    }

    private void OnEnable()
    {

        
        jump.Enable();

    }

    private void FixedUpdate()
    {
        if (jump.IsPressed() && jumpTimer <= 0 && isGrounded)
        {
            jumpTimer = jumpCooldown;
            isGrounded = false;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        }

        if (jumpTimer > 0)
        {

            jumpTimer -= Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground")) {
            isGrounded = true;
        }
    }

}

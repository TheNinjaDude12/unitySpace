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
    Rigidbody rb;
    [NonSerialized]
    private float jumpTimer;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
       
        
        jump.Enable();
        
    }

    private void FixedUpdate()
    {
        if (jump.IsPressed() && jumpTimer <= 0)
        {
            jumpTimer = jumpCooldown;

            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
     
        }

        if (jumpTimer > 0)
        {
          
            jumpTimer -= Time.deltaTime;
        }
    }

    // Update is called once per frame
 
}

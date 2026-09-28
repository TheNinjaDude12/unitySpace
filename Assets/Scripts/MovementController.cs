using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] 
    private GameObject myObject;
    private Rigidbody rb;
    public InputActionReference moveAction;
    void OnEnable()
    {
        moveAction.action.Enable();
    }

    void OnDisable()
    {
        moveAction.action.Disable();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public float speed = 4f;
    public float jumpStrength = 1f;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 input = moveAction.action.ReadValue<Vector2>();
        Vector3 m_Input = new Vector3(input.x, 0, input.y);
        rb.MovePosition(transform.position + m_Input * Time.fixedDeltaTime * speed);
       
    }


}

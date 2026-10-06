using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public Stats stat;
    [NonSerialized]
 
   
    
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    TextMeshPro health;
    public float speed;
    private GameObject myObject;
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
        speed = stat.speed;
        
        rb = GetComponent<Rigidbody>();
      
       
    }
    


    // Update is called once per frame
    void FixedUpdate()
    {
       
        speed = stat.speed;
        Vector2 input = moveAction.action.ReadValue<Vector2>();
        Vector3 m_Input = new Vector3(input.x, 0, input.y) * speed;
        rb.linearVelocity = new Vector3(m_Input.x, rb.linearVelocity.y, m_Input.z);

    }


}

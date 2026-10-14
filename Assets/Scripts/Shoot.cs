using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    [SerializeField] GameObject bullet;
    [SerializeField] Transform shootPoint; 

    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        Mouse mouse = Mouse.current;
        if(mouse.leftButton.wasPressedThisFrame)
        {
            Instantiate(bullet, shootPoint.position + shootPoint.forward * 0.5f, shootPoint.rotation);
        }

    }
}

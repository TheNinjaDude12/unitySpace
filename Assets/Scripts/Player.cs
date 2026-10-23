using System.Collections;
using Unity.VisualScripting;
using UnityEngine;


public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    PlayerHealth playerHealth;
    [SerializeField] int damage;
    Rigidbody rb;
    CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();

        playerHealth.health = 10;
    }

    // Update is called once per frame
    void Update() { 
  
        if(playerHealth.health < 10)
        {
            StartCoroutine(restoreHealth());
           
            
        }
    }
    public void damagePlayer()
    {
        playerHealth.health -= damage;
    }
    IEnumerator restoreHealth()
    {
        controller.enabled = false;
        gameObject.transform.position = new Vector3(1.58f, 1.03f, -24.81f);
        yield return new WaitForSeconds(0.5f);
        playerHealth.health = 10;
        controller.enabled = true;
    }
}

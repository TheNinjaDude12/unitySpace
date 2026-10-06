using UnityEngine;
using System.Collections;
public class adjustStats : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public Stats stat;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.CompareTag("Player") &&  gameObject.CompareTag("Laser"))
        {
            stat.health -= 10;
           
        }

      if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("SpeedUp"))
        {
           
            stat.speed += 15;
           
            Debug.Log("Test");
            StartCoroutine(ExecuteSequence());
           
            Debug.Log(stat.health);
        }

      if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("HealthUp"))
        {

            stat.health += 10;
            Destroy(gameObject);
            
           
        }



    }

    IEnumerator ExecuteSequence()
    {
        Debug.Log("Speed up for 2 seconds");

        // Pause execution until the very next frame
      

        Debug.Log("One frame has passed.");

        // Pause execution for exactly 2.5 seconds
        yield return new WaitForSeconds(1.5f);
        stat.speed = 22;
        Destroy(gameObject);
        Debug.Log("2.5 seconds have passed. Sequence Finished!");
    }


}



using Unity.VisualScripting;
using UnityEngine;

public class Reset : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Vector3[] position = new Vector3[4];
    Vector3[] rotationY = new Vector3[4];
    int counter = 0;
    void Start()
    {
        Debug.Log("Test");
        foreach (Transform child in transform) {
            rotationY[counter] = child.up;
            position[counter] = child.position;
            counter++;
            
        }
        counter =0;
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach (Transform child in transform)
            {
                child.up = rotationY[counter];
                child.position = position[counter];

                counter++;

            }
            counter = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

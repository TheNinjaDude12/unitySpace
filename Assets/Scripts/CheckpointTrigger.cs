using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject obj;
    public Material highlightMaterial;
    public Material originalMaterial;

    [SerializeField]
    List<GameObject> allPlatforms = new();

    Vector3 pos;
   

    void Start()
    {
        
       
        pos = obj.transform.position;
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            obj.transform.Rotate(Vector3.up, 45);
        }
    }

    private void OnTriggerExit(Collider other)
    {
  
        obj.GetComponent<MeshRenderer>().material = originalMaterial;
    }

    private void OnTriggerStay(Collider other)
    {
        obj.GetComponent<MeshRenderer>().material = highlightMaterial;
    }
}

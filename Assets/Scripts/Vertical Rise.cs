using UnityEngine;

public class VerticalRise : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    GameObject obj;
    public GameObject down;
    public GameObject up;
    public Material highlightMaterial;
    public Material originalMaterial;
    bool playerInside;
    bool upPad;
    bool downPad;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(playerInside && upPad)
        {
            float step = 2.0f * Time.deltaTime; // calculate distance to move
            obj.transform.position = Vector3.MoveTowards(obj.transform.position, up.transform.position, step);
        }
        else if (playerInside && downPad) {
            float step = 2.0f * Time.deltaTime; // calculate distance to move
            obj.transform.position = Vector3.MoveTowards(obj.transform.position, down.transform.position, step);
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Up"))
        {
            upPad = true;
            playerInside = true;

        }
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Down"))
        {
            downPad = true;
            playerInside = true;

        }
    }

    private void OnTriggerStay(Collider other)
    {
        obj.GetComponent<MeshRenderer>().material = highlightMaterial;
    }

    private void OnTriggerExit(Collider other)
    {
        playerInside = false;
        downPad = false;
        upPad = false;
        obj.GetComponent<MeshRenderer>().material = originalMaterial;
    }
}

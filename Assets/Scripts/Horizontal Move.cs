using UnityEngine;

public class HorizontalMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    GameObject obj;
    public GameObject right;
    public GameObject left;
    public Material highlightMaterial;
    public Material originalMaterial;
    bool playerInside;
    bool leftPad;
    bool rightPad;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerInside && leftPad)
        {
            float step = 2.0f * Time.deltaTime; // calculate distance to move
            obj.transform.position = Vector3.MoveTowards(obj.transform.position, left.transform.position, step);
        }
        else if (playerInside && rightPad)
        {
            float step = 2.0f * Time.deltaTime; // calculate distance to move
            obj.transform.position = Vector3.MoveTowards(obj.transform.position, right.transform.position, step);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Right"))
        {
            rightPad = true;
            playerInside = true;

        }
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Left"))
        {
            leftPad = true;
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
        leftPad = false;
        rightPad = false;
        obj.GetComponent<MeshRenderer>().material = originalMaterial;
    }
}

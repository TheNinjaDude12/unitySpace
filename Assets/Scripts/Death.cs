using UnityEngine;

public class Death : MonoBehaviour
{
    
    [SerializeField] 
    GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [System.NonSerialized] public Vector3 spawn;
    void Start()
    {
        spawn = new Vector3(3, 1, -2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = spawn;
            Debug.Log("hello");
        }
    }
}

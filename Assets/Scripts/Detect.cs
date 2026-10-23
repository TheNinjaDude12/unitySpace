using UnityEngine;

public class Detect : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    int raySize;
    private bool detected;
    [SerializeField] private LayerMask playerMask;
    [SerializeField] PlayerHealth player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        detected = Physics.CheckSphere(transform.position, raySize, playerMask);
        if (detected)
        {
            Debug.Log("Test");
            player.health -= 10;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = detected ? Color.green : Color.white;
        Gizmos.DrawWireSphere(transform.position, raySize);
    }
}

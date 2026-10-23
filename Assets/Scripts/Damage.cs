using Unity.VisualScripting;
using UnityEngine;

public class Damage : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private bool detected;
    [SerializeField] public float raySize;
    [SerializeField] private LayerMask playerMask;
    [SerializeField] PlayerHealth player;
    public Vector3 boxCenter = Vector3.zero;
    public Vector3 boxHalfExtents = new Vector3(1f, 1f, 1f);
    public LayerMask layerMask;
    
    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 worldCenter = transform.TransformPoint(boxCenter);
        bool hasHit = Physics.CheckBox(worldCenter, boxHalfExtents, transform.rotation, playerMask);
        if(hasHit)
        {
            
            player.health -= 10;
            Debug.Log(player.health);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = detected ? Color.green : Color.white;
        Gizmos.DrawWireSphere(transform.position, raySize);
    }

}

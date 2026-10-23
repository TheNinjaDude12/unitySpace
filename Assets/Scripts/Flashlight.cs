using UnityEngine;
using static UnityEngine.UI.Image;

[RequireComponent(typeof(Light))]
public class Flashlight : MonoBehaviour
{
    [SerializeField] private LayerMask hiddenMask; // HiddenObject layer
    private Light spot;

    private void Start()
    {
        spot = GetComponent<Light>();
    }
    private void Update()
    {
        Vector3 origin = transform.position;
        
        Collider[] illum = Physics.OverlapSphere(transform.position, spot.range, hiddenMask);
        foreach (Collider collider in illum)
        {
            Vector3 toObj = collider.ClosestPoint(origin) - origin;
            if (Vector3.Angle(transform.forward, toObj) <= spot.spotAngle * 0.5f)
            {
                Hidden h = collider.GetComponent<Hidden>();
                h.setHidden();
               
                
            }
      

        }
    }
}
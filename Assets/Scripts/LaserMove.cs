using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    GameObject end;
    public float step;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        end = GameObject.FindWithTag("End");
    }

    // Update is called once per frame
    void Update()
    {

        

        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, end.transform.position.z), step * Time.deltaTime);
        
    }


}

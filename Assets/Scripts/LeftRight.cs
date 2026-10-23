using UnityEngine;

public class LeftRight : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] Transform left;
    [SerializeField] Transform right;
    [SerializeField] int speed;
    int leftT = 0;
    void Start()
    {
        leftT = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (leftT == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, left.position, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, right.position, speed * Time.deltaTime);
        }

        if (transform.position == left.position)
        {
            leftT = 0;
            Debug.Log("Hello");
        }

        if (transform.position == right.position)
        {
            leftT = 1;
            Debug.Log("Hello");
        }

    }
}

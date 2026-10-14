using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    int speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.linearVelocity = transform.forward * speed;
        StartCoroutine(DestroyBullet());

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player") && !collision.gameObject.CompareTag("Box"))
            Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(2f);
        Destroy(this.gameObject);
    }
}
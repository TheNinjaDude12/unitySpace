using UnityEngine;

public class End : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    public AudioSource source;
    public AudioClip clip;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            source.PlayOneShot(clip);

        }


    }
}

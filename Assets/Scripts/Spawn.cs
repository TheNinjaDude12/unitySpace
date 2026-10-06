using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;
public class Spawn : MonoBehaviour
{
    [SerializeField]
    public TMP_Text label;
    [SerializeField]
    public AudioSource source;
    [SerializeField]
    public AudioClip clip;
    [SerializeField]
    Stats stat;
    [SerializeField]
    private List<GameObject> laserKind = new List<GameObject>();
    [SerializeField]
    public float spawnCooldown;
    [NonSerialized]
    public float spawnTimer;
    bool end;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        end = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!end)
        {
            if (spawnTimer <= 0)
            {
                int number = Random.Range(0, laserKind.Count);
               
                if (number == 0)
                {
                    Instantiate(laserKind[number], new Vector3(93.51f, 2.18f, gameObject.transform.position.z), laserKind[number].transform.rotation);
                }
                if (number == 1)
                {
                    Instantiate(laserKind[number], new Vector3(87.54f, 9.16f, gameObject.transform.position.z), laserKind[number].transform.rotation);
                }
                if (number == 2)
                {
                    Instantiate(laserKind[number], new Vector3(93.38405f, 6.64f, gameObject.transform.position.z), laserKind[number].transform.rotation);
                }
                if (number == 3)
                {
                    Instantiate(laserKind[number], new Vector3(79.08f, 8.35f, gameObject.transform.position.z), laserKind[number].transform.rotation);
                }

                spawnTimer = spawnCooldown;
            }
            else
            {
                spawnTimer -= Time.deltaTime;
            }
        }
 
       
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            end = true;
            stat.speed = 0;
            source.PlayOneShot(clip);
            label.text = "You win!";
        }
    }   

}





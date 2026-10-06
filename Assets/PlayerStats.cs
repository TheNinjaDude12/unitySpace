using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public Stats stat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stat.health = 50;
        stat.speed = 22;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class adjustHP : MonoBehaviour
{
    [SerializeField]
    public TMP_Text label;
    [SerializeField]
    Stats stat;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        label.text = "100";
    }

    // Update is called once per frame
    void Update()
    {   
        label.text = stat.health.ToString();
        if(stat.health <= 0 )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

using System.Collections;
using UnityEngine;
using System;
using Unity.VisualScripting;
public class Hidden : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private bool isHidden = true;
    MeshRenderer material;
    [SerializeField] Material hideMaterial;
    [SerializeField] Material showMaterial;
    public float lastlittime;
    [SerializeField] float hideDelay;
    void Start()
    {
        material = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isHidden)
        {
          material.material = showMaterial;
        }
        if (!isHidden && Time.time - lastlittime > hideDelay)
        {
            material.material = hideMaterial;
        }
    }
    public void setHidden()
    {

        lastlittime = Time.time;
        isHidden = false;
        
    }


}

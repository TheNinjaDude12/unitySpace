using UnityEngine;

public class renderTexture : MonoBehaviour
{
    [SerializeField]
    public Material newMaterial;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Renderer[] childRenderers = GetComponentsInChildren<Renderer>();

        foreach (Renderer rend in childRenderers)
        {
            // Use .sharedMaterial to avoid creating duplicated material instances in memory
            rend.sharedMaterial = newMaterial;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

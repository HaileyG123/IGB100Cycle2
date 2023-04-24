using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    public Renderer cubeRenderer;
    public GameObject cube;
    public Color newColor;
    private int colorValue;
    
    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeMaterial() 
    {
        cubeRenderer.material.color = newColor;
    }
}

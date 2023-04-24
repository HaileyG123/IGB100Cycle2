using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    
    public string InteractionPrompt => _prompt;
    public bool Interact(Interactor interactor)
    {
        Debug.Log("Button Pressed!");
        ChangeMaterial();
        return true;
    }

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
        Debug.Log("Change button");
        cubeRenderer.material.color = newColor;
    }
}

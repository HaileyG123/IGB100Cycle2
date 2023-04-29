using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    
    public string InteractionPrompt => _prompt;
    private Animation buttonSet;
    private AudioSource audio;
    public bool Interact(Interactor interactor)
    {
        Debug.Log("Button Pressed!");
        buttonSet.Play("press_once");
        audio.Play(0);
        ChangeMaterial();
        return true;
    }

    public Renderer cubeRenderer;
    public GameObject cube;
    public Color newColor;
    public Color oldColour;
    public bool changed;
    private int colorValue;
    
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        buttonSet = GetComponent<Animation>();
        cubeRenderer = cube.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeMaterial() 
    {
        //Debug.Log("Change button");
        if(!changed)
        {
            cubeRenderer.materials[1].color = newColor;
            changed = true;
        }
        else
        {
            cubeRenderer.materials[1].color = oldColour;
            changed = false;
        }
        
    }
}

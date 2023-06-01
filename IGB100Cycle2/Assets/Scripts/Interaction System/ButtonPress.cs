using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;    
    
    public string InteractionPrompt => _prompt;
    private Animation buttonSet;
    //public GameObject number;
   // private Animator numberAnimation;
    
    private AudioSource audio;
    public bool Interact(Interactor interactor)
    {
        Debug.Log("Button Pressed!");
        buttonSet.Play("PressHold");
        audio.Play(0);
        //numberAnimation.SetTrigger("New Trigger");
        buttonSet.Play("PressRelease");
        ChangeMaterial();
        if(inPattern && gameManager != null) 
        {
            gameManager.GetComponent<OpenDoorR5>().index += 1;
        }
        else if(!inPattern && gameManager != null)
        {
            gameManager.GetComponent<OpenDoorR5>().index = 0;
            gameManager.GetComponent<OpenDoorR5>().Reset();
        }

        return true;
    }

    public Renderer cubeRenderer;
    public GameObject cube;
    public Color newColor;
    public Color oldColour;
    public bool changed;
    private int colorValue;

    public bool inPattern;
    public bool room5;
    public GameObject gameManager;
    public bool pat2;
    
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        buttonSet = GetComponent<Animation>();
        cubeRenderer = cube.GetComponent<Renderer>();
        //numberAnimation = number.GetComponent<Animator>();
        
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

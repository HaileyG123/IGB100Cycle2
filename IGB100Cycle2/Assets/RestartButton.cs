using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour, IInteractable
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
        RestartLevel();
        return true;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        buttonSet = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartLevel() 
    {
        SceneManager.LoadScene("Hailey Programmer");         
    }
}

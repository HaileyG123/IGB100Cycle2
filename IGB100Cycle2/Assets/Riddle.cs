using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riddle : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    public GameObject riddle;
    
    public string InteractionPrompt => _prompt;
    public bool Interact(Interactor interactor)
    {
        Debug.Log("Riddle displayed");
        DisplayRiddle();
        return true;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisplayRiddle()
    {
        riddle.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}

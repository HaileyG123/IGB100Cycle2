using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHint : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;

    public GameObject hint;
    public GameObject crosshair;
    
    public string InteractionPrompt => _prompt;
    public bool Interact(Interactor interactor)
    {
        Debug.Log("Hint Given!");
        GiveHint();
        return true;
    }

    // Start is called before the first frame update
    void Start()
    {
        //hint.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GiveHint()
    {
        hint.SetActive(true);
        crosshair.SetActive(false);
        //Cursor.visible = true;
        //Cursor.lockState = CursorLockMode.None;
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour, IInteractable
{

    public string nextScene;

    [SerializeField] private string _prompt;
    
    public string InteractionPrompt => _prompt;
    public bool Interact(Interactor interactor)
    {
        Debug.Log("Next Room");
        LoadNextRoom();
        return true;
    }

    void LoadNextRoom()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(nextScene);
    }
}

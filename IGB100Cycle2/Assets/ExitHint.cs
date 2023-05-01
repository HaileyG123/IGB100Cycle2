using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitHint : MonoBehaviour
{
    public GameObject hint;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //LeaveUI();
    }

    public void LeaveUI()
    {
        Debug.Log("click");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        hint.SetActive(false);
    }
}

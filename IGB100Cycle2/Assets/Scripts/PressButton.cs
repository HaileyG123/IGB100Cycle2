using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButton : MonoBehaviour
{
    private bool buttonPressed = false;
    public GameObject door;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(UnityEngine.Collision other)
    {
        if (other.gameObject.tag == "Button" && buttonPressed == false)
        {
            buttonPressed = true;
            Destroy(door);
            //Debug.Log("Button Pressed");
        }
    }
}

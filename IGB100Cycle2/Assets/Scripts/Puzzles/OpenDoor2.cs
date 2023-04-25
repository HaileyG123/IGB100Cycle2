using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor2 : MonoBehaviour
{
    public GameObject door;
    public GameObject button1;
    public GameObject button2;

    public bool puzzleSolved;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(button1.GetComponent<ButtonPress>().changed && button2.GetComponent<ButtonPress>().changed && !puzzleSolved)
        {
            puzzleSolved = true;
            Destroy(door);
            Debug.Log("Door opens");
        }
    }
}

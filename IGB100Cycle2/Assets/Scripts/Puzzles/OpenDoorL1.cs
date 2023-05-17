using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoorL1 : MonoBehaviour
{
    public GameObject door;
    public GameObject button1;
    public GameObject button2;
    public GameObject doorOpen;

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
            StartCoroutine(DoorOpen());
        }
    }

    private IEnumerator DoorOpen()
    {
        doorOpen.SetActive(true);
        yield return new WaitForSeconds(3);
        doorOpen.SetActive(false);
    }
}

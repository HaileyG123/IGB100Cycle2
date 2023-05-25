using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoorR4 : MonoBehaviour
{
    public GameObject door;
    public GameObject button1;
    public GameObject doorOpen;
    public GameObject timer;

    public GameObject timerTrigger;

    public bool puzzleSolved;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(button1.GetComponent<ButtonPress>().changed && !puzzleSolved)
        {
            puzzleSolved = true;
            Destroy(timerTrigger);
            Destroy(door);
            StartCoroutine(DoorOpen());
            Destroy(timer);
        }
    }

    private IEnumerator DoorOpen()
    {
        doorOpen.SetActive(true);
        yield return new WaitForSeconds(3);
        doorOpen.SetActive(false);
    }
}

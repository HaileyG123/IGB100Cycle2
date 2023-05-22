using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoorL2 : MonoBehaviour
{
    public GameObject door;
    public GameObject buttonA;
    public GameObject buttonB;
    public GameObject buttonC;
    public GameObject buttonD;
    public GameObject doorOpen;

    public List<GameObject> buttons = new List<GameObject>();

    public GameObject room;
    public GameObject wrongButton;

    

    public bool puzzleSolved;
    
    // Start is called before the first frame update
    void Start()
    {
        buttons.Add(buttonA);
        buttons.Add(buttonB);
        buttons.Add(buttonC);
        buttons.Add(buttonD);
    }

    // Update is called once per frame
    void Update()
    {
        if(buttonB.GetComponent<ButtonPress>().changed && !puzzleSolved)
        {
            puzzleSolved = true;
            Destroy(door);
            StartCoroutine(DoorOpen());
        }
        else if (buttonC.GetComponent<ButtonPress>().changed || buttonA.GetComponent<ButtonPress>().changed 
        || buttonD.GetComponent<ButtonPress>().changed)
        {
            Fall();
            StartCoroutine(WrongButton());
        }
    }

    private IEnumerator DoorOpen()
    {
        doorOpen.SetActive(true);
        yield return new WaitForSeconds(3);
        doorOpen.SetActive(false);
    }

    private IEnumerator WrongButton()
    {
        wrongButton.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        wrongButton.SetActive(false);
    }

    private void Fall()
    {
        //Debug.Log("Player falling");
        room.GetComponent<Collider>().enabled = false;   
        for(int i = 0; i < buttons.Count; i++)
        {
            if(buttons[i].GetComponent<ButtonPress>().changed)
            {
                buttons[i].GetComponent<ButtonPress>().ChangeMaterial();
            }
        }     
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorR6 : MonoBehaviour
{
    public GameObject door;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button9;
    public GameObject button10;
    public GameObject button8;
    public GameObject button7;
    public GameObject button11;
    //public GameObject button12;

    private List<GameObject> wrongButtons = new List<GameObject>();

    public GameObject doorOpen;
    public GameObject wrongButton;

    public bool puzzleSolved;
    public bool room5Solved;
    
    // Start is called before the first frame update
    void Start()
    {
        wrongButtons.Add(button3);
        wrongButtons.Add(button4);
        wrongButtons.Add(button5);
        wrongButtons.Add(button6);
        wrongButtons.Add(button7);
        wrongButtons.Add(button8);
        wrongButtons.Add(button9);
        wrongButtons.Add(button10);
        wrongButtons.Add(button11);
        //wrongButtons.Add(button12);
    }

    // Update is called once per frame
    void Update()
    {
        if(button1.GetComponent<ButtonPress>().changed && button2.GetComponent<ButtonPress>().changed && !puzzleSolved
        && room5Solved)
        {
            puzzleSolved = true;
            Destroy(door);
            StartCoroutine(DoorOpen());
        }
        foreach(GameObject button in wrongButtons)
        {
            if(button.GetComponent<ButtonPress>().changed && !puzzleSolved && room5Solved)
            {
                Reset();
            }
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
        yield return new WaitForSeconds(3);
        wrongButton.SetActive(false);
    }

    public void Reset()
    {
        if(!puzzleSolved)
        {
            StartCoroutine(WrongButton());
            if(button1.GetComponent<ButtonPress>().changed)
            {
                button1.GetComponent<ButtonPress>().ChangeMaterial();                    
            }

            if(button2.GetComponent<ButtonPress>().changed)
            {
                button2.GetComponent<ButtonPress>().ChangeMaterial();                    
            }
            foreach(GameObject button in wrongButtons)
            {                
                if(button.GetComponent<ButtonPress>().changed)
                {
                    button.GetComponent<ButtonPress>().ChangeMaterial();                    
                }
            }
        }
    }
}

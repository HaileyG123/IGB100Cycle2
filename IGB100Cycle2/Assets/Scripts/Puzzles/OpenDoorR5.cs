using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorR5 : MonoBehaviour
{
    public GameObject door;
    public GameObject button7;
    public GameObject button5;
    public GameObject button3;
    public GameObject button1;
    private List<GameObject> buttons = new List<GameObject>();

    public GameObject button4;
    public GameObject button2;
    private List<GameObject> wrongButtons = new List<GameObject>();

    public GameObject doorOpen;
    public GameObject wrongButton;

    public GameObject gameManager;

    public bool puzzleSolved;

    public int index = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        buttons.Add(button7);
        buttons.Add(button5);
        buttons.Add(button3);
        buttons.Add(button1);

        wrongButtons.Add(button4);
        wrongButtons.Add(button2);

        Debug.Log(index);
    }

    // Update is called once per frame
    void Update()
    {
        if(index == 4 && !puzzleSolved)
        {
            puzzleSolved = true;            
            Destroy(door);
            StartCoroutine(DoorOpen());
            StartCoroutine(Reset2());
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
            foreach(GameObject button in buttons)
            {                
                if(button.GetComponent<ButtonPress>().changed)
                {
                    button.GetComponent<ButtonPress>().ChangeMaterial();                    
                }
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

    private IEnumerator Reset2()
    {
        yield return new WaitForSeconds(3);
        gameManager.GetComponent<OpenDoorR6>().room5Solved = true;
        foreach(GameObject button in buttons)
            {                
                if(button.GetComponent<ButtonPress>().changed)
                {
                    button.GetComponent<ButtonPress>().ChangeMaterial();                    
                }
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

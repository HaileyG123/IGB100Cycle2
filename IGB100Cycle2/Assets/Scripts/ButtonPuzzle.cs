using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPuzzle : MonoBehaviour
{
    public GameObject door;
    
    public GameObject button7;
    public GameObject button5;
    public GameObject button3;
    public GameObject button1;

    private List<GameObject> buttons = new List<GameObject>();

    private int index = 0;

    private bool puzzleSolved = false;
    
    // Start is called before the first frame update
    void Start()
    {
        buttons.Add(button7);
        buttons.Add(button5);
        buttons.Add(button3);
        buttons.Add(button1);

        Debug.Log(index);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(UnityEngine.Collision other)
    {
        if (other.gameObject.tag == "Button")
        {
            if(other.gameObject == buttons[index] && puzzleSolved == false)
            {
                index = index + 1;
                Debug.Log(index);
                if(index == 4)
                {
                    Destroy(door);
                    Debug.Log("door gone");
                    puzzleSolved = true;
                    index = 0;
                }
            }
            else if (other.gameObject != buttons[index] && puzzleSolved == false)
            {
                Debug.Log(index);
                index = 0;
            }
        }
        
    }
}

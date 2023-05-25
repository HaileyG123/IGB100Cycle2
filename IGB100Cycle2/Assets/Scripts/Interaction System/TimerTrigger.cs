using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerTrigger : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;
    public bool puzzleSolved = false;

    public Text TimerText;
    // Start is called before the first frame update
    void Start()
    {
        TimerText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(TimerOn)
        {
            if(TimeLeft > 0 && !puzzleSolved)
            {
                TimeLeft -= Time.deltaTime;
                UpdateTimer(TimeLeft);
            }
            else 
            {
                Debug.Log("Time is up!");
                TimeLeft = 0;
                TimerOn = false;
                SceneManager.LoadScene("LoseRoom4");
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Timer Start");            
            TimerOn = true;
        }
    }

    void UpdateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}

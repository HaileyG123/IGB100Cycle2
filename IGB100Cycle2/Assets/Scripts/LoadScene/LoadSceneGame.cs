using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadSceneGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

     // Update is called once per frame
    void Update()
    {
    }


    public void Play()
    {
        SceneManager.LoadScene("Level_1");        
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Instructions()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void GoHome()
    {
        SceneManager.LoadScene("Title");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Lose()
    {
        SceneManager.LoadScene("Lose");
    }

    public void Win()
    {
        SceneManager.LoadScene("Win");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level_2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level_3");
    }
}

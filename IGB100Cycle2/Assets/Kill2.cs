using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill2 : MonoBehaviour
{
    public string scene;

    public GameObject killUI;
    public bool GameIsPaused;
    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Level reset");   
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            killUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;         
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}

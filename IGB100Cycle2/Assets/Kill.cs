using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{
    public string scene;
    public GameObject myTimer;

    private Transform playPos;
    public GameObject playerEmpty;
    public GameObject player;

    public GameObject room;
    // Start is called before the first frame update
    void Start()
    {
        playPos = playerEmpty.GetComponent<Transform>();
    }

    void Awake() 
    {
        DontDestroyOnLoad(myTimer);
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
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            room.GetComponent<Collider>().enabled = true;
            player.transform.position = new Vector3(-55f,20f,-20f);
        }
    }
}

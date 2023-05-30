using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public GameObject main;
    public GameObject tutorial;
    public GameObject controls;
    private GameObject currentScreen;
    // Start is called before the first frame update
    void Start()
    {
        currentScreen = main;
    }

    // Update is called once per frame
    public void mainToggle()
    {
        main.SetActive(true);
        currentScreen.SetActive(false);
        currentScreen = main;
    }

    public void tutorialToggle()
    {
        tutorial.SetActive(true);
        currentScreen.SetActive(false);
        currentScreen = tutorial;
    }
    public void controlsToggle()
    {
        controls.SetActive(true);
        currentScreen.SetActive(false);
        currentScreen = controls;
    }
}

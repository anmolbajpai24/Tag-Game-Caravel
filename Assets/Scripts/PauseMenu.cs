using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject settingsMenu;
    public bool isPaused;
    public GameObject pauseButton;
    public GameObject settingsButton;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {


    }       
    

    public void PauseGame()
    {
        pauseButton.SetActive(false);
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseButton.SetActive(true);
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void OpenSettings()
    {
        settingsButton.SetActive(false);
        settingsMenu.SetActive(true);
    }
}

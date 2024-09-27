using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused = true;
    public GameObject thePauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        PauseGame();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        Debug.Log("PauseManager::Paused");
        isPaused = true;
        thePauseMenu.gameObject.SetActive(true);
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
        Debug.Log("PauseManager::Unpaused");
        isPaused = false;
        thePauseMenu.gameObject.SetActive(false);
    }
}

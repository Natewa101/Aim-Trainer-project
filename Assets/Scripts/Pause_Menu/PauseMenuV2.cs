using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuV2 : MonoBehaviour
{
    // making variables changable in unity software
    [SerializeField] private GameObject pauseMenuUI;

    [SerializeField] private bool isPaused;

    void Update()
    {
        // if escape is pressed change isPaused to the opposite of what it is
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            isPaused = !isPaused;
        }
        // if isPaused is true then run ActivateMenu()
        if (isPaused)
        {
            Time.timeScale = 0;
            ActivateMenu();
        }
        // if isPaused is false then run DeactivateMenu()
        else
        {
            Time.timeScale = 1;
            DeactivateMenu();
        }
    }

    void ActivateMenu()
    {
        pauseMenuUI.SetActive(true); // makes the pause menu appear
    }

    void DeactivateMenu()
    {
        pauseMenuUI.SetActive(false); // makes the pause menu go away
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
   
    public GameObject menu;
    public TextMeshProUGUI testingText;
    public KeyCode testingKey;
    private bool isPaused = false;

    private void Start()
    {
        Time.timeScale = 1f;
        menu.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            testingText.text = "Down";
        }
        else if (Input.GetKey(KeyCode.Escape))
        {
            testingText.text = "Hold";
        }
        else if (Input.GetKeyUp(KeyCode.Escape))
        {
            testingText.text = "Release";
        }
        else
        {
            //Debug.Log("N/A");
        }

        if (Input.GetButtonDown("Cancel"))
        {
            TogglePauseGame();
        }
    }
    public void endGame()
    {
        Debug.Log("Player has left!");
        Application.Quit();
    }

    public void loadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void TogglePauseGame()
    {
        isPaused = !isPaused;
        menu.SetActive(isPaused);

        if (isPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }

    }

}

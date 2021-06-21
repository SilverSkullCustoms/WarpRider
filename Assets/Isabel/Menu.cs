using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject gameOverScreen;
    public GameObject pauseScreen;

    public static bool GameIsPaused = false;
    public GameObject pauseMenu;
    public bool alive;
    /// start
    public GameObject startA;
    public GameObject quitA;
    /// GameOver
    public GameObject retryA;
    public GameObject backA;
    /// Pause
    public GameObject continueA;
    public GameObject retryB;
    public GameObject returnA;

    // Start is called before the first frame update
    void Start()
    {
        alive = true;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();

            }
            else
            {
                Pause();
            }
        }

    }
    void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void StartGame()
    {
        alive = true;
        startScreen.SetActive(false);
        gameOverScreen.SetActive(false);
    }

    ///Buttons
    public void DisablePanels()
    {
        startA.SetActive(false);
        quitA.SetActive(false);
        retryA.SetActive(false);
        backA.SetActive(false);
        continueA.SetActive(false);
        retryB.SetActive(false);
        returnA.SetActive(false);
    }

    public void OnStart()
    {
        DisablePanels();
        startA.SetActive(true);
    }

    public void Quit()
    {
        DisablePanels();
        quitA.SetActive(true);
    }

    public void Retry()
    {
        DisablePanels();
        retryA.SetActive(true);
    }

    public void back()
    {
        DisablePanels();
        backA.SetActive(true);
    }

    public void Continue()
    {
        DisablePanels();
        continueA.SetActive(true);
    }

    public void RetryQ()
    {
        DisablePanels();
        retryB.SetActive(true);
    }

    public void Return()
    {
        DisablePanels();
        returnA.SetActive(true);
    }
}

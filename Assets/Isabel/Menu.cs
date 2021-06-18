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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (input.GetKeyDown(KeyCode.Escape))
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


        if (alive == true)
        {

            else
            {
                gameOverScreen();
            }
        }
    }
    void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timescale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenu.SetActive(true);
        Time..timescale = of;
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
}

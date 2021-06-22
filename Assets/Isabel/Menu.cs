using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject gameOverScreen;
    public bool alive;
    /// start
    public GameObject startA;
    public GameObject quitA;
    /// GameOver
    public GameObject retryG;
    public GameObject backA;

    // Start is called before the first frame update
    void Start()
    {
        alive = true;


    }

    // Update is called once per frame
    void Update()
    {

    }

    void QuitGame()
    {
        Application.Quit();
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
        retryG.SetActive(false);
        backA.SetActive(false);
    }

    public void OnStart()
    {
        DisablePanels();
        startA.SetActive(true);
        SceneManager.LoadScene(sceneName: "Game");
    }

    public void Quit()
    {
        DisablePanels();
        quitA.SetActive(true);
    }

    /// GameOver
    public void RetryGameOver()
    {
        DisablePanels();
        retryG.SetActive(true);
        SceneManager.LoadScene(sceneName: "Game");
    }

    public void Back()
    {
        DisablePanels();
        startScreen.SetActive(true);
    }


}

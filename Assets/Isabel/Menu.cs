using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(sceneName: "MainMenu");
    }

    public void OnStart()
    {
        SceneManager.LoadScene(sceneName: "Game");
    }

    public void RetryGameOver()
    {
        SceneManager.LoadScene(sceneName: "Game");
    }

}

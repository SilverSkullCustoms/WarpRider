using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    public ParticleSystem deathExplosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ExplosionPlayer()
    {
        deathExplosion.Play();

    }
    void GameOverScreen()
    {
        SceneManager.LoadScene(sceneName: "GameOver");
    }
}

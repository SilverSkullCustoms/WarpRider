using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControllerBay : MonoBehaviour
{
    public Animator anim;
    public GameObject launchBay;
    public bool gameStarted;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            anim.Play("BayWall");
            gameStarted = true;
        }
    }

    void DestroyLaunchBay()
    {
        if(gameStarted == true)
        {
            launchBay.SetActive(false);
        }
    }

}

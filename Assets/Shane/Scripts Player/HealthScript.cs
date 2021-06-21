using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public GameObject ship;
    public GameObject fracturedShip;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "enemy")
        {
            fracturedShip.SetActive(true);
            ship.SetActive(false);
        } 
    }

    void ExplosionPlayer()
    {

    }
}

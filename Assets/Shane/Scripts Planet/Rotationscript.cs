using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotationscript : MonoBehaviour
{
 
    public Vector3 rot;
    public Transform rotcap;
    public float rotspeed;

    // Start is called before the first frame update
    void Start()
    {
        rotspeed = -0.015f;
       

    }
    void Update()
    {
        rotcap.Rotate(rot);
        rot = new Vector3(0, 0, rotspeed);
    }

    
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotationscript : MonoBehaviour
{
 
    public Vector3 rot;
    public Transform rotcap;

    // Start is called before the first frame update
    void Start()
    {


    }
    void Update()
    {
        rotcap.Rotate(rot);
    }

    
}


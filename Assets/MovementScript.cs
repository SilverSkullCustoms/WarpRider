using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    Vector3 ToMoveWith;
    public float Speed;
   
    

    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-Input.GetAxis("Horizontal"), 0, 0) * Speed);

        float minX = -2.325f;
        float maxX = 2.325f;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y, transform.position.z);




    }
}
    

   
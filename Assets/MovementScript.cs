using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 move;
    public float speed;
    public float h;
    public float v;
    

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");



        move.x = -h;

        transform.Translate(move * speed);

    }
}


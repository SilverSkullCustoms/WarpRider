using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    public float horizontal;

    public Transform[] arrayMove;

    public Transform nextPos;

    public int index;

    // Start is called before the first frame update
    void Start()
    {
        index = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Horizontal"))
        {
            horizontal = Input.GetAxis("Horizontal");

            if (horizontal > 0)
            {
                index++;
            }
        
            if(horizontal < 0)
            {
                index--;
            }

            if(index > 4)
            {
                index = 4;
            }

            if(index < 0)
            {
                index = 0;
            }

            transform.position = arrayMove[index].position;

        }
    }
}

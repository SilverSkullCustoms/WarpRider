using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public int[] arrayMove;
    //Array aanmaken met 01234 met daarin Vector3, zodat hij die punten kan pakken, voorloop weghalen

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3();

        move.x = -h;

        transform.Translate(move * moveSpeed * Time.deltaTime);


        void OnTriggerEnter()
        {
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingMain : MonoBehaviour
{
    private RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 10000))
            {
                //Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.green);
                print(hit.transform.gameObject.name);
                Destroy(hit.transform.gameObject);
            }
        }
    }
}

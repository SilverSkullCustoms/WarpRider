using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDelete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waiter(3);
        Destroy(gameObject);
    }

    IEnumerator waiter(int i)
    {
        yield return new WaitForSeconds(i);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingMain : MonoBehaviour
{
    private RaycastHit hit;
    public ParticleSystem charge;
    public ParticleSystem sparks;
    public ParticleSystem beam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            charge.gameObject.SetActive(true);
            charge.Play();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            charge.Stop();

            charge.gameObject.SetActive(false);
            sparks.gameObject.SetActive(true);
            beam.gameObject.SetActive(true);

            sparks.Play();
            beam.Play();
            //Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.green);
            if (Physics.Raycast(transform.position, transform.forward, out hit, 10000))
            {
                GameObject explosionParticle = hit.transform.parent.gameObject;
                explosionParticle.SetActive(true);
                explosionParticle.GetComponent<ParticleSystem>().Play();
                print(hit.transform.gameObject.name);
                Destroy(hit.transform.gameObject);
            }
        }
    }
}

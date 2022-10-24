using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("ouch");
        healthColour possibleVictim = collision.transform.GetComponent<healthColour>();
        // if the above statement isn't null, go ahead and do this next bit
        if (possibleVictim)
        {
            possibleVictim.takeDamage(1);
        }
    }

}

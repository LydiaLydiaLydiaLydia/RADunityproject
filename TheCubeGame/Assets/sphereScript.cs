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
        //use W to move the cube forward
        if (Input.GetKey(KeyCode.W))
        {
            //remember, distance = velocity*time
            transform.position += transform.forward * Time.deltaTime;
        }

        //use S to move the cube backwards
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime;
        }

        //use D to rotate clockwise
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, 1);

        //use A to rotate anti-clockwise
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -1);
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("couch");

        
        healthColour possibleVictim = collision.transform.GetComponent<healthColour>();
        // if the above statement isn't null, go ahead and do this next bit
        if (possibleVictim)
        {
            possibleVictim.takeDamage(1);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        //W key makes Lydia go forward
        if (Input.GetKey(KeyCode.W))
        transform.position += transform.forward*  Time.deltaTime;

        //S key makes Lydia go backward
        if (Input.GetKey(KeyCode.S))
            transform.position -= transform.forward* Time.deltaTime;

        //A key makes Lydia go left
        if (Input.GetKey(KeyCode.A))
            transform.position -= transform.right* Time.deltaTime;

        //D key makes Lydia go right
        if (Input.GetKey(KeyCode.D))
            transform.position += transform.right* Time.deltaTime;

        //E Key lets you turn clockwise as you hold it down
        if (Input.GetKey(KeyCode.E))
            transform.Rotate(Vector3.up, 1);

        //Q Key lets you turn anti-clockwise as you hold it down
        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(Vector3.up, -1);

        // if (Input.GetKey(KeyCode.J))
        // { 
        //   transform.Rotate(Vector3.up, turningSpeed* Time.deltaTime)

        // }

        
        



    }
}

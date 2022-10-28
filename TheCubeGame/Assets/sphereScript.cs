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
        //use W to move the ball forwards
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * 4 * Time.deltaTime;
        }

        //use S to move the ball backwards
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * 4 * Time.deltaTime;
        }

        //use D to move the ball left
        if (Input.GetKey(KeyCode.D))
            transform.position += transform.right * 4 * Time.deltaTime;

        //use A to move the ball right
        if (Input.GetKey(KeyCode.A))
            transform.position -= transform.right * 4 * Time.deltaTime;
    }

}

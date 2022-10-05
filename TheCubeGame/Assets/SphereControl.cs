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
        //Up arrow goes forward
        if (Input.GetKey(KeyCode.UpArrow))
        transform.position += transform.forward*  Time.deltaTime;

        //Down arrow goes backwards
        if (Input.GetKey(KeyCode.DownArrow))
            transform.position -= transform.forward* Time.deltaTime;

        //Left arrow goes left
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position -= transform.right* Time.deltaTime;

        //Right arrow goes right
        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += transform.right* Time.deltaTime;

        //D Key lets you turn clockwise as you hold it down
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, 1);

        //A Key lets you turn anti-clockwise as you hold it down
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -1);

        // if (Input.GetKey(KeyCode.J))
        // { 
        //   transform.Rotate(Vector3.up, turningSpeed* Time.deltaTime)

        // }

        //Trying to get Lydia to jump
        if (Input.GetKey(KeyCode.Space))
            for (int i = 0; i < 10; i++)
            {
                transform.position += transform.up* Time.deltaTime;
            }
            



    }
}

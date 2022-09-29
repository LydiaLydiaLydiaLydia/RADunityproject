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
        if (Input.GetKey(KeyCode.UpArrow))
        transform.position += transform.forward*  Time.deltaTime;

        if (Input.GetKey(KeyCode.DownArrow))
            transform.position -= transform.forward* Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position -= transform.right* Time.deltaTime;

        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += transform.right* Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, 1);

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -1);

        // if (Input.GetKey(KeyCode.J))
        // { 
        //   transform.Rotate(Vector3.up, turningSpeed* Time.deltaTime)

        // }



    }
}

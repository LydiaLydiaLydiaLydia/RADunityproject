using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LydiasCubeControl : MonoBehaviour
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
            transform.position += Vector3.forward * Time.deltaTime;
        }

        //use S to move the cube backwards
        if (Input.GetKey(KeyCode.W))
        {
            transform.position -= Vector3.forward * Time.deltaTime;
        }

        //use W to move the cube forward
        if (Input.GetKey(KeyCode.W))
        {
            //remember, distance = velocity*time
            transform.position += Vector3.up * Time.deltaTime;
        }

        //use W to move the cube forward
        if (Input.GetKey(KeyCode.W))
        {
            //remember, distance = velocity*time
            transform.position += Vector3.up * Time.deltaTime;
        }
    }
}

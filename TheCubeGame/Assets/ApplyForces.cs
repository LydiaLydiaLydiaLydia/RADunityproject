using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForces : MonoBehaviour
{
    //THIS SCRIPT LETS THE BALL DOUBLE JUMP WHEN YOU PRESS SPACE BAR

    Rigidbody ourRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ourRigidBody.AddForce(Vector3.up * 300);
        }
    }

  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LydiaApplyForce : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody lydiasRigidBody;

    void Start()
    {
        lydiasRigidBody = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            lydiasRigidBody.AddForce(10*Vector3.up);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            lydiasRigidBody.AddExplosionForce(1000, transform.position - new Vector3(0, -1, -1), 3);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForces : MonoBehaviour
{
    //caching that rigid body
    Rigidbody ourRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ourRigidBody.AddExplosionForce(10000, transform.position, 2);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ourRigidBody.AddForce(Vector3.up * 300);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        PlaneScript objectHitHealth = collision.gameObject.GetComponent<PlaneScript>();

        //if this exists, basically
        if (objectHitHealth)
        {
            print("Found Health Script in object hit");
            objectHitHealth.takeDamage(1);

            //we're making a new integer
            //and a new method? 
            //he wants to shoot a building
            int ObjectsMaxHealth = objectHitHealth.whatsYourMaxHealth();
            if (ObjectsMaxHealth > 100)
                objectHitHealth.takeDamage(100);
        }
        else
        {
            print("Didn't find health script in object hit");
        }
    }
}

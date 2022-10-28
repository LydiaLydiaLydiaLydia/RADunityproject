using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour

    //SCRIPT INSTANTIATES A NEW BOUNCY BALL WHEN YOU PRESS THE E KEY
{
    public GameObject sphereCloneTemplate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(sphereCloneTemplate, transform.position, transform.rotation);
           
           
        }
    }

}

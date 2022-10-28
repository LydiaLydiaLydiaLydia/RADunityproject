using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFOllow : MonoBehaviour
{
    public GameObject centreTreeLocation; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //trying to get the camera to rotate around an axis in the centre of the platforms, in order to follow the spheres' rotations

        if (Input.GetKey(KeyCode.D))
            transform.RotateAround(centreTreeLocation.transform.position, Vector3.up, 1);
    }
}

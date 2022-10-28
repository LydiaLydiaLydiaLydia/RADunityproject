using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //left click to rotate void, and thus camera, anti-clockwise around the void's Y-axis
        if (Input.GetMouseButton(0))
            transform.Rotate(transform.up, 15 * Time.deltaTime);

        //right click to rotate clockwise around the void's y-axis
        if (Input.GetMouseButton(1))
            transform.Rotate(transform.up, -15 * Time.deltaTime);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthScript : MonoBehaviour
{


    int CHP = 8; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void takeDamage(int howMuchDamage)
    {
        CHP -= howMuchDamage;
        
        if (CHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}

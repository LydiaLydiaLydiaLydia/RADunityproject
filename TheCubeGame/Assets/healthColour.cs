using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthColour : MonoBehaviour
{
    //Maximum hit points, based on RAD video. If I want
    // 7 colours of a rainbow, to match the 7 notes in 
    //a scale, then I'll change the original 100 to 49.
    //int MHP = 49;


    int CHP = 49; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print(CHP);
        }
    }

    internal void takeDamage(int howMuchDamage)
    {
        CHP -= howMuchDamage;
        if (CHP <= 10)
        {
            print("help");
        }

        if (CHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}

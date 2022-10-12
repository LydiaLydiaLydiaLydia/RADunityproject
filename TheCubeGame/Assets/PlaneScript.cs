using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour
{
    //Turns out this is object-oriented coding. Who knew!
    //apparently i should know the inderlying principles of object-oriented programming already. Cool, love that.

    //making health an integer :) (current/maximum health points)
    int CHP;
    public int MHP = 100;
    //grey variables means they haven't been used

    // Start is called before the first frame update
    void Start()
    {
        CHP = MHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //we're making a method down the bottom :) this is only convention

    //what the fuck is internal? what's the alternative? 
    internal void takeDamage(int damage)
    {
        //check out this new way to reference a key
        
        //if (Input.GetKeyDown("h"))
         //   takeDamage(12);

        CHP -= damage;
        print("Ouch that hurt me health! Yowza! Now I only have" + CHP + "health left");

        
    }

    internal int whatsYourMaxHealth()
    {
        return MHP;
    }
}

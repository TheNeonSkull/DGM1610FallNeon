﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
     void OnTriggerEnter2D(Collider2D other){
         
         Destroy(gameObject);
         //Destroy(other.gameObject);

         if (other.gameObject.name == "ship2"){
             Debug.Log("You Died");
         }
     }
}

   

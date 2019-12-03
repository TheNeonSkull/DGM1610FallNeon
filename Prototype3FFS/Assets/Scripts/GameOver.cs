using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOver : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "ship2"){
            Debug.Log("Dead");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
       if (GameObject.Find ("ship2")== null){
           Debug.Log ("Dead");
       } else {
           Debug.Log("Alive");
       }
        
    }
   
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    //private float makes the variable propspin changeable only in code.
    private float propspin = 60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Makes blades rotate
     transform.Rotate (Vector3.back * propspin);   
    }
}

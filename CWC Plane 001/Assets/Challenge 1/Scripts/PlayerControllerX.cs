using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //Game Public Variables
    public float speed = 5.0f;
    public float turnSpeed;
    public float verticalInput;


    // Update is called once per frame
    void FixedUpdate()
    {
        // Gets the vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward*Time.deltaTime*speed);

        // Tilts the plane up/down based on up/down arrow keys/W or S 
        //The axis are flipped - vector3.right -lp
        transform.Rotate(Vector3.left, turnSpeed * verticalInput * Time.deltaTime);
    }
}

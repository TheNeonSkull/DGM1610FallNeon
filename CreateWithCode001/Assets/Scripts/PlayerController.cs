using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Not turining the floats to private so that they can be edited. If I wanted to i could switch all the "publics" to Private.
    public float speed = 5.0f; 
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
    void Update()
    {
        //This Code makes the vehicle move
    
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Moves vehicle forward or backwards Using W and S
        transform.Translate(Vector3.forward*Time.deltaTime*speed * forwardInput);
        //Moves vehicle left or right Using A and D
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
       
    }
}

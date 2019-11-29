using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Horizontal and Vertical Movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);


//LeftSide Barrier
        if (transform.position.x < -17){
            transform.position = new Vector3(-17, transform.position.y, transform.position.z);
        }
        //RightSide Barrier
        if (transform.position.x > 21){
            transform.position = new Vector3(21, transform.position.y, transform.position.z);}

           


    }
}

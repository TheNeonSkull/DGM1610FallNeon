using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float verticalInput;
    public GameObject projectilePrefab;
    public bool gameOver = false;
    public bool isplayer = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Horizontal and Vertical Movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.left * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.down * verticalInput * Time.deltaTime * speed);


//LeftSide Barrier
        if (transform.position.x < -17){
            transform.position = new Vector3(-17, transform.position.y, transform.position.z);
        }
        //RightSide Barrier
        if (transform.position.x > 21){
            transform.position = new Vector3(21, transform.position.y, transform.position.z);}

            if (Input.GetKeyDown(KeyCode.Space)){
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            }

          }
          private void OnCollisionEnter2D(Collision2D collision)
          {
              if (collision.gameObject.CompareTag("Player")){
                  isplayer=true;
              } else if (collision.gameObject.CompareTag("Enemy")){
                  gameOver = true;
                  Debug.Log("You are Dead");
              }
          }

           


    }


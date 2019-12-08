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
    public AudioClip shoot;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
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
        if (transform.position.x < -13){
            transform.position = new Vector3(-13, transform.position.y, transform.position.z);
        }
        //RightSide Barrier
        if (transform.position.x > 17){
            transform.position = new Vector3(17, transform.position.y, transform.position.z);}
//Spacebar shooting
            if (Input.GetKeyDown(KeyCode.Space)){
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
                playerAudio.PlayOneShot(shoot,1.0f);
            }

        
          
          }

           


    }


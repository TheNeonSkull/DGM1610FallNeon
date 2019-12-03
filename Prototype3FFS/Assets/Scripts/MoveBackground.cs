using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    private float speed = 25;
    //private PlayerControl PlayerControlScript;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerControlScript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //if (PlayerControlScript.gameOver == false){
            transform.Translate(Vector3.down * Time.deltaTime * speed);
    }

}

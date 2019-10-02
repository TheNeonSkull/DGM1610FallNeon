using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    //define range for top bound to delete
    private float topBound = 30;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this delets objects out of bounds
        if (transform.position.z > topBound){
            Destroy(gameObject);}
            //Else if is for animals
            else if (transform.position.z < lowerBound) {
                Destroy(gameObject);
            }
    }
}

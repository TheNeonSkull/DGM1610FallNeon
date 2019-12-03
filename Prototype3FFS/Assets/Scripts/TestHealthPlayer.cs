using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestHealthPlayer : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    //public Slider HealthSlider;
    //public Image DamageImage;
    public float flashSpeed = 5f;
    bool damaged;
    bool isDead;
    public Color flashColour = new Color (1f,0f,0f,0.1f);
    // Start is called before the first frame update
    void Start()
    {
        currentHealth=startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy1"){
            currentHealth-=5;
        
        }
        if(col.gameObject.tag == "Enemy1"){
            Debug.Log("Hit");
        }
}

}

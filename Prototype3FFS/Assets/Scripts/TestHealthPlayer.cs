using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestHealthPlayer : MonoBehaviour
{
    public int startingHealth=100;
    //public int currentHealth;
    int damage1=10;
    public Slider HealthSlider;
    //public Image DamageImage;
    public float flashSpeed = 5f;
    bool damaged;
    bool isDead;
    public Color flashColour = new Color (1f,0f,0f,0.1f);
    public TextMeshProUGUI gameOverText;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       HealthSlider.value = startingHealth; 
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemy1")
        {
            startingHealth-=damage1;
        
        }
        {
            if(startingHealth<=0){
                Destroy(gameObject);
                 gameOverText.gameObject.SetActive(true);
            }
        }
}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider HealthSlider;
    public Image DamageImage;
    public float flashSpeed = 5f;
    bool damaged;
    bool isDead;
    public Color flashColour = new Color (1f,0f,0f,0.1f);
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (damaged){
            DamageImage.color = flashColour;
        } else
        {
            DamageImage.color = Color.Lerp (DamageImage.color,Color.clear,flashSpeed * Time.deltaTime);
        }
        damaged = false;
    }
    public void TakeDamage (int amount)
    {
        damaged = true;
        currentHealth -= amount;
        HealthSlider.value = currentHealth;

        if(currentHealth <= 0 && !isDead){
            Debug.Log("You Died");
        }
    }
        
}

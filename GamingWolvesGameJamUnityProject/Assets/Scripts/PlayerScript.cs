using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    
    public int maxHealth = 10;
    public int currentHealth;

    public HealthBarScript healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void OnCollisionEnter(Collision collisionInfo) 
    {
        if (collisionInfo.collider.tag == "Obstacle" || collisionInfo.collider.tag == "Boundary")
        {
            TakeDamage(1); 
        }
        if (currentHealth==0)
        {
            FindObjectOfType<GameManagerScript>().EndGame();
        }
    }
    
    void TakeDamage(int damage){
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    void Update(){
        if (currentHealth<=0){
            this.gameObject.SetActive(false);
        }
    }

}

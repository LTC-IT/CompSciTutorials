﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemyHealth : MonoBehaviour
{
    
    public float health;
    public float maxHealth;

 
    public GameObject healthBarUI;
    public Slider slider;
    
// will display the Current health for the enemy when game starts. the current hp will be displayed above the enemy/ies. 
    void Start()
    {
        health = maxHealth;
        slider.value = CalculateHealth();
    }

// will re calculate/update the current hp and display it to the player in the slider bar above the enemy/ies head.
    void Update ()
    {
        slider.value = CalculateHealth();

        if(health < maxHealth)
        {
            healthBarUI.SetActive(true);
        }

        if(health <= 0)
        {
            Destroy(gameObject);
        }

        if(health > maxHealth)
        {
            health = maxHealth;
        }
    }

// if the enemy gets hit by the object projectile then there health value will go down by 1.
     private void OnTriggerEnter(Collider hit)
   {
       if(hit.gameObject.tag == "projectile")
       {
           health--;
           // will display the massgae enemy hit in the project console.
           Debug.Log("Enemy Hit");
       }
   }

// will return (display) the maxheath and health values.
    float CalculateHealth()
    {
        return health / maxHealth;

    }    
}

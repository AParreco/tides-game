using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class Health : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth = 10;
    void Start()
    {
        currentHealth =  maxHealth;
    }

    void damage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0) 
        {
            // death lol.
            // fill with death animation
        }
    }
}

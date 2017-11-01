using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int startingHealth = 100;
    public int currentHealth;

    bool isDead;
    bool damaged;
    


    void Awake ()
    {
        currentHealth = startingHealth;
	}
	
	
	void Update ()
    {

		
	}

    public void TakeDamage (int amount)
    {
        damaged = true;

        currentHealth -= amount;

        if(currentHealth <= 0 && !isDead)
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;
    }
}

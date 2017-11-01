using System.Collections;
using System.Collections.Generic;
//Using Unity Ui
using UnityEngine.UI;
//
using UnityEngine;

public class HealthBar : MonoBehaviour {
	public static int Health = 100;

	public Slider healthBar;


	void Start()
	{
		//time for regen to happen
		InvokeRepeating ("HealthReduction",1,1);
	
	}

	void HealthReduction()
	{

		//regen
		Health = Health + 1;
		//
		healthBar.value = Health;
		if (Health <= 0)
		{
			//player play death animation
			//player.GetComponents<Animator>().SetTrigger("isDead");
		}

	}

}


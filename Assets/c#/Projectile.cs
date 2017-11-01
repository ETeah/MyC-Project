using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
	float speed;



	// Use this for initialization
	public void SetSpeed(float newSpeed) {
		//just incase we need to change the speed
		speed = newSpeed;
	}

	// Update is called once per frame---how fast we want the bullet to go
	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Enemy"))
		{
			other.gameObject.SetActive (false);
		}
	}
}

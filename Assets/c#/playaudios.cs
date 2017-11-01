using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class playaudios : MonoBehaviour {
	bool istaken = false;
	public AudioSource audio;
	void Start() {
		AudioSource audio = GetComponent<AudioSource>();

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Money")) {

			audio.Play ();
			audio.Play (44100);
			bool istaken = true;
			other.gameObject.SetActive (false);
		}



	}

	// Kills the game object
	//Destroy (gameObject);

	// Removes this script instance from the game object
	//Destroy (this);

	// Removes the rigidbody from the game object
	//Destroy (rigidbody);

	// Kills the game object in 5 seconds after loading the object
	//Destroy (gameObject, 5);
}

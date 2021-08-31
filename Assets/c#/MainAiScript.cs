using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof (UnityEngine.AI.NavMeshAgent))]
[RequireComponent (typeof (Rigidbody))]
public class MainAiScript : MonoBehaviour {

	 Transform ZombieTarget;
	private Animator ZombieAnimator;

	//SetBool for walking animation
	bool zombieWalking = false;
	bool zombieMalee = false;
	//end bool calls


	// Use this for initialization
	void Start () {
		ZombieAnimator = GetComponent<Animator> ();
	
		ZombieTarget = GameObject.FindGameObjectWithTag("Player").transform;
	}


	// Update is called once per frame
	void Update ()
	{


		//animation stuff
		if (zombieWalking = true) {
			ZombieAnimator.SetBool ("malee",false);
		}
		if (zombieMalee = true) {
			ZombieAnimator.SetBool ("walk",false);
		}
		//

		if (Vector3.Distance (ZombieTarget.position, this.transform.position) < 90) {
	

			Vector3 direction = ZombieTarget.position - this.transform.position;
			direction.y = 0f;
			this.transform.rotation = Quaternion.Slerp (this.transform.rotation, 
				Quaternion.LookRotation (direction), 0.1f);
		

			if (direction.magnitude > 5) {
				ZombieAnimator.SetBool ("walk",true);
				this.transform.Translate (0, 0, 0.5f * Time.fixedDeltaTime);

			}

		}

	}

	void OntriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("Player")) {
			ZombieAnimator.SetBool ("malee", true);
		} else {
			if (other.gameObject.CompareTag("Bullet"))
			{
				this.gameObject.SetActive (false);
			}
		}
		}
		
}



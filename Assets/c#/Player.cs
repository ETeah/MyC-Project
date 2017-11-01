using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
//this function calls only after you have identified your engines and systems...always put it below the using sytsem
[RequireComponent (typeof (Rigidbody))]
[RequireComponent (typeof (playerController))]
[RequireComponent (typeof (gunController))]
[RequireComponent(typeof(AudioSource))]

public class Player : LivingUpdate {
	bool ShootSound = false;

	public AudioSource gunSoundAudioSource;

	//animator
	private Animator AjaxAnimator;

	//public float 
	public float moveSpeed = 5;
	public float speed;
    
	//SetBool for walking animation
	bool walking = false;
	//end bool calls


		//Object references
		playerController controller;
		Camera viewCamera;
	    gunController GunController;
		//Object references Ends

	 void Start(){
		base.Start ();
		//audiosource
		AudioSource gunSoundAudioSource = GetComponent<AudioSource>();
		//
	
		//guncontroller reference--this also require us to use a system [requires gunController]
		GunController = GetComponent<gunController>();


		//use animator when the game starts
		AjaxAnimator = GetComponent<Animator>();
		//use playercontroller script when the game starts
		controller = GetComponent<playerController> ();
		viewCamera = Camera.main;		
	}
		

		void Update () {
	//anim stuff	
		if (Input.GetKey (KeyCode.S)) {
			bool walking = true;
			if (walking = true) {
				AjaxAnimator.SetBool ("isWalking",true);
			}
		}
		//

		//This is where we have our animation to play using velocity of keypressdown
		AjaxAnimator.SetFloat("VSpeed", Input.GetAxis ("Vertical"));
		AjaxAnimator.SetFloat ("HSpeed", Input.GetAxis ("Horizontal"));
		//

		//Below this is the movement script
		Vector3 moveInput = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		Vector3 moveVelocity = moveInput.normalized * moveSpeed;
		//

		//call controller function
		controller.Move (moveVelocity);	
		//call controller function ends

		//this part control the mouse look
		Ray ray = viewCamera.ScreenPointToRay (Input.mousePosition);
		Plane groundPlane = new Plane (Vector3.up, Vector3.zero);
		//set a float -this ray shows the look rotation of the camera at the player
		float rayDistance;
		//call float ends
		if (groundPlane.Raycast (ray, out rayDistance)) {
			Vector3 point = ray.GetPoint (rayDistance);
			//Debug.DrawLine(ray.origin,poin,Color.red);
			controller.LookAt (point);

//Shooting the gun
			if (Input.GetMouseButtonDown (0)) {
				//use bool to count if player press button for long
				GunController.OnTriggerRelease();
				bool ShootSound = true;
				if (ShootSound = true) {
					gunSoundAudioSource.Play ();
					gunSoundAudioSource.Play (44100);
				}

			}
			if (Input.GetMouseButtonUp(0)) {
				GunController.OnTriggerHold ();
				//use bool to count if player press button for long


			}

		}
	}



//Health Bool
	bool continueToHurtPlayer = false;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Enemy")) {


			other.gameObject.SetActive (false);
			//count = count + 1;
			//SetCountText ();

			bool continueToHurtPlayer = true;
			if (continueToHurtPlayer = true) {
				if (HealthBar.Health > 0) {
				
					HealthBar.Health -= 30;
				}
			}


			if (HealthBar.Health < 0) {
				AjaxAnimator.SetTrigger ("isDead");
				SceneManager.LoadScene ("gameOver");

			}

		}

	}

	/// <summary>End Health bool
}














	
	
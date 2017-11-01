using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

		Rigidbody myRigidbody;
		Vector3 velocity;
	//counting collectables
	private int count;

		void Start () 
	{
		myRigidbody = GetComponent<Rigidbody>();
		//count
		count = 0;
		//
	}




		public void Move(Vector3 _velocity)
		{
			velocity = _velocity;
		}
		//REFERANCE THE CAMERA FROM "PLAYER" SCRIPT -THEN DIRECT THE EYE TO THE PLAYER
		public void LookAt(Vector3 lookPoint)
		{
			Vector3 heightCorrectedPoint = new Vector3 (lookPoint.x,transform.position.y, lookPoint.z);
			transform.LookAt (heightCorrectedPoint);
		}
		//END THE CAMERA EYE DIRECTION function
		public void FixedUpdate()
		{
			myRigidbody.MovePosition (myRigidbody.position + velocity * Time.fixedDeltaTime);
		}

	}

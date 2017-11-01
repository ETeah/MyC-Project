using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//
[RequireComponent (typeof (UnityEngine.AI.NavMeshAgent))]
[RequireComponent (typeof (Rigidbody))]
//
public class ZombieAi : MonoBehaviour {

	//nav controll for ai stuff
	UnityEngine.AI.NavMeshAgent pathfinder;
	Transform  target;
	//end nav mesh controller stuff
  //stats
	int zombieHp;
  //animation stuff
	private Animator ZombieAnimator;
	bool walkingZombie = false;
	bool attacking = false;


	void Start ()
	{

		//path finder
		target = GameObject.FindGameObjectWithTag("Player").transform;
		pathfinder = GetComponent<UnityEngine.AI.NavMeshAgent>();
		StartCoroutine(UpdatePath ());
		//
		zombieHp = 10;

		walkingZombie = true;
      ZombieAnimator= GetComponent<Animator>();

	}



	void Update ()
	{
		//animation stuff
		if (0 >= zombieHp) {
			ZombieAnimator.SetTrigger ("DeadZ");
		}

		if (walkingZombie = true) {
			ZombieAnimator.SetBool ("WalkingZ", true);
		}


	}
	//animation attack


			//other.gameObject.SetActive (false);
	


	//end animation stuff
	IEnumerator UpdatePath(){
		float refreshRate = 0.24f;

		while(target != null)
		{
			Vector3 targetPosition = new Vector3 (target.position.x, 0, target.position.z);

		pathfinder.SetDestination(targetPosition);
		yield return new WaitForSeconds(refreshRate);
	}
	}

	//this is the path finder to theplayer


	//Check the collision of bullect and know when to die


	//health collision detect done

}

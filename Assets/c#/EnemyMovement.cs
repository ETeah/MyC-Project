using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {

    Transform player;
    //HealthBar playerHealth;
    //EnemyHealth enemyHealth;
    NavMeshAgent nav;

	void Awake ()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //playerHealth = player.GetComponent<HealthBar>();
        //enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();	
	}
	
	
	void Update ()
    {
	    //if(enemyHealth.currentHealth > 0 && playerHealth.CurrentHealth > 0)
     //   {
            nav.SetDestination(player.position);
        //}
        //else
        //{
        //    nav.enabled = false;
        //}
	}
}
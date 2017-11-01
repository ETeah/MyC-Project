using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour {

	public Wave[] waves;
	public Enemy enemy;

	//wave time
	Wave currentZombieWave;
	int currentZombieWaveNumber;
	//
	int enemiesRemainingToSpawn;
	float nextSpawnTime;

		void Start(){
			NextWave();
		}
		void Update(){
			if (enemiesRemainingToSpawn > 0 && Time.time > nextSpawnTime) {
				enemiesRemainingToSpawn--;
				nextSpawnTime = Time.time + currentZombieWave.timeBetweenSpawns;

				Enemy spawnedEnemy = Instantiate (enemy, Vector3.zero, Quaternion.identity) as Enemy;

			}

		}
		void NextWave()
		{
			currentZombieWaveNumber++;
		currentZombieWave = waves [currentZombieWaveNumber - 1];

			enemiesRemainingToSpawn = currentZombieWave.enemyCount;
		}
	//(System Serializable)...this shows the number-which allow use to edit how much zombie are in how much waves, and how fast they should spawn .

	[System.Serializable]
	public class Wave
	{
		public int enemyCount;
		public float timeBetweenSpawns;
		//
		} 
	}

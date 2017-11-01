using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour {
	public enum FireMode { Auto, ShotGun, Single}
	public FireMode firemode;
	//positons
	public Transform muzzle;
	//end positions call
	bool triggerRelaesedSinceLastShot;
	//foats
	public float minutesBetweenShots = 5000;
	public float muzzleVelocity = 3000;
	float nextShotTime;
	//end float calls
	//Counting the amount of shot per min
	public int burstCount;
	int shotRemainingInBurst;

	//reference to our projectile script
	public Projectile projectile;
	//end reference
	void Start()
	{
		shotRemainingInBurst = burstCount;
	}




	 void ShootTheGun()
	{
		if (Time.time > nextShotTime)
		{
			nextShotTime = Time.time + minutesBetweenShots / 500;
			Projectile newProjectile = Instantiate (projectile, muzzle.position, muzzle.rotation) as Projectile;
			newProjectile.SetSpeed (muzzleVelocity);

		//type of shooting
			if(firemode == FireMode.ShotGun){
				if (shotRemainingInBurst == 0) {
					return;
				}
				shotRemainingInBurst --;	
		}
			else{
				if(firemode == FireMode.Auto){
					if (!triggerRelaesedSinceLastShot) {
						return;
					}
				}

	}
}
	}



	public void OnTriggerHold()
	{
		ShootTheGun();
		triggerRelaesedSinceLastShot = true;

	}
	public void OnTriggerRelease()
	{
		triggerRelaesedSinceLastShot = false;

		shotRemainingInBurst = burstCount;
	}

}


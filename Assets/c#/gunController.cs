using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunController : MonoBehaviour {

	//Call our pubic variables
	public Transform weaponHold;
	public gun startingGun;
	//Public call ends

	//Reference objects
	gun equippedGun;
	//End Object reference

	//Put a game object to start with
	void Start(){
		if(startingGun != null){
			EquipGun(startingGun);
		}
	}
	//get the gun
	public void EquipGun (gun gunToEquip) 
	{
		if (equippedGun != null)
		{
			Destroy(equippedGun.gameObject);
		}
			
		//make the gun appear at the WeaponHold transform
		equippedGun = Instantiate(gunToEquip,weaponHold.position, weaponHold.rotation)as gun;
		//make the gun a child of the weaponHold -so it can stay with the player when he moves
	    equippedGun.transform.parent = weaponHold;
    }

	//Set a funtion for gunController.shoot

	public void OnTriggerHold()
	{
		if (equippedGun != null)
			equippedGun.OnTriggerHold();
	}

 public void OnTriggerRelease()
{
	if (equippedGun != null)
		equippedGun.OnTriggerRelease();
}

}

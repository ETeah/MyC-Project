using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class textadding : MonoBehaviour {

	//public float speed;
	public Text countCashText;
	public Text NotificationText;



	//private Rigidbody rb;
	private int count;

	void Start ()
	{
	//	rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		NotificationText.text = "";
	}

	//void FixedUpdate ()
	//{
	//	float moveHorizontal = Input.GetAxis ("Horizontal");
	//	float moveVertical = Input.GetAxis ("Vertical");

////Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		//rb.AddForce (movement * speed);
	//}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ( "Money"))
		{
			//other.gameObject.SetActive (false);
			count = count + 5;
			SetCountText ();
		}
	}

	void SetCountText ()
	{
		countCashText.text = "Cash: " + count.ToString () + "$";
		if (count >= 12)
		{
			NotificationText.text = "Ching Chin!";
		}
	}
}
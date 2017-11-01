using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunfollow : MonoBehaviour {


		public GameObject BoneHands;

		private Vector3 offset;

		void Start ()
		{
		offset = transform.position - BoneHands.transform.position;
		}

		void LateUpdate ()
		{
		transform.position = BoneHands.transform.position + offset;
		}
	}

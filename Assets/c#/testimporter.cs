using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testimporter : MonoBehaviour {


	//public calls
	public TextAsset textFile;
	public string[] textLines;


	//end public calls

	// Use this for initialization
	void Start () {
		if(textFile != null)
		{
			//split my text up!
			textLines = (textFile.text.Split ('\n'﻿));
		}
	}

	// Update is called once per frame
	void Update () {

	}
}

using System.Collections;
using System.Collections.Generic;
//
using UnityEngine.UI;
//
using UnityEngine;

public class TextBoxMoniter : MonoBehaviour {


	//public calls
	public TextAsset textFile;
	public string[] textLines;
	public Text theText;
	//game object
	public GameObject textBox;
	//end public calls
	//

	public int currentLine;
	public int endAtLine;

	//


	public playerController player;

	// Use this for initialization
	void Start () {

		// find the player
		player = FindObjectOfType<playerController>();
		//end playerscript gameobject finder

		if(textFile != null)
		{
			//split my text up!
			textLines = (textFile.text.Split ('\n'﻿));
		}
		//when to end the text line
		if(endAtLine == 0)
		{
			endAtLine = textLines.Length + 1;

		}
		//end the text line function is done
	}

	// Update is called once per frame
	void Update () {
		theText.text = textLines[currentLine];
		if (Input.GetKeyDown (KeyCode.Return)) {
			currentLine += 1;
		}
		if(currentLine > endAtLine)
		{
			textBox.SetActive(false);
		}
	}
		
}

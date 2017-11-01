using System.Collections;
using System.Collections.Generic;

//add the calls for extra machenics
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//End the calls

using UnityEngine;
public class MenuScript : MonoBehaviour {

	//Menu Container
	public GameObject mainMenuHolder;
	public GameObject optionsMenuHolder;
	public GameObject teamInfoMenuHolder;
	//End creation of Menu Container

	//Public Arrays of sliders
	public Slider[] volumeSliders;
	public Toggle[] resolutionToggles;
	public int[] screenWidths;
	//end call of arrays


	//Call Screen Resolution funtion
	int activeScreenResIndex;
	//End screen rez call funtions 


	//Set a save setting funtion
	void Start()
	{
		//activeScreenResIndex = PlayerPref.GetInt("screen res index");
		bool isFullscreen = false;

		for(int i = 0; i < resolutionToggles.Length; i++)
		{
			resolutionToggles [i].isOn = i == activeScreenResIndex;
		}
	
	}



	//playgame
	public void Play(){
		SceneManager.LoadScene ("Level One");
	}
	//team information
	//public void AboutUs(){
	//	SceneManager.LoadScene ("Team Information");
	//}
	//end gameplay
	public void Quit(){
		Application.Quit();
	}

	//End Buttons setter


	//switch the tabs by making menus invissible 
	public void OptionsMenu(){
		mainMenuHolder.SetActive(false);
		optionsMenuHolder.SetActive(true);
		teamInfoMenuHolder.SetActive(false);
	}

	public void MainMenu(){
		mainMenuHolder.SetActive(true);
		optionsMenuHolder.SetActive(false);
		teamInfoMenuHolder.SetActive(false);
	}
	public void AboutUsMenu(){
		mainMenuHolder.SetActive(false);
		optionsMenuHolder.SetActive(false);
		teamInfoMenuHolder.SetActive(true);
	}
	//End Menu Switcher

	//ScreenRez

	public void SetScreenResolution(int i){
		if(resolutionToggles [i].isOn)
		{ 
			activeScreenResIndex = i;
			float aspectRatio = 16/9f;
			Screen.SetResolution (screenWidths [i], (int)(screenWidths [i] / aspectRatio), false);
			//saving input from player
			//PlayerPref.SetInt("screen res index",activeScreenResIndex);
		//	PlayerPref.Save ();
			//
		}

	} 

	public void SetFullscreen( bool isFullscreen) {

		for(int i = 0; i < resolutionToggles.Length; i++)
		{
			resolutionToggles [i].interactable = !isFullscreen;
		}
		if(isFullscreen)
		{
			Resolution[] allResolutions = Screen.resolutions;
			Resolution maxResolution = allResolutions[allResolutions.Length - 1];
			Screen.SetResolution (maxResolution.width, maxResolution.height, true);
		}
		else
		{
			SetScreenResolution(activeScreenResIndex);
		}
		//saving player input
		//PlaerPref.SetInt("fullscreen",((isFullscreen)? 1: 0));
		//PlayerPref.Save ();
		//

	}
	public void SetGameVolume(float value){
		//AudioManager.instance.SetVolume(value, AudioManager.AudioChannel.Game);
	}
	public void SetMusicVolume(float value){
		//AudioManager.instance.SetVolume(value, AudioManager.AudioChannel.Music)
	}
	public void SetVoiceVolume(float value){
		//AudioManager.instance.SetVolume(value, AudioManager.AudioChannel.Voice)
	}
	//EndScreen rez
}
using UnityEngine;
using System.Collections;

public class buttonActions : MonoBehaviour {
	
	public void BUTTON_LOAD_SCENE_WELCOME(){
		Application.LoadLevel("menu");
	}
	
	public void BUTTON_LOAD_SCENE_LEVEL1_PLAYING(){
		Application.LoadLevel("level1scene");
	}
	public void BUTTON_LOAD_SCENE_LEVEL2_PLAYING(){
		Application.LoadLevel("level2scene");
	}
	public void BUTTON_LOAD_SCENE_LEVEL3_PLAYING(){
		Application.LoadLevel("level3scene");
	}
}


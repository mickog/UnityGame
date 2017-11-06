using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class GameWon : MonoBehaviour {
	public Text textScoreValue;
	
	void Start(){
		int newNum = PlayerPrefs.GetInt("Kill");
		string killString = "" + newNum;
		textScoreValue.text = killString;
	}
}


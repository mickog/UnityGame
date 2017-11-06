using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class PlayerDisplay : MonoBehaviour 
{
	public Text scoreText;
	public Text keyText;

	public void UpdateScoreText(int newScore)
	{
		string scoreMessage = "Helmets = " + newScore;
		scoreText.text = scoreMessage;

	}
	public void UpdateKeyText(bool key)
	{
		string keyMessage = "USB Key";
		keyText.text = keyMessage;
		
	}


}


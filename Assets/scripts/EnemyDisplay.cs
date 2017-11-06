using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class EnemyDisplay : MonoBehaviour {

	public Text killText;


	public void UpdateKillText(int kill)
	{
	
		string killMessage = "Score is = " + kill;
		killText.text = killMessage;

	}

}

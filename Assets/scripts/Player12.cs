using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class Player12 : MonoBehaviour 
{
	private PlayerDisplay playerDisplay;
	private int score = 0;


	void Start()
	{
		playerDisplay = GetComponent<PlayerDisplay>();
		playerDisplay.UpdateScoreText(score);
		
	}
	
	// Update is called once per frame
	void Update(){

		CheckGameWon();
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "helmet") {
			score++;
			playerDisplay.UpdateScoreText (score);
			audio.Play ();
		}	

	}
	
	
	private int CountObjectsWithTag(string tag)
	{
		GameObject[] helmetObjects = GameObject.FindGameObjectsWithTag(tag);
		return helmetObjects.Length;
	}
	
	private void CheckGameWon()
	{
		int numFoodObjects = CountObjectsWithTag("helmet");
		
		
		if(numFoodObjects < 1)
		{
			// make sure you spell this correctly!
			Application.LoadLevel("GameWon");
		}
	}
	
	
	
}

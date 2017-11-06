using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class Player : MonoBehaviour 
{
	private PlayerDisplay playerDisplay;
	private bool carryingKey=false;
	private int kill = 0;
	private int score = 0;
	public AudioSource breath;
	public AudioSource key;

	public int getKill()
	{
		return kill;
	}
	public bool IsCarryingKey()
	{
		return carryingKey;
	}
	public void DropKey()
	{
		carryingKey = false;
	}
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
				if (other.tag == "helmet") 
		{
						score++;
						playerDisplay.UpdateScoreText (score);
						Destroy (other.gameObject);
						breath.Play ();
		}	
				if (other.tag == "key") 
		{
						carryingKey = true;
						playerDisplay.UpdateKeyText (carryingKey);
						Destroy (other.gameObject);
						key.Play ();
						
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
			GameWonActions();		
		}
	}
	private void GameWonActions()
	{
		Application.LoadLevel("GameWon");
	}

}

using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
	// public
	public Text timerText;
	public Slider timerSlider;

	public int timeForLevel = 180; 

	// private
	private CountdownTimer countdownTimer;

	//--------------------------------------
	void Start() 
	{
		countdownTimer = GetComponent<CountdownTimer>();
		countdownTimer.ResetTimer(timeForLevel); 
	}
	
	//--------------------------------------
	void Update() 
	{
		int secondsLeft = countdownTimer.GetSecondsRemaining();
		
		CheckGameOver(secondsLeft);
		UpdateTimerDisplay(secondsLeft);
		UpdateTimerSlider();
	}
	
	//---------------------------
	private void UpdateTimerSlider()
	{
		float proportionRemaining = countdownTimer.GetProportionTimeRemaining();
		timerSlider.value = proportionRemaining;
	}

	//--------------------------------------
	private void CheckGameOver(int secondsLeft)
	{
		// GAME OVER if seconds < 0 !!!!!
		if(secondsLeft < 0)
		{
			Application.LoadLevel("gameOverScene"); 
		}
	}

	//---------------------------
	private void UpdateTimerDisplay(int secondsLeft)
	{
		string timerMessage = "Time left = " + secondsLeft;
		timerText.text = timerMessage;
	}
}

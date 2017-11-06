using UnityEngine;
using System.Collections;

public class SphereSensor : MonoBehaviour {
	public EnemyNavigation enemyNavigation;
	
	void OnTriggerEnter(Collider hit)
	{
		if(hit.CompareTag("Player"))
		{
			enemyNavigation.SetFollowingPlayer(true);
		}
	}
	
	void OnTriggerExit(Collider hit)
	{
		if(hit.CompareTag("Player"))
		{
			enemyNavigation.SetFollowingPlayer(false);
		}
	}
}

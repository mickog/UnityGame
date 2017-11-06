using UnityEngine;
using System.Collections;

public class EnemyNavigation : MonoBehaviour 
{
	public void SetFollowingPlayer(bool followingPlayer)
	{
		this.followingPlayer = followingPlayer;
		if(this.followingPlayer)
		{
			navMeshAgent.Resume();
		}
		else
		{
			navMeshAgent.Stop();
		}
	}

	private bool followingPlayer = false;

	private NavMeshAgent navMeshAgent;
	private GameObject player;

	// get reference to our player and out nav mesh agent
	void Start () 
	{
		navMeshAgent = GetComponent<NavMeshAgent>();
		player = GameObject.FindGameObjectWithTag("Player");
	}

	// every frame update our enemy target position to be the current Player position
	void Update () 
	{
		if(followingPlayer)
		{
			Vector3 playerPosition = player.transform.position;
			navMeshAgent.SetDestination(playerPosition);	
		}
	}
}

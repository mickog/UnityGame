using UnityEngine;
using System.Collections;

public class RocketSensor : MonoBehaviour {
	private Animator animator;
	private Player player;
		
	void Start(){
		animator = GetComponent<Animator>();
		GameObject playerGo = GameObject.FindGameObjectWithTag ("Player");
		player = playerGo.GetComponent<Player> ();
	}
	
	void OnTriggerEnter(Collider hit){
		if(hit.CompareTag("Player")&& player.IsCarryingKey()){
			animator.SetTrigger("liftOff");
			player.DropKey();
		}
		
	}
}


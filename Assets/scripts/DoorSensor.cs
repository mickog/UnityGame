using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class DoorSensor : MonoBehaviour {
	private Animator animator;


	void Start(){
		animator = GetComponent<Animator>();
	}
	
	void OnTriggerEnter(Collider hit){
		if(hit.CompareTag("Player")){
			animator.SetTrigger("open");
		}

	}
}

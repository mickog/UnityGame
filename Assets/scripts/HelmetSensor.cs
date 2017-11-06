using UnityEngine;
using System.Collections;

public class HelmetSensor : MonoBehaviour {

	private Animator animator;
	
	void Start(){
		animator = GetComponent<Animator>();
	}
	
	void OnTriggerEnter(Collider hit){
		if(hit.CompareTag("Player")){
			Destroy(gameObject);
		}
	}
}


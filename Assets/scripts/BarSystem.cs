using UnityEngine;
using System.Collections;

public class BarSystem : MonoBehaviour {
	public int damage = 50;
	public float distance;
	public float maxDistance = 1.5f;
	public Transform bar;
	
	RaycastHit hit;
	
	void Update()
	{
		if (Input.GetButtonDown ("Fire1"))
		{
			bar.animation.Play("Attack");
			if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out hit))
			{
				distance = hit.distance;
				if (distance < maxDistance)
				{
					hit.transform.SendMessage ("ApplyDamage", damage, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
	}
}
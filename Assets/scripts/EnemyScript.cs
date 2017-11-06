
using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	public int health = 100;
	private EnemyDisplay enemyDisplay;

	public static int kill;
	private int newNum;
	public int getKill()
	{
		return kill;
	}
	void Start()
	{
		enemyDisplay = GetComponent<EnemyDisplay>();
	}
	void Update()
	{
		if (health <= 0)
		{
			Dead();
		}	
	}
	
	void ApplyDamage(int damage)
	{
		health -= damage;
	}
	
	void Dead()
	{	
		newNum=kill+1;
		PlayerPrefs.SetInt ("kill", newNum);
		enemyDisplay.UpdateKillText(kill);
		Destroy (gameObject);
	}
}
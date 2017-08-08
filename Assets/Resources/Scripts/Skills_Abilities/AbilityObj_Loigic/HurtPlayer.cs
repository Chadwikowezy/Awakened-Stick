using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour 
{
	private int abilityDamageModifier;
	public int baseModifier;
	private Enemy enemy;

	private void Start()
	{
		if(enemy == null)
		{
			enemy = FindObjectOfType<Enemy>();
		}
	}

	void StatUpdate()
	{
		enemy = FindObjectOfType<Enemy>();
		if (tag == "Arcane")
		{
			//abilityDamageModifier = (enemy.CurrentArcane + baseModifier);
		}
		else if (tag == "Speed")
		{
			//abilityDamageModifier = (enemy.CurrentSpeed + baseModifier);
		}
		else if (tag == "Rage")
		{
			//abilityDamageModifier = (enemy.CurrentRage + baseModifier);
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		StatUpdate();
		if (collision.gameObject.tag == "Player")
		{
			if(collision.gameObject.transform.position.x < transform.position.x)
			{
				collision.gameObject.GetComponent<Rigidbody2D>().AddForce(-Vector2.right * 500);
				collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 250);
				collision.gameObject.GetComponent<Player>().AlterHealth(abilityDamageModifier);

			}
			else if(collision.gameObject.transform.position.x > transform.position.x)
			{
				collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 500);
				collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 250);
				collision.gameObject.GetComponent<Player>().AlterHealth(abilityDamageModifier);
			}
		}

	}

}

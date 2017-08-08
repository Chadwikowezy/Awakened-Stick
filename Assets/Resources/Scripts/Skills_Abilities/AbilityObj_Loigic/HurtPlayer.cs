using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour 
{
	public int baseDamage;
	private Player player;

	private void Start()
	{
		if(player == null)
		{
			player = FindObjectOfType<Player>();
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.gameObject.tag == "Player")
		{
			if(collision.gameObject.transform.position.x < transform.position.x)
			{
                if(player != null)
                {
                    collision.gameObject.GetComponent<Rigidbody2D>().AddForce(-Vector2.right * 500);
                    collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 250);
                    collision.gameObject.GetComponent<Player>().AlterHealth(baseDamage);
                    Destroy(this.gameObject);
                }		
			}
			else if(collision.gameObject.transform.position.x > transform.position.x)
			{
                if (player != null)
                {
                    collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 500);
                    collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 250);
                    collision.gameObject.GetComponent<Player>().AlterHealth(baseDamage);
                    Destroy(this.gameObject);
                }
            }
		}

	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDamage : MonoBehaviour
{

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            if(collision.gameObject.transform.position.x < transform.position.x)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(-Vector2.right * 300);
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 200);
                Debug.Log("Hit");

            }
            else if(collision.gameObject.transform.position.x > transform.position.x)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 300);
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 200);
                Debug.Log("Hit");
            }
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDamage : MonoBehaviour
{
    public int abilityDamageModifier = 5;
    private Player player;

    private void Start()
    {
        if(player == null)
        {
            player = FindObjectOfType<Player>();
        }
        abilityDamageModifier = player.CurrentAttack;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            if(collision.gameObject.transform.position.x < transform.position.x)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(-Vector2.right * 650);
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 325);
                collision.gameObject.GetComponent<Enemy>().AlterHealth(abilityDamageModifier);

            }
            else if(collision.gameObject.transform.position.x > transform.position.x)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 650);
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 325);
                collision.gameObject.GetComponent<Enemy>().AlterHealth(abilityDamageModifier);
            }
        }
        
    }
}

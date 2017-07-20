using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDamage : MonoBehaviour
{
    public int abilityDamageModifier = 5;
    private Player player;

    private void Awake()
    {
        /*
        player = FindObjectOfType<Player>();

        if(tag == "ArcaneBasedSkill")
        {
            abilityDamageModifier = player.arcane;
        }
        else if (tag == "RageBasedSkill")
        {
            abilityDamageModifier = player.rage;
        }
        else if (tag == "SpeedBasedSkill")
        {
            abilityDamageModifier = player.speed;
        }
        */

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
                Debug.Log("Hit");

            }
            else if(collision.gameObject.transform.position.x > transform.position.x)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 650);
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 325);
                collision.gameObject.GetComponent<Enemy>().AlterHealth(abilityDamageModifier);
                Debug.Log("Hit");
            }
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDamageMovingObjects : MonoBehaviour
{
    private int abilityDamageModifier;
    public int baseModifier;
    private Player player;
    private AnimationsManager animManager;

    private void Start()
    {
        if(player == null)
        {
            player = FindObjectOfType<Player>();
        }
    }

    void StatUpdate()
    {
        player = FindObjectOfType<Player>();
        if (tag == "Arcane")
        {
            abilityDamageModifier = (player.CurrentArcane + baseModifier);
        }
        else if (tag == "Speed")
        {
            abilityDamageModifier = (player.CurrentSpeed + baseModifier);
        }
        else if (tag == "Rage")
        {
            abilityDamageModifier = (player.CurrentRage + baseModifier);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StatUpdate();
        if (collision.gameObject.tag == "Enemy")
        {
            if(collision.gameObject.transform.position.x < transform.position.x)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(-Vector2.right * 500);
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 250);
                collision.gameObject.GetComponent<Enemy>().AlterHealth(abilityDamageModifier);

            }
            else if(collision.gameObject.transform.position.x > transform.position.x)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 500);
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 250);
                collision.gameObject.GetComponent<Enemy>().AlterHealth(abilityDamageModifier);
            }
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDamageStationarySkill : MonoBehaviour
{
    private int damageMultiplier = 5;
    private Player player;

	void Start ()
    {
        player = FindObjectOfType<Player>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        damageMultiplier = player.CurrentAttack;
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<Enemy>().AlterHealth(damageMultiplier / 15f);
        }
    }
}

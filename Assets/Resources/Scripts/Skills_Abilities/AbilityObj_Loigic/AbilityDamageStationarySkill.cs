using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDamageStationarySkill : MonoBehaviour
{
    private int damageMultiplier;
    public int baseModifier;
    private Player player;

	void Start ()
    {
        if (player == null)
        {
            player = FindObjectOfType<Player>();
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        StatUpdate();
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<Enemy>().AlterHealth(damageMultiplier / 15f);
        }
    }
    void StatUpdate()
    {
        player = FindObjectOfType<Player>();
        if (tag == "Arcane")
        {
            damageMultiplier = (player.CurrentArcane + baseModifier);
        }
        else if (tag == "Speed")
        {
            damageMultiplier = (player.CurrentSpeed + baseModifier);
        }
        else if (tag == "Rage")
        {
            damageMultiplier = (player.CurrentRage + baseModifier);
        }
    }
}

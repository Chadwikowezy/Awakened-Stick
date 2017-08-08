using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDamageStationarySkill : MonoBehaviour
{
    private int damageMultiplier;
    public float baseModifier;
    private Player player;

    private List<Enemy> hitEnemies = new List<Enemy>();

	void Start ()
    {
        if (player == null)
        {
            player = FindObjectOfType<Player>();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            hitEnemies.Add(other.gameObject.GetComponent<Enemy>());
            StartCoroutine(SearingIgnitionDelay());
        }
    }

    IEnumerator SearingIgnitionDelay()
    {
        StatUpdate();
        foreach(Enemy enemy in hitEnemies)
        {
            if(enemy != null)
            {
                enemy.AlterHealth(damageMultiplier);
            }
        }
        yield return new WaitForSeconds(1);
        foreach (Enemy enemy in hitEnemies)
        {
            if (enemy != null)
            {
                enemy.AlterHealth(damageMultiplier);
            }
        }
    }


    void StatUpdate()
    {
        player = FindObjectOfType<Player>();
        if (tag == "Arcane")
        {
            damageMultiplier = (player.CurrentArcane + (int)baseModifier);       
        }
        else if (tag == "Speed")
        {
            damageMultiplier = (player.CurrentSpeed + (int)baseModifier);
        }
        else if (tag == "Rage")
        {
            damageMultiplier = (player.CurrentRage + (int)baseModifier);
        }
    }
}

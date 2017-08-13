using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySearingIgnition : MonoBehaviour
{
    private Player player;
    public int baseDamageMultiplier;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(SearingIgnitionDelay());
        }
    }

    IEnumerator SearingIgnitionDelay()
    {
        player = FindObjectOfType<Player>();
        if (player != null)
        {
            player.AlterHealth(baseDamageMultiplier);
        }
        yield return new WaitForSeconds(1);
        player = FindObjectOfType<Player>();
        if (player != null)
        {
            player.AlterHealth(baseDamageMultiplier);
        }


    }
}

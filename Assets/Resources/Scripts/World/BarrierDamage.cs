using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierDamage : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Player>())
        {
            other.gameObject.GetComponent<Player>().AlterHealth(10);
        }
    }
}

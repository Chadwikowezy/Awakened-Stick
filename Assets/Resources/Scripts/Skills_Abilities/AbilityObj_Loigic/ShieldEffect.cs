using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldEffect : MonoBehaviour
{
    public ParticleSystem shieldEffect;

	public void ActivateShield()
    {
        shieldEffect.gameObject.SetActive(true);
    }
}

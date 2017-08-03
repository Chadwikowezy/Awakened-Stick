using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTreeTabing : MonoBehaviour
{
    public GameObject speedSkillTab;
    public GameObject rageSkillTab;
    public GameObject arcaneSkillTab;

    public void EnableSpeed()
    {
        rageSkillTab.SetActive(false);
        arcaneSkillTab.SetActive(false);

        speedSkillTab.SetActive(true);
    }
    public void EnableRage()
    {
        speedSkillTab.SetActive(false);
        arcaneSkillTab.SetActive(false);

        rageSkillTab.SetActive(true);
    }
    public void EnableArcane()
    {
        rageSkillTab.SetActive(false);
        speedSkillTab.SetActive(false);

        arcaneSkillTab.SetActive(true);
    }
}

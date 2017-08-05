using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTreeTabing : MonoBehaviour
{
    public GameObject speedSkillTab;
    public GameObject rageSkillTab;
    public GameObject arcaneSkillTab;

    private Actor actor;


    public void EnableSpeed()
    {       
        rageSkillTab.SetActive(false);
        arcaneSkillTab.SetActive(false);

        speedSkillTab.SetActive(true);
        actor = FindObjectOfType<Actor>();
        actor.ReturnSkills();
    }
    public void EnableRage()
    {       
        speedSkillTab.SetActive(false);
        arcaneSkillTab.SetActive(false);

        rageSkillTab.SetActive(true);
        actor = FindObjectOfType<Actor>();
        actor.ReturnSkills();
    }
    public void EnableArcane()
    {  
        rageSkillTab.SetActive(false);
        speedSkillTab.SetActive(false);

        arcaneSkillTab.SetActive(true);
        actor = FindObjectOfType<Actor>();
        actor.ReturnSkills();
    }
}

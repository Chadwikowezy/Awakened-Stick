using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityMenuItem : MonoBehaviour
{
    public Sprite skillIcon;
    public string skillName;
    public string skillType;
    public string castType;
    public string damage;
    public string description;

    public AbilityDescriptionWindow _descriptionWindow;

    public void UpdateAbilityDisplayWindow()
    {
        _descriptionWindow.gameObject.SetActive(true);
        _descriptionWindow.SetDisplayedMetaData(this);
    }
}

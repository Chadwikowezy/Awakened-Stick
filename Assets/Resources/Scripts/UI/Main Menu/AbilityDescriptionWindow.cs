using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityDescriptionWindow : MonoBehaviour
{
    public Image skillIcon;
    public Text skillName;
    public Text skillType;
    public Text castType;
    public Text damage;
    public Text description;

    public void SetDisplayedMetaData(AbilityMenuItem _ability)
    {
        skillIcon.sprite = _ability.skillIcon;
        skillName.text = _ability.skillName;
        skillType.text = _ability.skillType;
        castType.text = _ability.castType;
        damage.text = _ability.damage;
        description.text = _ability.description;
    }
}

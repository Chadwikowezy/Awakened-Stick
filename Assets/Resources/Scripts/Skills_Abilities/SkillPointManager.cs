using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillPointManager: MonoBehaviour
{
    public Text skillPointTabTxt;

    private int baseSkillPointValue;
    public int BaseSkillPointValue
    {
        get { return baseSkillPointValue; }
        set { baseSkillPointValue = value; }
    }

    private int currentSkillPointValue;
    public int CurrentSkillPointValue
    {
        get { return currentSkillPointValue; }
        set { currentSkillPointValue = value; }
    }

    public Text skillPointValueText;
    
    public void AlterCurrencyValue(int amount)
    {
        if(CurrentSkillPointValue >= amount)
        {
            currentSkillPointValue -= amount;
            skillPointValueText.text = currentSkillPointValue.ToString();
        }
    }

    public void UpdateSkillPointValue()
    {
        skillPointTabTxt.text = currentSkillPointValue.ToString();
    }
}

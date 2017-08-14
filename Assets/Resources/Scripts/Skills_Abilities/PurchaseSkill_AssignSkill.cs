using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseSkill_AssignSkill : MonoBehaviour
{
    public GameObject buttonAssigner;
    public int currentSkillValue;
    private SkillPointManager skillPointManager;
    private PurchaseSkill_AssignSkill[] purchaseSkill_AssignSkill;
    public GameObject skillCostText;
    public int abilityIDValue;

    private GameController gameController;

    //tier 1
    public bool piercingFistUnlocked = false;
    public bool heavensPiercerUnlocked = false;
    public bool wrathsDestructionUnlocked = false;
    public bool howlingScytheUnlocked = false;
    public bool vortexDischargeUnlocked = false;
    public bool searingIgnitionUnlocked = false;
    public bool permaFrostUnlocked = false;
    public bool spiralingTempestUnlocked = false;
    public bool piercingShotUnlocked = false;
    public bool uncontrolledSpeedUnlocked = false;
    public bool laceratingTyphoonUnlocked = false;
    public bool ascendingShotUnlocked = false;

    //tier 1
    public bool tier2PiercingFistUnlocked = false;
    public bool tier2HeavensPiercerUnlocked = false;
    public bool tier2WrathsDestructionUnlocked = false;
    public bool tier2HowlingScytheUnlocked = false;
    public bool tier2VortexDischargeUnlocked = false;
    public bool tier2SearingIgnitionUnlocked = false;
    public bool tier2PermaFrostUnlocked = false;
    public bool tier2SpiralingTempestUnlocked = false;
    public bool tier2PiercingShotUnlocked = false;
    public bool tier2UncontrolledSpeedUnlocked = false;
    public bool tier2LaceratingTyphoonUnlocked = false;
    public bool tier2AscendingShotUnlocked = false;

    public bool isUnlockedAlready = false;

    public enum skillType { piercingFist, heavensPiercer,
        wrathsDestruction, howlingScythe, vortexDischarge,
        searingIgnition, permaFrost, spiralingTempest, piercingShot,
        uncontrolledSpeed, laceratingTyphoon, ascendingShot,
        piercingFist_tier2, heavensPiercer_tier2, wrathsDestruction_tier2,
        howlingScythe_tier2, vortexDischarge_tier2,
        searingIgnition_tier2, permaFrost_tier2, spiralingTempest_tier2,
        piercingShot_tier2, uncontrolledSpeed_tier2,
        laceratingTyphoon_tier2, ascendingShot_tier2
    };

    public skillType type;

    void Start ()
    {
        buttonAssigner.SetActive(false);
    }
	
    public void UnlockSkill()
    {
        skillPointManager = FindObjectOfType<SkillPointManager>();
        if (skillPointManager.CurrentSkillPointValue >= currentSkillValue && isUnlockedAlready == false)
        {
            if (type == skillType.piercingFist || type == skillType.heavensPiercer || type == skillType.wrathsDestruction
                || type == skillType.howlingScythe || type == skillType.vortexDischarge || type == skillType.searingIgnition
                || type == skillType.permaFrost || type == skillType.spiralingTempest || type == skillType.piercingShot
                || type == skillType.uncontrolledSpeed || type == skillType.laceratingTyphoon || type == skillType.ascendingShot)
            {
                Calls();
            }
            else if (type == skillType.piercingFist_tier2 && piercingFistUnlocked == true)
            {
                Calls();
            }  
            else if (type == skillType.heavensPiercer_tier2 && heavensPiercerUnlocked == true)
            {
                Calls();
            }
            else if (type == skillType.wrathsDestruction_tier2 && wrathsDestructionUnlocked == true)
            {
                Calls();
            }
            else if (type == skillType.howlingScythe_tier2 && howlingScytheUnlocked == true)
            {
                Calls();
            }
            else if (type == skillType.vortexDischarge_tier2 && vortexDischargeUnlocked == true)
            {
                Calls();
            }
            else if (type == skillType.searingIgnition_tier2 && searingIgnitionUnlocked == true)
            {
                Calls();
            }
            else if (type == skillType.permaFrost_tier2 && permaFrostUnlocked == true)
            {
                Calls();
            }
            else if (type == skillType.spiralingTempest_tier2 && spiralingTempestUnlocked == true)
            {
                Calls();
            }
            else if (type == skillType.piercingShot_tier2 && piercingShotUnlocked == true)
            {
                Calls();
            }
            else if (type == skillType.uncontrolledSpeed_tier2 && uncontrolledSpeedUnlocked == true)
            {
                Calls();
            }
            else if (type == skillType.laceratingTyphoon_tier2 && laceratingTyphoonUnlocked == true)
            {
                Calls();
            }
            else if (type == skillType.ascendingShot_tier2 && ascendingShotUnlocked == true)
            {
                Calls();
            }
        }
        else if(isUnlockedAlready == true)
        {
            StartCoroutine(buttonAssignerDuration());
        }
    }

    void Calls()
    {
        skillPointManager.AlterCurrencyValue(currentSkillValue);
        CheckIDAssignAbility(abilityIDValue);
        ReturnSkill();
        isUnlockedAlready = true;
    }
    IEnumerator buttonAssignerDuration()
    {
        buttonAssigner.SetActive(true);
        yield return new WaitForSeconds(4f);
        buttonAssigner.SetActive(false);
    }

    public void ReturnSkill()
    {
        skillPointManager = FindObjectOfType<SkillPointManager>();
        GetComponent<Image>().color = Color.white;
        skillCostText.SetActive(false);
        skillPointManager.skillPointTabTxt.text = skillPointManager.CurrentSkillPointValue.ToString();
        StartCoroutine(buttonAssignerDuration());
    }

    #region Ability id returns proper skill unlocks
    public void CheckIDAssignAbility(int _abilityIDValue)
    {
        if(_abilityIDValue > 0 && _abilityIDValue < 13)
        {
            if (_abilityIDValue == 1)
            {
                piercingFistUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.piercingFistUnlocked = true;
                }
            }
            else if (_abilityIDValue == 2)
            {
                heavensPiercerUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.heavensPiercerUnlocked = true;
                }
            }
            else if (_abilityIDValue == 3)
            {
                wrathsDestructionUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.wrathsDestructionUnlocked = true;
                }
            }
            else if (_abilityIDValue == 4)
            {
                howlingScytheUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.howlingScytheUnlocked = true;
                }
            }
            else if (_abilityIDValue == 5)
            {
                vortexDischargeUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.vortexDischargeUnlocked = true;
                }
            }
            else if (_abilityIDValue == 6)
            {
                searingIgnitionUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.searingIgnitionUnlocked = true;
                }
            }
            else if (_abilityIDValue == 7)
            {
                permaFrostUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.permaFrostUnlocked = true;
                }
            }
            else if (_abilityIDValue == 8)
            {
                spiralingTempestUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.spiralingTempestUnlocked = true;
                }
            }
            else if (_abilityIDValue == 9)
            {
                piercingShotUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.piercingShotUnlocked = true;
                }
            }
            else if (_abilityIDValue == 10)
            {
                uncontrolledSpeedUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.uncontrolledSpeedUnlocked = true;
                }
            }
            else if (_abilityIDValue == 11)
            {
                laceratingTyphoonUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.laceratingTyphoonUnlocked = true;
                }
            }
            else if (_abilityIDValue == 12)
            {
                ascendingShotUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.ascendingShotUnlocked = true;
                }
            }
        }
        else if (_abilityIDValue > 12)
        {            
            if (_abilityIDValue == 13 && piercingFistUnlocked == true)
            {
                tier2PiercingFistUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.tier2PiercingFistUnlocked = true;
                }
            }
            else if (_abilityIDValue == 14 && heavensPiercerUnlocked == true)
            {
                tier2HeavensPiercerUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.tier2HeavensPiercerUnlocked = true;
                }
            }
            else if (_abilityIDValue == 15 && wrathsDestructionUnlocked == true)
            {
                tier2WrathsDestructionUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.tier2WrathsDestructionUnlocked = true;
                }
            }
            else if (_abilityIDValue == 16 && howlingScytheUnlocked == true)
            {
                tier2HowlingScytheUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.tier2HowlingScytheUnlocked = true;
                }
            }
            else if (_abilityIDValue == 17 && vortexDischargeUnlocked == true)
            {
                tier2VortexDischargeUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.tier2VortexDischargeUnlocked = true;
                }
            }
            else if (_abilityIDValue == 18 && searingIgnitionUnlocked == true)
            {
                tier2SearingIgnitionUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.tier2SearingIgnitionUnlocked = true;
                }
            }
            else if (_abilityIDValue == 19 && permaFrostUnlocked == true)
            {
                tier2PermaFrostUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.tier2PermaFrostUnlocked = true;
                }
            }
            else if (_abilityIDValue == 20 && spiralingTempestUnlocked == true)
            {
                tier2SpiralingTempestUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.tier2SpiralingTempestUnlocked = true;
                }
            }
            else if (_abilityIDValue == 21 && piercingShotUnlocked == true)
            {
                tier2PiercingShotUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.tier2PiercingShotUnlocked = true;
                }
            }
            else if (_abilityIDValue == 22 && uncontrolledSpeedUnlocked == true)
            {
                tier2UncontrolledSpeedUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.tier2UncontrolledSpeedUnlocked = true;
                }
            }
            else if (_abilityIDValue == 23 && laceratingTyphoonUnlocked == true)
            {
                tier2LaceratingTyphoonUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.tier2LaceratingTyphoonUnlocked = true;
                }
            }
            else if (_abilityIDValue == 24 && ascendingShotUnlocked == true)
            {
                tier2AscendingShotUnlocked = true;
                purchaseSkill_AssignSkill = FindObjectsOfType<PurchaseSkill_AssignSkill>();
                foreach (PurchaseSkill_AssignSkill skillsUnlocked in purchaseSkill_AssignSkill)
                {
                    skillsUnlocked.tier2AscendingShotUnlocked = true;
                }
            }
        }
        gameController = FindObjectOfType<GameController>();
        for (int i = 0; i < 1; i++)
        {
            gameController.Save();
        }
    }
    #endregion
}

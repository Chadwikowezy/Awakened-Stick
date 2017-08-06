using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Actor : MonoBehaviour
{
    public ActorData data;
    public InventoryDisplay inventoryDisplay;
    private GameObject player;
    private SkillPointManager skillPointManager;
    private PurchaseSkill_AssignSkill[] skillsPurchased;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        inventoryDisplay = FindObjectOfType<InventoryDisplay>();
        skillPointManager = FindObjectOfType<SkillPointManager>();
        if(transform.name == "FakeLoader(Clone)")
        {
            data.startingGameSkillPoints = 70;
            skillPointManager.CurrentSkillPointValue = data.startingGameSkillPoints;
            skillPointManager.skillPointValueText.text = skillPointManager.CurrentSkillPointValue.ToString();
        }
        else
        {
            data.startingGameSkillPoints = 0;
        }
    }

    //GameSparks Store and load data function here         
    #region StoreData to Cloud
    /*
private void GameSparksSendData()
{
    GSRequestData jsonDataToSend = new GSRequestData();
    jsonDataToSend.Add("currency", data.currency1);//do this same adding to request to store info
    jsonDataToSend.Add("health", data.healthVal);
    //info sent to cloud here
    new LogEventRequest().SetEventKey("PlayerData")
        .SetEventAttribute("jsonData", jsonDataToSend)
        .Send((response) =>
        {
            if (response.HasErrors)
            {
                Debug.Log("Response failure?");
            }
            else
            {
                Debug.Log("Success sending data to cloud");
            }
        });
}
#endregion

#region LoadData from cloud
private void GameSparksRecieveData()
{
    new GameSparks.Api.Requests.LogEventRequest().SetEventKey("PlayerData").SetEventAttribute("jsonData", "playerStats.text").Send((response) =>
    {          
        if (!response.HasErrors)
        {
            string theText = response.ScriptData.GetString("collection");
            Debug.Log("My result is: " + theText);
        }
        else
        {
            Debug.Log("Failed right away " + response.Errors);
        }
    });

}
*/
    #endregion

    #region storedata
    public void StoreData()
    {
        //store item ids
        if(inventoryDisplay != null)
        {
            foreach (InventoryItem inventoryItem in inventoryDisplay.items)
            {
                data.ids.Add(inventoryItem.itemId);
            }
            inventoryDisplay.items.Clear();
        }
        data.skillPointValue = skillPointManager.CurrentSkillPointValue;

        skillsPurchased = FindObjectsOfType<PurchaseSkill_AssignSkill>();
        foreach(PurchaseSkill_AssignSkill skillUnlocked in skillsPurchased)
        {
            //data.abilityIDS = new List<int>(23);
            if (skillUnlocked.piercingFistUnlocked == true)
            {
                data.piercingFistUnlocked = true;
            }
            if (skillUnlocked.heavensPiercerUnlocked == true)
            {
                data.heavensPiercerUnlocked = true;
            }
            if (skillUnlocked.wrathsDestructionUnlocked == true)
            {
                data.wrathsDestructionUnlocked = true;
            }
            if (skillUnlocked.howlingScytheUnlocked == true)
            {
                data.howlingScytheUnlocked = true;
            }
            if (skillUnlocked.vortexDischargeUnlocked == true)
            {
                data.vortexDischargeUnlocked = true;
            }
            if (skillUnlocked.searingIgnitionUnlocked == true)
            {
                data.searingIgnitionUnlocked = true;
            }
            if (skillUnlocked.permaFrostUnlocked == true)
            {
                data.permaFrostUnlocked = true;
            }
            if (skillUnlocked.spiralingTempestUnlocked == true)
            {
                data.spiralingTempestUnlocked = true;
            }
            if (skillUnlocked.piercingShotUnlocked == true)
            {
                data.piercingShotUnlocked = true;
            }
            if (skillUnlocked.uncontrolledSpeedUnlocked == true)
            {
                data.uncontrolledSpeedUnlocked = true;
            }
            if (skillUnlocked.laceratingTyphoonUnlocked == true)
            {
                data.laceratingTyphoonUnlocked = true;
            }
            if (skillUnlocked.ascendingShotUnlocked == true)
            {
                data.ascendingShotUnlocked = true;
            }
            if (skillUnlocked.tier2PiercingFistUnlocked == true)
            {
                data.tier2PiercingFistUnlocked = true;
            }
            if (skillUnlocked.tier2HeavensPiercerUnlocked == true)
            {
                data.tier2HeavensPiercerUnlocked = true;
            }
            if (skillUnlocked.tier2WrathsDestructionUnlocked == true)
            {
                data.tier2WrathsDestructionUnlocked = true;
            }
            if (skillUnlocked.tier2HowlingScytheUnlocked == true)
            {
                data.tier2HowlingScytheUnlocked = true;
            }
            if (skillUnlocked.tier2VortexDischargeUnlocked == true)
            {
                data.tier2VortexDischargeUnlocked = true;
            }
            if (skillUnlocked.tier2SearingIgnitionUnlocked == true)
            {
                data.tier2SearingIgnitionUnlocked = true;
            }
            if (skillUnlocked.tier2PermaFrostUnlocked == true)
            {
                data.tier2PermaFrostUnlocked = true;
            }
            if (skillUnlocked.tier2SpiralingTempestUnlocked == true)
            {
                data.tier2SpiralingTempestUnlocked = true;
            }
            if (skillUnlocked.tier2PiercingShotUnlocked == true)
            {
                data.tier2PiercingShotUnlocked = true;
            }
            if (skillUnlocked.tier2UncontrolledSpeedUnlocked == true)
            {
                data.tier2UncontrolledSpeedUnlocked = true;
            }
            if (skillUnlocked.tier2LaceratingTyphoonUnlocked == true)
            {
                data.tier2LaceratingTyphoonUnlocked = true;
            }
            if (skillUnlocked.tier2AscendingShotUnlocked == true)
            {
                data.tier2AscendingShotUnlocked = true;
            }
        }
    }
    #endregion

    #region Return abilities
    public void ReturnSkills()
    {
        skillsPurchased = FindObjectsOfType<PurchaseSkill_AssignSkill>();
        foreach (PurchaseSkill_AssignSkill skillsNeedLoading in skillsPurchased)
        {
            if (data.piercingFistUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 1)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(1);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.heavensPiercerUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 2)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(2);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.wrathsDestructionUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 3)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(3);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.howlingScytheUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 4)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(4);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.vortexDischargeUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 5)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(5);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.searingIgnitionUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 6)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(6);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.permaFrostUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 7)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(7);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.spiralingTempestUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 8)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(8);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.piercingShotUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 9)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(9);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.uncontrolledSpeedUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 10)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(10);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.laceratingTyphoonUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 11)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(11);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.ascendingShotUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 12)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(12);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.tier2PiercingFistUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 13)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(13);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.tier2HeavensPiercerUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 14)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(14);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.tier2WrathsDestructionUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 15)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(15);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.tier2HowlingScytheUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 16)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(16);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.tier2VortexDischargeUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 17)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(17);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.tier2SearingIgnitionUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 18)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(18);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.tier2PermaFrostUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 19)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(19);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.tier2SpiralingTempestUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 20)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(20);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.tier2PiercingShotUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 21)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(21);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.tier2UncontrolledSpeedUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 22)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(22);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.tier2LaceratingTyphoonUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 23)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(23);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
            if (data.tier2AscendingShotUnlocked == true)
            {
                if (skillsNeedLoading.abilityIDValue == 24)
                {
                    skillsNeedLoading.ReturnSkill();
                    skillsNeedLoading.CheckIDAssignAbility(24);
                    skillsNeedLoading.isUnlockedAlready = true;
                }
            }
        }
    }
    #endregion

    public void LoadData()
    {
        if(transform.name != "FakeLoader(Clone)")
        {
            skillPointManager = FindObjectOfType<SkillPointManager>();
            skillPointManager.CurrentSkillPointValue = data.skillPointValue;
            skillPointManager.skillPointValueText.text = skillPointManager.CurrentSkillPointValue.ToString();
        }
        ReturnSkills();
    }

    #region Applying Conditions to info store/ Load
    public void ApplyData()
    {
        SaveData.AddActorData(data);
    }
    void OnEnable()
    {
        SaveData.OnLoaded += LoadData;
        SaveData.OnBeforeSave += StoreData;
        SaveData.OnBeforeSave += ApplyData;
    }
    void OnDisable()
    {
        SaveData.OnLoaded -= LoadData;
        SaveData.OnBeforeSave -= StoreData;
        SaveData.OnBeforeSave -= ApplyData;
    }
    #endregion
}


#region ActorData Class, variables saved
[Serializable]
public class ActorData
{
    public Vector3 playerPosition;

    public List<int> ids = new List<int>();

    public int skillPointValue;

    public int startingGameSkillPoints;

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
}
#endregion
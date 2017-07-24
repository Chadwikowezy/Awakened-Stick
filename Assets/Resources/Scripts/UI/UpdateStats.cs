using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateStats : MonoBehaviour
{
    private Player player;

    //stats accumulated
    public Text lifeTxt;
    public Text damageTxt;
    public Text defenseTxt;
    //weapons values
    public Text weapLifeTxt;
    public Text weapRageTxt;
    public Text weapSpeedTxt;
    public Text weapArcaneTxt;
    //chest armor values
    public Text chestLifeTxt;
    public Text chestRageTxt;
    public Text chestSpeedTxt;
    public Text chestArcaneTxt;
    //helm armor values
    public Text helmLifeTxt;
    public Text helmRageTxt;
    public Text helmSpeedTxt;
    public Text helmArcaneTxt;
    //gloves armor values
    public Text glovesLifeTxt;
    public Text glovesRageTxt;
    public Text glovesSpeedTxt;
    public Text glovesArcaneTxt;

    public InventoryItemDisplay[] equipChecks;
    public Equip[] equipBoolChecker;

    private int weaponCounter = 0;

    public void StatUpdate()
    {
        player = FindObjectOfType<Player>();

        lifeTxt.text = "Life: " + player.CurrentMaxHealth;
        damageTxt.text = "Attack: " + player.CurrentAttack;
        defenseTxt.text = "Armor: " + player.CurrentDefense;

        equipChecks = FindObjectsOfType<InventoryItemDisplay>();
        equipBoolChecker = FindObjectsOfType<Equip>();
        foreach (InventoryItemDisplay equipped in equipChecks)
        {
            foreach(Equip equipBoolCheck in equipBoolChecker)
            {
                if (equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.itemType == Item.ItemTypes.weapon) 
                {
                    if (equipBoolCheck.equipWeapon == true && equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.itemEquipped == true)
                    {
                        weapLifeTxt.text = "Life: " + equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.lifeValue;
                        weapRageTxt.text = "Rage: " + equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.rage;
                        weapSpeedTxt.text = "Speed: " + equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.speed;
                        weapArcaneTxt.text = "Arcane: " + equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.arcane;                       
                    }
                    else if (equipBoolCheck.equipWeapon == false)
                    {
                        weapLifeTxt.text = "Life: " + 0;
                        weapRageTxt.text = "Rage: " + 0;
                        weapSpeedTxt.text = "Speed: " + 0;
                        weapArcaneTxt.text = "Arcane: " + 0;
                        
                    }

                }
                else if (equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.itemType == Item.ItemTypes.armor)
                {
                    if (equipBoolCheck.equipArmor == true && equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.itemEquipped == true)
                    {
                        chestLifeTxt.text = "Life: " + equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.lifeValue;
                        chestRageTxt.text = "Rage: " + equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.rage;
                        chestSpeedTxt.text = "Speed: " + equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.speed;
                        chestArcaneTxt.text = "Arcane: " + equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.arcane;                        
                    }
                    else if (equipBoolCheck.equipArmor == false)
                    {
                        chestLifeTxt.text = "Life: " + 0;
                        chestRageTxt.text = "Rage: " + 0;
                        chestSpeedTxt.text = "Speed: " + 0;
                        chestArcaneTxt.text = "Arcane: " + 0;
                    }
                }
                else if (equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.itemType == Item.ItemTypes.helmet)
                {
                    if (equipBoolCheck.equipHelm == true && equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.itemEquipped == true)
                    {
                        helmLifeTxt.text = "Life: " + equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.lifeValue;
                        helmRageTxt.text = "Rage: " + equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.rage;
                        helmSpeedTxt.text = "Speed: " + equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.speed;
                        helmArcaneTxt.text = "Arcane: " + equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.arcane;
                    }
                    else if (equipBoolCheck.equipHelm == false)
                    {
                        helmLifeTxt.text = "Life: " + 0;
                        helmRageTxt.text = "Rage: " + 0;
                        helmSpeedTxt.text = "Speed: " + 0;
                        helmArcaneTxt.text = "Arcane: " + 0;
                    }
                }
                else if (equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.itemType == Item.ItemTypes.gloves)
                {
                    if (equipBoolCheck.equipGloves == true && equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.itemEquipped == true)
                    {
                        glovesLifeTxt.text = "Life: " + equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.lifeValue;
                        glovesRageTxt.text = "Rage: " + equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.rage;
                        glovesSpeedTxt.text = "Speed: " + equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.speed;
                        glovesArcaneTxt.text = "Arcane: " + equipBoolCheck.GetComponentInParent<InventoryItemDisplay>().item.arcane;
                    }
                    else if (equipBoolCheck.equipGloves == false)
                    {
                        glovesLifeTxt.text = "Life: " + 0;
                        glovesRageTxt.text = "Rage: " + 0;
                        glovesSpeedTxt.text = "Speed: " + 0;
                        glovesArcaneTxt.text = "Arcane: " + 0;
                    }
                }
            }
            
        }
    }
}

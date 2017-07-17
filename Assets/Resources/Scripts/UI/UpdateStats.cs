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

    public void StatUpdate()
    {
        player = FindObjectOfType<Player>();

        lifeTxt.text = "Life: " + player.CurrentMaxHealth;
        damageTxt.text = "Attack: " + player.CurrentAttack;
        defenseTxt.text = "Armor: " + player.CurrentDefense;

        equipChecks = FindObjectsOfType<InventoryItemDisplay>();
        foreach(InventoryItemDisplay equipped in equipChecks)
        {
            if(equipped.item.itemEquipped == true)
            {
                if(equipped.GetComponent<InventoryItem>().itemType == Item.ItemTypes.weapon)
                {
                    weapLifeTxt.text = "Life: " + equipped.GetComponent<InventoryItem>().lifeValue;
                    weapRageTxt.text = "Rage: " + equipped.GetComponent<InventoryItem>().rage;
                    weapSpeedTxt.text = "Speed: " + equipped.GetComponent<InventoryItem>().speed;
                    weapArcaneTxt.text = "Arcane: " + equipped.GetComponent<InventoryItem>().arcane;
                }               
                else if (equipped.GetComponent<InventoryItem>().itemType == Item.ItemTypes.armor)
                {
                    chestLifeTxt.text = "Life: " + equipped.GetComponent<InventoryItem>().lifeValue;
                    chestRageTxt.text = "Rage: " + equipped.GetComponent<InventoryItem>().rage;
                    chestSpeedTxt.text = "Speed: " + equipped.GetComponent<InventoryItem>().speed;
                    chestArcaneTxt.text = "Arcane: " + equipped.GetComponent<InventoryItem>().arcane;
                }
                else if (equipped.GetComponent<InventoryItem>().itemType == Item.ItemTypes.helmet)
                {
                    helmLifeTxt.text = "Life: " + equipped.GetComponent<InventoryItem>().lifeValue;
                    helmRageTxt.text = "Rage: " + equipped.GetComponent<InventoryItem>().rage;
                    helmSpeedTxt.text = "Speed: " + equipped.GetComponent<InventoryItem>().speed;
                    helmArcaneTxt.text = "Arcane: " + equipped.GetComponent<InventoryItem>().arcane;
                }
                else if (equipped.GetComponent<InventoryItem>().itemType == Item.ItemTypes.gloves)
                {
                    glovesLifeTxt.text = "Life: " + equipped.GetComponent<InventoryItem>().lifeValue;
                    glovesRageTxt.text = "Rage: " + equipped.GetComponent<InventoryItem>().rage;
                    glovesSpeedTxt.text = "Speed: " + equipped.GetComponent<InventoryItem>().speed;
                    glovesArcaneTxt.text = "Arcane: " + equipped.GetComponent<InventoryItem>().arcane;
                }
            }
            else if (equipped.item.itemEquipped == false)
            {
                if (equipped.GetComponent<InventoryItem>().itemType == Item.ItemTypes.weapon)
                {
                    weapLifeTxt.text = "Life: " + 0;
                    weapRageTxt.text = "Rage: " + 0;
                    weapSpeedTxt.text = "Speed: " + 0;
                    weapArcaneTxt.text = "Arcane: " + 0;
                }
                else if (equipped.GetComponent<InventoryItem>().itemType == Item.ItemTypes.armor)
                {
                    chestLifeTxt.text = "Life: " + 0;
                    chestRageTxt.text = "Rage: " + 0;
                    chestSpeedTxt.text = "Speed: " + 0;
                    chestArcaneTxt.text = "Arcane: " + 0;
                }
                else if (equipped.GetComponent<InventoryItem>().itemType == Item.ItemTypes.helmet)
                {
                    helmLifeTxt.text = "Life: " + 0;
                    helmRageTxt.text = "Rage: " + 0;
                    helmSpeedTxt.text = "Speed: " + 0;
                    helmArcaneTxt.text = "Arcane: " + 0;
                }
                else if (equipped.GetComponent<InventoryItem>().itemType == Item.ItemTypes.gloves)
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

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Equip : MonoBehaviour
{
    #region variables
    private Image itemSpriteColorSwitch;
    private Player player;
    private InventoryItemDisplay inventoryItemDisplay;

    public bool equipHelm;
    public bool equipArmor;
    public bool equipWeapon;
    public bool equipGloves;

    public bool itemIsEquipped;
    public Equip[] items;
    public Equip[] equipCheckItems;
    
    //need to add in all sprites correlated to appropriate item  
    #endregion

    void Start ()
    {
        itemSpriteColorSwitch = GetComponent<Image>();
        player = FindObjectOfType<Player>();
        inventoryItemDisplay = GetComponentInParent<InventoryItemDisplay>();
        items = FindObjectsOfType<Equip>();
        equipHelm = false;
        equipArmor = false;
        equipWeapon = false;
        equipGloves = false;
    }

    #region Equip and Unequip items
    public void Equip_Unequip()
    {
        items = FindObjectsOfType<Equip>();
        //equipCheckItems = FindObjectsOfType<Equip>();

        foreach(Equip item in items)
        {
            if(item.equipArmor == true)
            {
                equipArmor = true;
            }
            if (item.equipHelm == true)
            {
                equipHelm = true;
            }
            if (item.equipGloves == true)
            {
                equipGloves = true;
            }
            if (item.equipWeapon == true)
            {
                equipWeapon = true;
            }
        }

        if (equipArmor == false && itemIsEquipped == false && inventoryItemDisplay.item.itemType == Item.ItemTypes.armor)
        {
            HandleItemAddingData(player, inventoryItemDisplay);
            itemIsEquipped = true;
            equipArmor = true;
            inventoryItemDisplay.item.itemEquipped = true;

            foreach (Equip item in items)
            {
                item.equipArmor = true;
            }
            foreach (Equip check in equipCheckItems)
            {
                check.itemIsEquipped = true;
            }           
        }
        else if(equipArmor == true && itemIsEquipped == true && inventoryItemDisplay.item.itemType == Item.ItemTypes.armor)
        {
            HandleItemSubtractingData(player, inventoryItemDisplay);
            itemIsEquipped = false;
            equipArmor = false;
            inventoryItemDisplay.item.itemEquipped = false;

            foreach (Equip item in items)
            {
                item.equipArmor = false;
            }
            foreach (Equip check in equipCheckItems)
            {
                check.itemIsEquipped = false;
            }
        }
        else if (equipHelm == false && itemIsEquipped == false && inventoryItemDisplay.item.itemType == Item.ItemTypes.helmet)
        {
            HandleItemAddingData(player, inventoryItemDisplay);
            itemIsEquipped = true;
            equipHelm = true;
            inventoryItemDisplay.item.itemEquipped = true;

            foreach (Equip item in items)
            {
                item.equipHelm = true;
            }
            foreach (Equip check in equipCheckItems)
            {
                check.itemIsEquipped = true;
            }
        }
        else if (equipHelm == true && itemIsEquipped == true && inventoryItemDisplay.item.itemType == Item.ItemTypes.helmet)
        {
            HandleItemSubtractingData(player, inventoryItemDisplay);
            itemIsEquipped = false;
            equipHelm = false;
            inventoryItemDisplay.item.itemEquipped = false;

            foreach (Equip item in items)
            {
                item.equipHelm = false;
            }
            foreach (Equip check in equipCheckItems)
            {
                check.itemIsEquipped = false;
            }
        }
        else if (equipGloves == false && itemIsEquipped == false && inventoryItemDisplay.item.itemType == Item.ItemTypes.gloves)
        {
            HandleItemAddingData(player, inventoryItemDisplay);
            itemIsEquipped = true;
            equipGloves = true;
            inventoryItemDisplay.item.itemEquipped = true;

            foreach (Equip item in items)
            {
                item.equipGloves = true;
            }
            foreach (Equip check in equipCheckItems)
            {
                check.itemIsEquipped = true;
            }
        }
        else if (equipGloves == true && itemIsEquipped == true && inventoryItemDisplay.item.itemType == Item.ItemTypes.gloves)
        {
            HandleItemSubtractingData(player, inventoryItemDisplay);
            itemIsEquipped = false;
            equipGloves = false;
            inventoryItemDisplay.item.itemEquipped = false;

            foreach (Equip item in items)
            {
                item.equipGloves = false;
            }
            foreach (Equip check in equipCheckItems)
            {
                check.itemIsEquipped = false;
            }           
        }
        else if (equipWeapon == false && itemIsEquipped == false && inventoryItemDisplay.item.itemType == Item.ItemTypes.weapon)
        {
            HandleItemAddingData(player, inventoryItemDisplay);
            itemIsEquipped = true;
            equipWeapon = true;
            inventoryItemDisplay.item.itemEquipped = true;

            foreach (Equip item in items)
            {
                item.equipWeapon = true;
            }
            foreach (Equip check in equipCheckItems)
            {
                check.itemIsEquipped = true;
            }
        }
        else if (equipWeapon == true && itemIsEquipped == true && inventoryItemDisplay.item.itemType == Item.ItemTypes.weapon)
        {
            HandleItemSubtractingData(player, inventoryItemDisplay);
            itemIsEquipped = false;
            equipWeapon = false;
            inventoryItemDisplay.item.itemEquipped = false;

            foreach (Equip item in items)
            {
                item.equipWeapon = false;
            }
            foreach (Equip check in equipCheckItems)
            {
                check.itemIsEquipped = false;
            }          
        }
    }
    #endregion

    #region handle add and subtraction of data functions
    void HandleItemAddingData(Player player, InventoryItemDisplay inventoryItemDisplay)
    {
        player.CurrentMaxHealth += inventoryItemDisplay.item.lifeValue;
        HandleCanvas handleCanvas = FindObjectOfType<HandleCanvas>();
        if (handleCanvas.canAlterStats == true)
        {
            player.CurrentHealth += inventoryItemDisplay.item.lifeValue;
        }
        player.CurrentRage += inventoryItemDisplay.item.rage;
        player.CurrentSpeed += inventoryItemDisplay.item.speed;
        player.CurrentArcane += inventoryItemDisplay.item.arcane;

        player.CurrentAttack += (inventoryItemDisplay.item.rage +
            inventoryItemDisplay.item.arcane + inventoryItemDisplay.item.speed);
        if(player.CurrentMaxHealth < 90)
        {
            player.CurrentDefense = 0;
        }
        else if (player.CurrentMaxHealth >= 90 && player.CurrentMaxHealth < 116)
        {
            player.CurrentDefense = 1;
        }
        else if (player.CurrentMaxHealth >= 116)
        {
            player.CurrentDefense = 2;
        }

        itemSpriteColorSwitch.color = Color.red;

        player.healthBar.value = (float)((float)player.CurrentHealth / (float)player.CurrentMaxHealth);
        player.currentHealthText.text = player.CurrentHealth + "/" + player.CurrentMaxHealth;
    }
    void HandleItemSubtractingData(Player player, InventoryItemDisplay inventoryItemDisplay)
    {
        player.CurrentMaxHealth -= inventoryItemDisplay.item.lifeValue;
        if (player.CurrentHealth > player.CurrentMaxHealth)
        {
            player.CurrentHealth -= inventoryItemDisplay.item.lifeValue;
        }
        player.CurrentRage -= inventoryItemDisplay.item.rage;
        player.CurrentSpeed -= inventoryItemDisplay.item.speed;
        player.CurrentArcane -= inventoryItemDisplay.item.arcane;

        player.CurrentAttack -= (inventoryItemDisplay.item.rage +
            inventoryItemDisplay.item.arcane + inventoryItemDisplay.item.speed);
        if (player.CurrentMaxHealth < 90)
        {
            player.CurrentDefense = 0;
        }
        else if (player.CurrentMaxHealth >= 90 && player.CurrentMaxHealth < 116)
        {
            player.CurrentDefense = 1;
        }
        else if (player.CurrentMaxHealth >= 116)
        {
            player.CurrentDefense = 2;
        }

        itemSpriteColorSwitch.color = Color.white;

        player.healthBar.value = (float)((float)player.CurrentHealth / (float)player.CurrentMaxHealth);
        player.currentHealthText.text = player.CurrentHealth + "/" + player.CurrentMaxHealth;
    }
    #endregion
}

using System.Collections;
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
	}

    #region Equip and Unequip items
    public void Equip_Unequip()
    {
        if(equipArmor == false && itemIsEquipped == false && inventoryItemDisplay.item.itemType == Item.ItemTypes.armor)
        {
            HandleItemAddingData(player, inventoryItemDisplay);
            itemIsEquipped = true;
            equipArmor = true;

            foreach (Equip item in items)
            {
                item.equipArmor = true;
            }
            foreach (Equip check in equipCheckItems)
            {
                check.itemIsEquipped = true;
            }
            Debug.Log("At end of equip call: " + player.CurrentHealth +
                " : " + player.CurrentAttack + " : " + player.CurrentDefense);
        }
        else if(equipArmor == true && itemIsEquipped == true && inventoryItemDisplay.item.itemType == Item.ItemTypes.armor)
        {
            HandleItemSubtractingData(player, inventoryItemDisplay);
            itemIsEquipped = false;
            equipArmor = false;

            foreach (Equip item in items)
            {
                item.equipArmor = false;
            }
            foreach (Equip check in equipCheckItems)
            {
                check.itemIsEquipped = false;
            }
            Debug.Log("At end of unequip call: " + player.CurrentHealth +
                " : " + player.CurrentAttack + " : " + player.CurrentDefense);
        }
        else if (equipHelm == false && itemIsEquipped == false && inventoryItemDisplay.item.itemType == Item.ItemTypes.helmet)
        {
            HandleItemAddingData(player, inventoryItemDisplay);
            itemIsEquipped = true;
            equipHelm = true;

            foreach (Equip item in items)
            {
                item.equipHelm = true;
            }
            foreach (Equip check in equipCheckItems)
            {
                check.itemIsEquipped = true;
            }
            Debug.Log("At end of equip call: " + player.CurrentHealth +
                " : " + player.CurrentAttack + " : " + player.CurrentDefense);
        }
        else if (equipHelm == true && itemIsEquipped == true && inventoryItemDisplay.item.itemType == Item.ItemTypes.helmet)
        {
            HandleItemSubtractingData(player, inventoryItemDisplay);
            itemIsEquipped = false;
            equipHelm = false;

            foreach (Equip item in items)
            {
                item.equipHelm = false;
            }
            foreach (Equip check in equipCheckItems)
            {
                check.itemIsEquipped = false;
            }
            Debug.Log("At end of unequip call: " + player.CurrentHealth +
                " : " + player.CurrentAttack + " : " + player.CurrentDefense);
        }
        else if (equipGloves == false && itemIsEquipped == false && inventoryItemDisplay.item.itemType == Item.ItemTypes.gloves)
        {
            HandleItemAddingData(player, inventoryItemDisplay);
            itemIsEquipped = true;
            equipGloves = true;

            foreach (Equip item in items)
            {
                item.equipGloves = true;
            }
            foreach (Equip check in equipCheckItems)
            {
                check.itemIsEquipped = true;
            }
            Debug.Log("At end of equip call: " + player.CurrentHealth +
                " : " + player.CurrentAttack + " : " + player.CurrentDefense);
        }
        else if (equipGloves == true && itemIsEquipped == true && inventoryItemDisplay.item.itemType == Item.ItemTypes.gloves)
        {
            HandleItemSubtractingData(player, inventoryItemDisplay);
            itemIsEquipped = false;
            equipGloves = false;

            foreach (Equip item in items)
            {
                item.equipGloves = false;
            }
            foreach (Equip check in equipCheckItems)
            {
                check.itemIsEquipped = false;
            }
            Debug.Log("At end of unequip call: " + player.CurrentHealth + 
                " : " + player.CurrentAttack + " : " + player.CurrentDefense);
        }
        else if (equipWeapon == false && itemIsEquipped == false && inventoryItemDisplay.item.itemType == Item.ItemTypes.weapon)
        {
            HandleItemAddingData(player, inventoryItemDisplay);
            itemIsEquipped = true;
            equipWeapon = true;

            foreach (Equip item in items)
            {
                item.equipWeapon = true;
            }
            foreach (Equip check in equipCheckItems)
            {
                check.itemIsEquipped = true;
            }
            Debug.Log("At end of equip call: " + player.CurrentHealth +
                " : " + player.CurrentAttack + " : " + player.CurrentDefense);
        }
        else if (equipWeapon == true && itemIsEquipped == true && inventoryItemDisplay.item.itemType == Item.ItemTypes.weapon)
        {
            HandleItemSubtractingData(player, inventoryItemDisplay);
            itemIsEquipped = false;
            equipWeapon = false;

            foreach (Equip item in items)
            {
                item.equipWeapon = false;
            }
            foreach (Equip check in equipCheckItems)
            {
                check.itemIsEquipped = false;
            }
            Debug.Log("At end of unequip call: " + player.CurrentHealth +
                " : " + player.CurrentAttack + " : " + player.CurrentDefense);
        }
    }
    #endregion

    #region handle add and subtraction of data functions
    void HandleItemAddingData(Player player, InventoryItemDisplay inventoryItemDisplay)
    {
        player.CurrentHealth += inventoryItemDisplay.item.lifeValue;
        player.CurrentAttack += (inventoryItemDisplay.item.rage +
            inventoryItemDisplay.item.arcane + inventoryItemDisplay.item.speed);

        player.CurrentDefense += (inventoryItemDisplay.item.lifeValue / 2);

        itemSpriteColorSwitch.color = Color.red;
    }
    void HandleItemSubtractingData(Player player, InventoryItemDisplay inventoryItemDisplay)
    {
        player.CurrentHealth -= inventoryItemDisplay.item.lifeValue;
        player.CurrentAttack -= (inventoryItemDisplay.item.rage +
            inventoryItemDisplay.item.arcane + inventoryItemDisplay.item.speed);

        player.CurrentDefense -= (inventoryItemDisplay.item.lifeValue / 2);

        itemSpriteColorSwitch.color = Color.white;
    }
    #endregion
}

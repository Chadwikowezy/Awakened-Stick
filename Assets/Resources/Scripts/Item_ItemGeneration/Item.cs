using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour 
{
    #region variables
    public enum ItemTypes { defaultSetting, weapon, armor, helmet, gloves };
    public ItemTypes itemType = ItemTypes.defaultSetting;

    public enum WeaponType { defaultSetting, blades_Bow, twoHandedWeapon, magicSphere };
    public WeaponType weaponType;
    
    public enum ItemRaritys { defaultRarity, common, uncommon, rare, legendary, artifact };
    public ItemRaritys itemRarity = ItemRaritys.defaultRarity;
    
    public int itemId;
    
    public string itemName = string.Empty;

    [Multiline]
    public string itemDesc = string.Empty;

    public int itemLvl = 0;

    public int rage = 0;

    public int speed = 0;

    public int arcane = 0;

    public int lifeValue;

    public int tokens;

    public Sprite itemSprite;
    #endregion       
}

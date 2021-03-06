﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentMenuInventory : MonoBehaviour
{
    public List<int> itemIds = new List<int>();

    public List<Item> allItems = new List<Item>();

    //armor
    public List<Item> helmetItems = new List<Item>();
    public List<Item> armorItems = new List<Item>();
    public List<Item> gloveItems = new List<Item>();

    //weapons
    public List<Item> bladesBowItems = new List<Item>();
    public List<Item> twoHandedItems = new List<Item>();
    public List<Item> magicSphereItems = new List<Item>();

    private Actor currentActor;

    private void Update()
    {
        if (currentActor == null)
        {
            currentActor = FindObjectOfType<Actor>();

            if (currentActor != null)
            {
                itemIds = currentActor.data.ids;
                GenerateItemsList();
            }
        }
    }

    void GenerateItemsList()
    {
        for (int i = 0; i < itemIds.Count; i++)
        {
            Item createdItem = CreateItem(itemIds[i]);

            allItems.Add(gameObject.AddComponent<Item>());

            allItems[i].itemName = createdItem.itemName;
            allItems[i].itemType = createdItem.itemType;
            allItems[i].weaponType = createdItem.weaponType;
            allItems[i].itemRarity = createdItem.itemRarity;
            allItems[i].itemDesc = createdItem.itemDesc;
            allItems[i].rage = createdItem.rage;
            allItems[i].arcane = createdItem.arcane;
            allItems[i].speed = createdItem.speed;
            allItems[i].lifeValue = createdItem.lifeValue;
            allItems[i].skillPointValue = createdItem.skillPointValue;
        }

        SortItems();
    }
    void SortItems()
    {
        for (int i = 0; i < allItems.Count; i++)
        {
            if (allItems[i].itemType == Item.ItemTypes.helmet)
                helmetItems.Add(allItems[i]);
            else if (allItems[i].itemType == Item.ItemTypes.armor)
                armorItems.Add(allItems[i]);
            else if (allItems[i].itemType == Item.ItemTypes.gloves)
                gloveItems.Add(allItems[i]);
            else if (allItems[i].itemType == Item.ItemTypes.weapon)
            {
                if (allItems[i].weaponType == Item.WeaponType.blades_Bow)
                    bladesBowItems.Add(allItems[i]);
                else if (allItems[i].weaponType == Item.WeaponType.twoHandedWeapon)
                    twoHandedItems.Add(allItems[i]);
                else if (allItems[i].weaponType == Item.WeaponType.magicSphere)
                    magicSphereItems.Add(allItems[i]);
            }
        }
    }

    Item CreateItem(int _itemId)
    {
        Item generatedItem = new Item();

        generatedItem.itemId = _itemId;

        if (generatedItem.itemId == 1)
        {
            generatedItem.itemName = "Swift & Flight";
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.weaponType = Item.WeaponType.blades_Bow;
            generatedItem.itemRarity = Item.ItemRaritys.common;
            generatedItem.itemDesc = "Speeds unmatched, may you take flight.";
            generatedItem.rage = 0;
            generatedItem.arcane = 0;
            generatedItem.speed = 2;
            generatedItem.lifeValue = 3;
            generatedItem.skillPointValue = 1;
        }
        else if (generatedItem.itemId == 2)
        {
            generatedItem.itemName = "Blade of Envy";
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.weaponType = Item.WeaponType.twoHandedWeapon;
            generatedItem.itemRarity = Item.ItemRaritys.common;
            generatedItem.itemDesc = "A blade, who's tale is filled with sorrow.";
            generatedItem.rage = 1;
            generatedItem.arcane = 0;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 4;
            generatedItem.skillPointValue = 1;
        }
        else if (generatedItem.itemId == 3)
        {
            generatedItem.itemName = "Arcane Brilliance";
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.weaponType = Item.WeaponType.magicSphere;
            generatedItem.itemRarity = Item.ItemRaritys.common;
            generatedItem.itemDesc = "The pulsating energy is overwhelming!";
            generatedItem.rage = 0;
            generatedItem.arcane = 3;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 2;
            generatedItem.skillPointValue = 1;
        }
        else if (generatedItem.itemId == 4)
        {
            generatedItem.itemName = "Armor of Greed";
            generatedItem.itemType = Item.ItemTypes.armor;
            generatedItem.itemRarity = Item.ItemRaritys.common;
            generatedItem.itemDesc = "Gathers all stats unto itself.";
            generatedItem.rage = 2;
            generatedItem.arcane = 2;
            generatedItem.speed = 2;
            generatedItem.lifeValue = 2;
            generatedItem.skillPointValue = 1;
        }
        else if (generatedItem.itemId == 5)
        {
            generatedItem.itemName = "Helmet of Greed";
            generatedItem.itemType = Item.ItemTypes.helmet;
            generatedItem.itemRarity = Item.ItemRaritys.common;
            generatedItem.itemDesc = "Gathers all stats unto itself.";
            generatedItem.rage = 2;
            generatedItem.arcane = 2;
            generatedItem.speed = 2;
            generatedItem.lifeValue = 2;
            generatedItem.skillPointValue = 1;
        }
        else if (generatedItem.itemId == 6)
        {
            generatedItem.itemName = "Gloves of Greed";
            generatedItem.itemType = Item.ItemTypes.gloves;
            generatedItem.itemRarity = Item.ItemRaritys.common;
            generatedItem.itemDesc = "Gathers all stats unto itself.";
            generatedItem.rage = 2;
            generatedItem.arcane = 2;
            generatedItem.speed = 2;
            generatedItem.lifeValue = 2;
            generatedItem.skillPointValue = 1;
        }
        else if (generatedItem.itemId == 7)
        {
            generatedItem.itemName = "Pestilence & Famine";
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.weaponType = Item.WeaponType.blades_Bow;
            generatedItem.itemRarity = Item.ItemRaritys.uncommon;
            generatedItem.itemDesc = "Horror unmatched.";
            generatedItem.rage = 0;
            generatedItem.arcane = 0;
            generatedItem.speed = 5;
            generatedItem.lifeValue = 5;
            generatedItem.skillPointValue = 2;
        }
        else if (generatedItem.itemId == 8)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "Destroyer of Armies";
            generatedItem.weaponType = Item.WeaponType.twoHandedWeapon;
            generatedItem.itemRarity = Item.ItemRaritys.uncommon;
            generatedItem.itemDesc = "Can grasp victory, over even the greatest of odds.";
            generatedItem.rage = 4;
            generatedItem.arcane = 0;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 6;
            generatedItem.skillPointValue = 2;
        }
        else if (generatedItem.itemId == 9)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "Perpetual Banish";
            generatedItem.weaponType = Item.WeaponType.magicSphere;
            generatedItem.itemRarity = Item.ItemRaritys.uncommon;
            generatedItem.itemDesc = "Removes all before it.";
            generatedItem.rage = 0;
            generatedItem.arcane = 6;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 4;
            generatedItem.skillPointValue = 2;
        }
        else if (generatedItem.itemId == 10)
        {
            generatedItem.itemName = "Armor of Persistent Speed";
            generatedItem.itemType = Item.ItemTypes.armor;
            generatedItem.itemRarity = Item.ItemRaritys.uncommon;
            generatedItem.itemDesc = "Raises one's speed to another level.";
            generatedItem.rage = 0;
            generatedItem.arcane = 0;
            generatedItem.speed = 10;
            generatedItem.lifeValue = 6;
            generatedItem.skillPointValue = 2;
        }
        else if (generatedItem.itemId == 11)
        {
            generatedItem.itemName = "Helmet of Persistence Arcane";
            generatedItem.itemType = Item.ItemTypes.helmet;
            generatedItem.itemRarity = Item.ItemRaritys.uncommon;
            generatedItem.itemDesc = "Raises one's arcane to another level.";
            generatedItem.rage = 0;
            generatedItem.arcane = 12;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 4;
            generatedItem.skillPointValue = 2;
        }
        else if (generatedItem.itemId == 12)
        {
            generatedItem.itemName = "Gloves of Persistant Rage";
            generatedItem.itemType = Item.ItemTypes.gloves;
            generatedItem.itemRarity = Item.ItemRaritys.uncommon;
            generatedItem.itemDesc = "Raises one's rage to another level.";
            generatedItem.rage = 8;
            generatedItem.arcane = 0;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 8;
            generatedItem.skillPointValue = 2;
        }
        else if (generatedItem.itemId == 13)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "Respiration & Resiliance";
            generatedItem.weaponType = Item.WeaponType.blades_Bow;
            generatedItem.itemRarity = Item.ItemRaritys.rare;
            generatedItem.itemDesc = "That which perseveres.";
            generatedItem.rage = 0;
            generatedItem.arcane = 0;
            generatedItem.speed = 9;
            generatedItem.lifeValue = 6;
            generatedItem.skillPointValue = 4;
        }
        else if (generatedItem.itemId == 14)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "Slayer of Devils";
            generatedItem.weaponType = Item.WeaponType.twoHandedWeapon;
            generatedItem.itemRarity = Item.ItemRaritys.rare;
            generatedItem.itemDesc = "Fears not the darkest of evils.";
            generatedItem.rage = 6;
            generatedItem.arcane = 0;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 9;
            generatedItem.skillPointValue = 4;
        }
        else if (generatedItem.itemId == 15)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "Greed's Spawn";
            generatedItem.weaponType = Item.WeaponType.magicSphere;
            generatedItem.itemRarity = Item.ItemRaritys.rare;
            generatedItem.itemDesc = "Crave all things, the sin compels it.";
            generatedItem.rage = 0;
            generatedItem.arcane = 10;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 5;
            generatedItem.skillPointValue = 4;
        }
        else if (generatedItem.itemId == 16)
        {
            generatedItem.itemName = "Armor of Resiliant Rage";
            generatedItem.itemType = Item.ItemTypes.armor;
            generatedItem.itemRarity = Item.ItemRaritys.rare;
            generatedItem.itemDesc = "Focuses on resistence, while also providing rage.";
            generatedItem.rage = 8;
            generatedItem.arcane = 0;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 16;
            generatedItem.skillPointValue = 4;
        }
        else if (generatedItem.itemId == 17)
        {
            generatedItem.itemName = "Helmet of Resiliant Speed";
            generatedItem.itemType = Item.ItemTypes.helmet;
            generatedItem.itemRarity = Item.ItemRaritys.rare;
            generatedItem.itemDesc = "Focuses on resistence, while also providing speed.";
            generatedItem.rage = 0;
            generatedItem.arcane = 0;
            generatedItem.speed = 12;
            generatedItem.lifeValue = 12;
            generatedItem.skillPointValue = 4;
        }
        else if (generatedItem.itemId == 18)
        {
            generatedItem.itemName = "Gloves of Resiliant Arcane";
            generatedItem.itemType = Item.ItemTypes.gloves;
            generatedItem.itemRarity = Item.ItemRaritys.rare;
            generatedItem.itemDesc = "Focuses on resistence, while also providing arcane.";
            generatedItem.rage = 0;
            generatedItem.arcane = 16;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 8;
            generatedItem.skillPointValue = 4;
        }
        else if (generatedItem.itemId == 19)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "Light & Dark";
            generatedItem.weaponType = Item.WeaponType.blades_Bow;
            generatedItem.itemRarity = Item.ItemRaritys.legendary;
            generatedItem.itemDesc = "The Balance between all things.";
            generatedItem.rage = 0;
            generatedItem.arcane = 0;
            generatedItem.speed = 15;
            generatedItem.lifeValue = 5;
            generatedItem.skillPointValue = 8;
        }
        else if (generatedItem.itemId == 20)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "GodSlayer";
            generatedItem.weaponType = Item.WeaponType.twoHandedWeapon;
            generatedItem.itemRarity = Item.ItemRaritys.legendary;
            generatedItem.itemDesc = "All myths were born from a grain of truth.";
            generatedItem.rage = 10;
            generatedItem.arcane = 0;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 10;
            generatedItem.skillPointValue = 8;
        }
        else if (generatedItem.itemId == 21)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "Spawn of Hope";
            generatedItem.weaponType = Item.WeaponType.magicSphere;
            generatedItem.itemRarity = Item.ItemRaritys.legendary;
            generatedItem.itemDesc = "The offspring of the one thing, we won't ever lose.";
            generatedItem.rage = 0;
            generatedItem.arcane = 20;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 0;
            generatedItem.skillPointValue = 8;
        }
        else if (generatedItem.itemId == 22)
        {
            generatedItem.itemName = "Armor of Unlimited Arcane";
            generatedItem.itemType = Item.ItemTypes.armor;
            generatedItem.itemRarity = Item.ItemRaritys.legendary;
            generatedItem.itemDesc = "Overflowing amounts of arcane.";
            generatedItem.rage = 0;
            generatedItem.arcane = 24;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 8;
            generatedItem.skillPointValue = 8;
        }
        else if (generatedItem.itemId == 23)
        {
            generatedItem.itemName = "Helmet of Unlimited Rage";
            generatedItem.itemType = Item.ItemTypes.helmet;
            generatedItem.itemRarity = Item.ItemRaritys.legendary;
            generatedItem.itemDesc = "Overflowing amounts of rage.";
            generatedItem.rage = 16;
            generatedItem.arcane = 0;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 16;
            generatedItem.skillPointValue = 8;
        }
        else if (generatedItem.itemId == 24)
        {
            generatedItem.itemName = "Gloves of Unlimited Speed";
            generatedItem.itemType = Item.ItemTypes.gloves;
            generatedItem.itemRarity = Item.ItemRaritys.legendary;
            generatedItem.itemDesc = "Overflowing amounts of speed.";
            generatedItem.rage = 0;
            generatedItem.arcane = 0;
            generatedItem.speed = 20;
            generatedItem.lifeValue = 12;
            generatedItem.skillPointValue = 8;
        }
        else if (generatedItem.itemId == 25)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "Hope & Fear";
            generatedItem.weaponType = Item.WeaponType.blades_Bow;
            generatedItem.itemRarity = Item.ItemRaritys.artifact;
            generatedItem.itemDesc = "The two strongest of emotions, side by side.";
            generatedItem.rage = 0;
            generatedItem.arcane = 0;
            generatedItem.speed = 25;
            generatedItem.lifeValue = 15;
            generatedItem.skillPointValue = 16;
        }
        else if (generatedItem.itemId == 26)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "Fate Breaker";
            generatedItem.weaponType = Item.WeaponType.twoHandedWeapon;
            generatedItem.itemRarity = Item.ItemRaritys.artifact;
            generatedItem.itemDesc = "Will you choose to break fate?";
            generatedItem.rage = 20;
            generatedItem.arcane = 0;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 20;
            generatedItem.skillPointValue = 16;
        }
        else if (generatedItem.itemId == 27)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "Hope's Resolve";
            generatedItem.weaponType = Item.WeaponType.magicSphere;
            generatedItem.itemRarity = Item.ItemRaritys.artifact;
            generatedItem.itemDesc = "The strongest of resolves, held throughout time.";
            generatedItem.rage = 0;
            generatedItem.arcane = 30;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 10;
            generatedItem.skillPointValue = 16;
        }

        return generatedItem;
    }
}

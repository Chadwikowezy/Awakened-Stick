using System.Collections;
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
            generatedItem.speed = 4;
            generatedItem.lifeValue = 10;
            generatedItem.skillPointValue = 1;
        }
        else if (generatedItem.itemId == 2)
        {
            generatedItem.itemName = "Blade of Envy";
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.weaponType = Item.WeaponType.twoHandedWeapon;
            generatedItem.itemRarity = Item.ItemRaritys.common;
            generatedItem.itemDesc = "A blade who's tale is nothing but sorrowful.";
            generatedItem.rage = 3;
            generatedItem.arcane = 0;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 12;
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
            generatedItem.arcane = 5;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 8;
            generatedItem.skillPointValue = 1;
        }
        else if (generatedItem.itemId == 4)
        {
            generatedItem.itemName = "Armor of Greed";
            generatedItem.itemType = Item.ItemTypes.armor;
            generatedItem.itemRarity = Item.ItemRaritys.common;
            generatedItem.itemDesc = "Focuses on obtaining all.";
            generatedItem.rage = 5;
            generatedItem.arcane = 5;
            generatedItem.speed = 5;
            generatedItem.lifeValue = 15;
            generatedItem.skillPointValue = 1;
        }
        else if (generatedItem.itemId == 5)
        {
            generatedItem.itemName = "Helmet of Greed";
            generatedItem.itemType = Item.ItemTypes.helmet;
            generatedItem.itemRarity = Item.ItemRaritys.common;
            generatedItem.itemDesc = "Helmet that made to fill any roles.";
            generatedItem.rage = 5;
            generatedItem.arcane = 5;
            generatedItem.speed = 5;
            generatedItem.lifeValue = 15;
            generatedItem.skillPointValue = 1;
        }
        else if (generatedItem.itemId == 6)
        {
            generatedItem.itemName = "Gloves of Greed";
            generatedItem.itemType = Item.ItemTypes.gloves;
            generatedItem.itemRarity = Item.ItemRaritys.common;
            generatedItem.itemDesc = "Both hands, made to take everything.";
            generatedItem.rage = 5;
            generatedItem.arcane = 5;
            generatedItem.speed = 5;
            generatedItem.lifeValue = 15;
            generatedItem.skillPointValue = 1;
        }
        else if (generatedItem.itemId == 7)
        {
            generatedItem.itemName = "Pestilence & Famine";
            generatedItem.weaponType = Item.WeaponType.blades_Bow;
            generatedItem.itemRarity = Item.ItemRaritys.uncommon;
            generatedItem.itemDesc = "No more horror was brought, but by these blades.";
            generatedItem.rage = 0;
            generatedItem.arcane = 0;
            generatedItem.speed = 10;
            generatedItem.lifeValue = 18;
            generatedItem.skillPointValue = 2;
        }
        else if (generatedItem.itemId == 8)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "Destroyer of Armies";
            generatedItem.weaponType = Item.WeaponType.twoHandedWeapon;
            generatedItem.itemRarity = Item.ItemRaritys.uncommon;
            generatedItem.itemDesc = "Destroys everything, even in the face of countless foes.";
            generatedItem.rage = 8;
            generatedItem.arcane = 0;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 20;
            generatedItem.skillPointValue = 2;
        }
        else if (generatedItem.itemId == 9)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "Perpetual Banish";
            generatedItem.weaponType = Item.WeaponType.magicSphere;
            generatedItem.itemRarity = Item.ItemRaritys.uncommon;
            generatedItem.itemDesc = "A powerful object of unending removal.";
            generatedItem.rage = 0;
            generatedItem.arcane = 12;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 16;
            generatedItem.skillPointValue = 2;
        }
        else if (generatedItem.itemId == 10)
        {
            generatedItem.itemName = "Armor of Persistent Speed";
            generatedItem.itemType = Item.ItemTypes.armor;
            generatedItem.itemRarity = Item.ItemRaritys.uncommon;
            generatedItem.itemDesc = "Raises speeds to another level, but at what cost.";
            generatedItem.rage = 0;
            generatedItem.arcane = 0;
            generatedItem.speed = 10;
            generatedItem.lifeValue = 20;
            generatedItem.skillPointValue = 2;
        }
        else if (generatedItem.itemId == 11)
        {
            generatedItem.itemName = "Helmet of Persistence Arcane";
            generatedItem.itemType = Item.ItemTypes.helmet;
            generatedItem.itemRarity = Item.ItemRaritys.uncommon;
            generatedItem.itemDesc = "Raises your arcane to another level, but at a cost.";
            generatedItem.rage = 0;
            generatedItem.arcane = 15;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 15;
            generatedItem.skillPointValue = 2;
        }
        else if (generatedItem.itemId == 12)
        {
            generatedItem.itemName = "Gloves of Persistant Rage";
            generatedItem.itemType = Item.ItemTypes.gloves;
            generatedItem.itemRarity = Item.ItemRaritys.uncommon;
            generatedItem.itemDesc = "Boosts one's rage, but at a cost.";
            generatedItem.rage = 20;
            generatedItem.arcane = 0;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 10;
            generatedItem.skillPointValue = 2;
        }
        else if (generatedItem.itemId == 13)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "Respiration & Resiliance";
            generatedItem.weaponType = Item.WeaponType.blades_Bow;
            generatedItem.itemRarity = Item.ItemRaritys.rare;
            generatedItem.itemDesc = "Blades that allow the wielder sustain, and healing.";
            generatedItem.rage = 0;
            generatedItem.arcane = 0;
            generatedItem.speed = 30;
            generatedItem.lifeValue = 20;
            generatedItem.skillPointValue = 4;
        }
        else if (generatedItem.itemId == 14)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "Slayer of Devils";
            generatedItem.weaponType = Item.WeaponType.twoHandedWeapon;
            generatedItem.itemRarity = Item.ItemRaritys.rare;
            generatedItem.itemDesc = "Shall destroy any bane of evil.";
            generatedItem.rage = 25;
            generatedItem.arcane = 0;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 25;
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
            generatedItem.arcane = 20;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 30;
            generatedItem.skillPointValue = 4;
        }
        else if (generatedItem.itemId == 16)
        {
            generatedItem.itemName = "Armor of Resiliant Rage";
            generatedItem.itemType = Item.ItemTypes.armor;
            generatedItem.itemRarity = Item.ItemRaritys.rare;
            generatedItem.itemDesc = "Focused on raising one's life, and rage.";
            generatedItem.rage = 30;
            generatedItem.arcane = 0;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 20;
            generatedItem.skillPointValue = 4;
        }
        else if (generatedItem.itemId == 17)
        {
            generatedItem.itemName = "Helmet of Resiliant Speed";
            generatedItem.itemType = Item.ItemTypes.helmet;
            generatedItem.itemRarity = Item.ItemRaritys.rare;
            generatedItem.itemDesc = "Focused on raising one's life, and speed.";
            generatedItem.rage = 0;
            generatedItem.arcane = 0;
            generatedItem.speed = 25;
            generatedItem.lifeValue = 25;
            generatedItem.skillPointValue = 4;
        }
        else if (generatedItem.itemId == 18)
        {
            generatedItem.itemName = "Gloves of Resiliant Arcane";
            generatedItem.itemType = Item.ItemTypes.gloves;
            generatedItem.itemRarity = Item.ItemRaritys.rare;
            generatedItem.itemDesc = "Focused on raising one's life, and arcane.";
            generatedItem.rage = 0;
            generatedItem.arcane = 30;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 20;
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
            generatedItem.speed = 60;
            generatedItem.lifeValue = 40;
            generatedItem.skillPointValue = 8;
        }
        else if (generatedItem.itemId == 20)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "GodSlayer";
            generatedItem.weaponType = Item.WeaponType.twoHandedWeapon;
            generatedItem.itemRarity = Item.ItemRaritys.legendary;
            generatedItem.itemDesc = "The blade thought to be a legend.";
            generatedItem.rage = 50;
            generatedItem.arcane = 0;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 50;
            generatedItem.skillPointValue = 8;
        }
        else if (generatedItem.itemId == 21)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "Spawn of Hope";
            generatedItem.weaponType = Item.WeaponType.magicSphere;
            generatedItem.itemRarity = Item.ItemRaritys.legendary;
            generatedItem.itemDesc = "The offspring of the one thing, we can't lose.";
            generatedItem.rage = 0;
            generatedItem.arcane = 70;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 30;
            generatedItem.skillPointValue = 8;
        }
        else if (generatedItem.itemId == 22)
        {
            generatedItem.itemName = "Armor of Unlimited Arcane";
            generatedItem.itemType = Item.ItemTypes.armor;
            generatedItem.itemRarity = Item.ItemRaritys.legendary;
            generatedItem.itemDesc = "Unlimited Arcane!";
            generatedItem.rage = 0;
            generatedItem.arcane = 40;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 40;
            generatedItem.skillPointValue = 8;
        }
        else if (generatedItem.itemId == 23)
        {
            generatedItem.itemName = "Helmet of Unlimited Rage";
            generatedItem.itemType = Item.ItemTypes.helmet;
            generatedItem.itemRarity = Item.ItemRaritys.legendary;
            generatedItem.itemDesc = "Unlimited Rage!";
            generatedItem.rage = 50;
            generatedItem.arcane = 0;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 30;
            generatedItem.skillPointValue = 8;
        }
        else if (generatedItem.itemId == 24)
        {
            generatedItem.itemName = "Gloves of Unlimited Speed";
            generatedItem.itemType = Item.ItemTypes.gloves;
            generatedItem.itemRarity = Item.ItemRaritys.legendary;
            generatedItem.itemDesc = "Unlimited Speed!";
            generatedItem.rage = 0;
            generatedItem.arcane = 0;
            generatedItem.speed = 30;
            generatedItem.lifeValue = 50;
            generatedItem.skillPointValue = 8;
        }
        else if (generatedItem.itemId == 25)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "Hope & Fear";
            generatedItem.weaponType = Item.WeaponType.blades_Bow;
            generatedItem.itemRarity = Item.ItemRaritys.artifact;
            generatedItem.itemDesc = "The two strongest of feelings, held side by side.";
            generatedItem.rage = 0;
            generatedItem.arcane = 0;
            generatedItem.speed = 260;
            generatedItem.lifeValue = 140;
            generatedItem.skillPointValue = 16;
        }
        else if (generatedItem.itemId == 26)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "Fate Breaker";
            generatedItem.weaponType = Item.WeaponType.twoHandedWeapon;
            generatedItem.itemRarity = Item.ItemRaritys.artifact;
            generatedItem.itemDesc = "The power to change fate.";
            generatedItem.rage = 250;
            generatedItem.arcane = 0;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 150;
            generatedItem.skillPointValue = 16;
        }
        else if (generatedItem.itemId == 27)
        {
            generatedItem.itemType = Item.ItemTypes.weapon;
            generatedItem.itemName = "Hope's Resolve";
            generatedItem.weaponType = Item.WeaponType.magicSphere;
            generatedItem.itemRarity = Item.ItemRaritys.artifact;
            generatedItem.itemDesc = "The strongest of resolves held throughout time.";
            generatedItem.rage = 0;
            generatedItem.arcane = 270;
            generatedItem.speed = 0;
            generatedItem.lifeValue = 130;
            generatedItem.skillPointValue = 16;
        }

        return generatedItem;
    }
}

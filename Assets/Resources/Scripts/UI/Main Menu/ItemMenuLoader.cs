using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMenuLoader : MonoBehaviour
{
    public Item.ItemTypes menuItemType;
    public Item.WeaponType menuWeaponType;

    public GameObject menuItemPrefab;
    public GameObject menuContent;

    private EquipmentMenuInventory _menuInventory;

    private void Start()
    {
        _menuInventory = FindObjectOfType<EquipmentMenuInventory>();

        StartCoroutine(LoadMenuItems());
    }

    IEnumerator LoadMenuItems()
    {
        yield return new WaitForSeconds(0.1f);

        if (menuItemType == Item.ItemTypes.helmet)
            LoadHelmets();
        else if (menuItemType == Item.ItemTypes.armor)
            LoadArmor();
        else if (menuItemType == Item.ItemTypes.gloves)
            LoadGloves();
        else if (menuItemType == Item.ItemTypes.weapon)
        {
            if (menuWeaponType == Item.WeaponType.blades_Bow)
                LoadBladesBow();
            else if (menuWeaponType == Item.WeaponType.twoHandedWeapon)
                LoadTwoHanded();
            else if (menuWeaponType == Item.WeaponType.magicSphere)
                LoadMagicSphere();
        }
    }
    void LoadHelmets()
    {
        for (int i = 0; i < _menuInventory.helmetItems.Count; i++)
        {
            GameObject newMenuItem = Instantiate(menuItemPrefab);
            MainMenuItem menuItemText = newMenuItem.GetComponent<MainMenuItem>();

            newMenuItem.transform.SetParent(menuContent.transform);
            newMenuItem.transform.localScale = new Vector3(1, 1, 1);

            menuItemText.menuItemName.text = _menuInventory.helmetItems[i].itemName;
            menuItemText.menuItemSpeed.text = _menuInventory.helmetItems[i].speed.ToString();
            menuItemText.menuItemRage.text = _menuInventory.helmetItems[i].rage.ToString();
            menuItemText.menuItemArcane.text = _menuInventory.helmetItems[i].arcane.ToString();
            menuItemText.menuItemSkillPoints.text = _menuInventory.helmetItems[i].skillPointValue.ToString();
        }
    }
    void LoadArmor()
    {
        for (int i = 0; i < _menuInventory.armorItems.Count; i++)
        {
            GameObject newMenuItem = Instantiate(menuItemPrefab);
            MainMenuItem menuItemText = newMenuItem.GetComponent<MainMenuItem>();

            newMenuItem.transform.SetParent(menuContent.transform);
            newMenuItem.transform.localScale = new Vector3(1, 1, 1);

            menuItemText.menuItemName.text = _menuInventory.armorItems[i].itemName;
            menuItemText.menuItemSpeed.text = _menuInventory.armorItems[i].speed.ToString();
            menuItemText.menuItemRage.text = _menuInventory.armorItems[i].rage.ToString();
            menuItemText.menuItemArcane.text = _menuInventory.armorItems[i].arcane.ToString();
            menuItemText.menuItemSkillPoints.text = _menuInventory.armorItems[i].skillPointValue.ToString();
        }
    }
    void LoadGloves()
    {
        for (int i = 0; i < _menuInventory.gloveItems.Count; i++)
        {
            GameObject newMenuItem = Instantiate(menuItemPrefab);
            MainMenuItem menuItemText = newMenuItem.GetComponent<MainMenuItem>();

            newMenuItem.transform.SetParent(menuContent.transform);
            newMenuItem.transform.localScale = new Vector3(1, 1, 1);

            menuItemText.menuItemName.text = _menuInventory.gloveItems[i].itemName;
            menuItemText.menuItemSpeed.text = _menuInventory.gloveItems[i].speed.ToString();
            menuItemText.menuItemRage.text = _menuInventory.gloveItems[i].rage.ToString();
            menuItemText.menuItemArcane.text = _menuInventory.gloveItems[i].arcane.ToString();
            menuItemText.menuItemSkillPoints.text = _menuInventory.gloveItems[i].skillPointValue.ToString();
        }
    }
    void LoadBladesBow()
    {
        for (int i = 0; i < _menuInventory.bladesBowItems.Count; i++)
        {
            GameObject newMenuItem = Instantiate(menuItemPrefab);
            MainMenuItem menuItemText = newMenuItem.GetComponent<MainMenuItem>();

            newMenuItem.transform.SetParent(menuContent.transform);
            newMenuItem.transform.localScale = new Vector3(1, 1, 1);

            menuItemText.menuItemName.text = _menuInventory.bladesBowItems[i].itemName;
            menuItemText.menuItemSpeed.text = _menuInventory.bladesBowItems[i].speed.ToString();
            menuItemText.menuItemRage.text = _menuInventory.bladesBowItems[i].rage.ToString();
            menuItemText.menuItemArcane.text = _menuInventory.bladesBowItems[i].arcane.ToString();
            menuItemText.menuItemSkillPoints.text = _menuInventory.bladesBowItems[i].skillPointValue.ToString();
        }
    }
    void LoadTwoHanded()
    {
        for (int i = 0; i < _menuInventory.twoHandedItems.Count; i++)
        {
            GameObject newMenuItem = Instantiate(menuItemPrefab);
            MainMenuItem menuItemText = newMenuItem.GetComponent<MainMenuItem>();

            newMenuItem.transform.SetParent(menuContent.transform);
            newMenuItem.transform.localScale = new Vector3(1, 1, 1);

            menuItemText.menuItemName.text = _menuInventory.twoHandedItems[i].itemName;
            menuItemText.menuItemSpeed.text = _menuInventory.twoHandedItems[i].speed.ToString();
            menuItemText.menuItemRage.text = _menuInventory.twoHandedItems[i].rage.ToString();
            menuItemText.menuItemArcane.text = _menuInventory.twoHandedItems[i].arcane.ToString();
            menuItemText.menuItemSkillPoints.text = _menuInventory.twoHandedItems[i].skillPointValue.ToString();
        }
    }
    void LoadMagicSphere()
    {
        for (int i = 0; i < _menuInventory.magicSphereItems.Count; i++)
        {
            GameObject newMenuItem = Instantiate(menuItemPrefab);
            MainMenuItem menuItemText = newMenuItem.GetComponent<MainMenuItem>();

            newMenuItem.transform.SetParent(menuContent.transform);
            newMenuItem.transform.localScale = new Vector3(1, 1, 1);

            menuItemText.menuItemName.text = _menuInventory.magicSphereItems[i].itemName;
            menuItemText.menuItemSpeed.text = _menuInventory.magicSphereItems[i].speed.ToString();
            menuItemText.menuItemRage.text = _menuInventory.magicSphereItems[i].rage.ToString();
            menuItemText.menuItemArcane.text = _menuInventory.magicSphereItems[i].arcane.ToString();
            menuItemText.menuItemSkillPoints.text = _menuInventory.magicSphereItems[i].skillPointValue.ToString();
        }
    }
}

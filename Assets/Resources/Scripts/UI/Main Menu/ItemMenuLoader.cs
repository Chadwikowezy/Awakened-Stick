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

        LoadMenuItems();
    }

    public void LoadMenuItems()
    {
        if (menuItemType == Item.ItemTypes.helmet)
            LoadHelmets();
        else if (menuItemType == Item.ItemTypes.armor)
            LoadArmor();
        else if (menuItemType == Item.ItemTypes.gloves)
            LoadGloves();
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
        }
    }
}

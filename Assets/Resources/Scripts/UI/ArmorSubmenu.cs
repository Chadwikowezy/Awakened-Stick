using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorSubmenu : MonoBehaviour
{
    private enum ArmorMenus { Helmet, Armor, Gloves }

    private ArmorMenus _currentArmorMenu;

    public GameObject helmetButton;
    public GameObject armorButton;
    public GameObject glovesButton;

    public GameObject helmetsScrollView;
    public GameObject armorScrollView;
    public GameObject glovesScrollview;

    private void Start()
    {
        SetActiveArmorMenu(ArmorMenus.Helmet);
    }

    void SetActiveArmorMenu(ArmorMenus _newActiveMenu)
    {
        if (_newActiveMenu == ArmorMenus.Helmet)
        {
            helmetButton.GetComponent<Image>().color = Color.black;
            armorButton.GetComponent<Image>().color = new Color(0.3f, 0.3f, 0.3f, 0.6f);
            glovesButton.GetComponent<Image>().color = new Color(0.3f, 0.3f, 0.3f, 0.6f);
        }
        else if (_newActiveMenu == ArmorMenus.Armor)
        {
            helmetButton.GetComponent<Image>().color = new Color(0.3f, 0.3f, 0.3f, 0.6f);
            armorButton.GetComponent<Image>().color = Color.black;
            glovesButton.GetComponent<Image>().color = new Color(0.3f, 0.3f, 0.3f, 0.6f);
        }
        else if (_newActiveMenu == ArmorMenus.Gloves)
        {
            helmetButton.GetComponent<Image>().color = new Color(0.3f, 0.3f, 0.3f, 0.6f);
            armorButton.GetComponent<Image>().color = new Color(0.3f, 0.3f, 0.3f, 0.6f);
            glovesButton.GetComponent<Image>().color = Color.black;
        }

        _currentArmorMenu = _newActiveMenu;
    }

    public void HelmetButton()
    {
        SetActiveArmorMenu(ArmorMenus.Helmet);
    }
    public void ArmorButton()
    {
        SetActiveArmorMenu(ArmorMenus.Armor);
    }
    public void GlovesButton()
    {
        SetActiveArmorMenu(ArmorMenus.Gloves);
    }
}

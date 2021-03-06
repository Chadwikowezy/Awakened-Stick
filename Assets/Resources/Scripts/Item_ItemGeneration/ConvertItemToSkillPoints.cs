﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConvertItemToSkillPoints : MonoBehaviour
{
    private Actor actor;
    private SkillPointManager skillPointManager;
    private InventoryItem item;

    public void ConvertToSkillPoint()
    {
        actor = FindObjectOfType<Actor>();
        item = GetComponentInParent<InventoryItem>();
        skillPointManager = FindObjectOfType<SkillPointManager>();
        GameObject itemCountText = GameObject.Find("ItemCountText");

        if(GetComponentInParent<InventoryItem>().GetComponentInChildren<Equip>().itemIsEquipped == false)
        {
            if (item.itemRarity == Item.ItemRaritys.common)
            {
                skillPointManager.CurrentSkillPointValue += 1;
                skillPointManager.skillPointValueText.text = skillPointManager.CurrentSkillPointValue.ToString();
                skillPointManager.skillPointTabTxt.text = skillPointManager.CurrentSkillPointValue.ToString();
            }
            else if (item.itemRarity == Item.ItemRaritys.uncommon)
            {
                skillPointManager.CurrentSkillPointValue += 2;
                skillPointManager.skillPointValueText.text = skillPointManager.CurrentSkillPointValue.ToString();
                skillPointManager.skillPointTabTxt.text = skillPointManager.CurrentSkillPointValue.ToString();
            }
            if (item.itemRarity == Item.ItemRaritys.rare)
            {
                skillPointManager.CurrentSkillPointValue += 4;
                skillPointManager.skillPointValueText.text = skillPointManager.CurrentSkillPointValue.ToString();
                skillPointManager.skillPointTabTxt.text = skillPointManager.CurrentSkillPointValue.ToString();
            }
            if (item.itemRarity == Item.ItemRaritys.legendary)
            {
                skillPointManager.CurrentSkillPointValue += 8;
                skillPointManager.skillPointValueText.text = skillPointManager.CurrentSkillPointValue.ToString();
                skillPointManager.skillPointTabTxt.text = skillPointManager.CurrentSkillPointValue.ToString();
            }
            if (item.itemRarity == Item.ItemRaritys.artifact)
            {
                skillPointManager.CurrentSkillPointValue += 16;
                skillPointManager.skillPointValueText.text = skillPointManager.CurrentSkillPointValue.ToString();
                skillPointManager.skillPointTabTxt.text = skillPointManager.CurrentSkillPointValue.ToString();

            }
            actor.data.ids.Remove(item.itemId);
            itemCountText.GetComponent<Text>().text = actor.data.ids.Count.ToString();
            Destroy(item.gameObject);
        }       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemDisplay : MonoBehaviour
{
    public Text textName;
    public Image sprite;
    Image backGround;

    public InventoryItem item;

    public Text flavorText;
    public Text rage;
    public Text arcane;
    public Text speed;
    public Text tokens;
    public Text life;

	void Start ()
    {
        backGround = GetComponent<Image>();
        if(item != null)
        {
            Prime(item);
        }
	}
	
	public void Prime(InventoryItem item)
    {
        this.item = item;
        //item = GetComponent<InventoryItem>();

        if (textName != null)
        {
            textName.text = item.itemName;
        }
        if (item.itemRarity == Item.ItemRaritys.common)
        {
            textName.color = Color.white;
        }
        else if (item.itemRarity == Item.ItemRaritys.uncommon)
        {
            textName.color = Color.green;
        }
        else if (item.itemRarity == Item.ItemRaritys.rare)
        {
            textName.color = Color.blue;
        }
        else if (item.itemRarity == Item.ItemRaritys.legendary)
        {
            textName.color = Color.yellow;
        }
        else if (item.itemRarity == Item.ItemRaritys.artifact)
        {
            textName.color = Color.red;
        }
        flavorText.text = item.itemDesc;
        rage.text = "Rage: " + item.rage;
        speed.text = "Speed: " + item.speed;
        arcane.text = "Arcane: " + item.arcane;
        tokens.text = "Tokens: " + item.tokens;
        life.text = "Life: " + item.lifeValue;
    }
}

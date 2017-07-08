using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<InventoryItem> items = new List<InventoryItem>();
    public InventoryDisplay inventoryDisplay;
    public Text carryWeightText;

	void Awake ()
    {
        inventoryDisplay.PrimeInventoryItemList(items);

    }
	
	public void SetCarryWeight(int maxWeight, int currentWeight)
    {
        carryWeightText.text = currentWeight.ToString() + "/" + maxWeight.ToString() + "Lbs.";
    }
}

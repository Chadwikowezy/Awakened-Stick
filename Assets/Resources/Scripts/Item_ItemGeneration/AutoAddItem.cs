using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAddItem : MonoBehaviour
{
    public List<InventoryItem> items = new List<InventoryItem>();

    private InventoryDisplay inventoryDisplay;

	void Start ()
    {
        inventoryDisplay = FindObjectOfType<InventoryDisplay>();
        items.Add(GetComponent<InventoryItem>());//needs ref to self for pickup
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            foreach(InventoryItem item in items)
            {
                gameObject.SetActive(false);
                inventoryDisplay.PrimeInventoryItemList(items);
                inventoryDisplay.items.Add(item);
            }
        }
    }
}

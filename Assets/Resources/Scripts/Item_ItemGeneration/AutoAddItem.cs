using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAddItem : MonoBehaviour
{
    public List<InventoryItem> items = new List<InventoryItem>();

    private InventoryDisplay inventoryDisplay;

    public List<InventoryItem> itemsNotAdded = new List<InventoryItem>();
    public bool needToLoadSomeItemsIn = false;

	void Start ()
    {
        items.Add(GetComponent<InventoryItem>());//needs ref to self for pickup
        inventoryDisplay = FindObjectOfType<InventoryDisplay>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            foreach(InventoryItem item in items)
            {
                gameObject.SetActive(false);               
                ItemReturnManager itemReturnManager = FindObjectOfType<ItemReturnManager>();
                itemReturnManager.itemsNotAdded.Add(GetComponent<InventoryItem>());
                //items.Remove(GetComponent<InventoryItem>());
                needToLoadSomeItemsIn = true;


            }
        }
    }
}

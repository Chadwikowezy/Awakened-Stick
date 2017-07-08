using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameSparks.Api.Requests;
using GameSparks.Api.Responses;
using GameSparks.Core;
using System.IO;

public class Actor : MonoBehaviour
{
    public ActorData data;
    public InventoryDisplay inventoryDisplay;
    private GameObject player;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        inventoryDisplay = FindObjectOfType<InventoryDisplay>();
    }

    //GameSparks Store and load data function here         
    #region StoreData to Cloud
    /*
private void GameSparksSendData()
{
    GSRequestData jsonDataToSend = new GSRequestData();
    jsonDataToSend.Add("currency", data.currency1);//do this same adding to request to store info
    jsonDataToSend.Add("health", data.healthVal);
    //info sent to cloud here
    new LogEventRequest().SetEventKey("PlayerData")
        .SetEventAttribute("jsonData", jsonDataToSend)
        .Send((response) =>
        {
            if (response.HasErrors)
            {
                Debug.Log("Response failure?");
            }
            else
            {
                Debug.Log("Success sending data to cloud");
            }
        });
}
#endregion

#region LoadData from cloud
private void GameSparksRecieveData()
{
    new GameSparks.Api.Requests.LogEventRequest().SetEventKey("PlayerData").SetEventAttribute("jsonData", "playerStats.text").Send((response) =>
    {          
        if (!response.HasErrors)
        {
            string theText = response.ScriptData.GetString("collection");
            Debug.Log("My result is: " + theText);
        }
        else
        {
            Debug.Log("Failed right away " + response.Errors);
        }
    });

}
*/
    #endregion


    public void StoreData()
    {
        //store item ids
        if(inventoryDisplay != null)
        {
            foreach (InventoryItem inventoryItem in inventoryDisplay.items)
            {
                data.ids.Add(inventoryItem.itemId);
            }
            inventoryDisplay.items.Clear();
        }


        //data.playerPosition = player.transform.position;
    }
    public void LoadData()
    {
        //item loading is handled in itemreturnmanager class
        player = GameObject.FindGameObjectWithTag("Player");
        //player.transform.position = data.playerPosition;
    }

    #region Applying Conditions to info store/ Load
    public void ApplyData()
    {
        SaveData.AddActorData(data);
    }
    void OnEnable()
    {
        SaveData.OnLoaded += LoadData;
        SaveData.OnBeforeSave += StoreData;
        SaveData.OnBeforeSave += ApplyData;
    }
    void OnDisable()
    {
        SaveData.OnLoaded -= LoadData;
        SaveData.OnBeforeSave -= StoreData;
        SaveData.OnBeforeSave -= ApplyData;
    }
    #endregion
}


#region ActorData Class, variables saved
[Serializable]
public class ActorData
{
    public Vector3 playerPosition;

    public List<int> ids = new List<int>(); 
}
#endregion


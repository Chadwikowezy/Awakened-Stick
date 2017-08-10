using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldCreation : MonoBehaviour
{
    public int level;
    public int waveCount;
    public int enemyCountToSpawn;
    public GameObject enemyObject;
    public Transform[] possibleSpawnPoints;
    public Text waveCountText;

	void Awake ()
    {
        StartingWave();
    }

    void StartingWave()
    {
        level = 1;
        waveCount = 1;
        enemyCountToSpawn = 4;
        UpdateText();
        CreateEnemyObjects();
    }

    void UpdateText()
    {
        waveCountText.text = "Wave Count: " + waveCount;
    }

    void Update()
    {
        Enemy[] enemyObjects = FindObjectsOfType<Enemy>();
        if(enemyObjects.Length <= 0)
        {
            waveCount++;
            enemyCountToSpawn = enemyCountToSpawn * 2;
            UpdateText();
            CreateEnemyObjects();
        }

        if(waveCount > 5)
        {
            level++;
        }
        else if(waveCount > 10)
        {
            level++;
        }
        else if(waveCount > 20)
        {
            level++;
        }
        else if(waveCount > 50)
        {
            level++;
        }
    }

    void CreateEnemyObjects()
    {
        for (int i = 0; i < enemyCountToSpawn; i++)
        {
            int spawnPoint = Random.Range(0, 12);
            GameObject enemyCreated = (GameObject)Instantiate(enemyObject, possibleSpawnPoints[spawnPoint].transform.position, Quaternion.identity);
            enemyCreated.GetComponent<Enemy>().CurrentMaxHealth = enemyCreated.GetComponent<Enemy>().CurrentMaxHealth * level;
            enemyCreated.GetComponent<Enemy>().CurrentHealth = enemyCreated.GetComponent<Enemy>().CurrentHealth * level;
            //StartCoroutine(DelayBetweenEnemySpawn());
        }
    }

    IEnumerator DelayBetweenEnemySpawn()
    {
        yield return new WaitForSeconds(1f);
        
    }
}

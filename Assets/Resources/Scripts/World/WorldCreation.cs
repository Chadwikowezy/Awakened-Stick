using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldCreation : MonoBehaviour
{
    public int tierCount;
    public int waveCount;
    public GameObject enemyObject;
    public Transform[] possibleSpawnPoints;
    public Text waveCountText;
    public int enemyDeathTracker;

    void Start()
    {
        tierCount = 1;
        waveCount = 1;
        StartCoroutine(TestTimeGap());
    }
    void Update()
    {
        UpdateText();
        WaveTracker();
        DeathTracker();
    }

    IEnumerator TestTimeGap()
    {
        yield return new WaitForSeconds(3f);
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        yield return new WaitForSeconds(3f);
        for (int i = 0; i < 3; i++)
        {
            GameObject enemy = (GameObject)Instantiate(enemyObject,
            possibleSpawnPoints[Random.Range(0, 12)].transform.position, Quaternion.identity);
            enemy.GetComponent<Enemy>().CurrentMaxHealth = enemy.GetComponent<Enemy>().CurrentMaxHealth * waveCount;
            enemy.GetComponent<Enemy>().CurrentHealth = enemy.GetComponent<Enemy>().CurrentHealth * waveCount;
        }
        StartCoroutine(TestTimeGap());

    }

    void DeathTracker()
    {
        if (enemyDeathTracker > 10)
        {
            waveCount++;
            enemyDeathTracker = 0;
        }
    }

    #region waveTracker
    void WaveTracker()
    {
        if(waveCount > 5)
        {
            tierCount++;
        }
        else if (waveCount > 10)
        {
            tierCount++;
        }
        else if (waveCount > 20)
        {
            tierCount++;
        }
        else if (waveCount > 50)
        {
            tierCount++;
        }
    }
    #endregion

    void UpdateText()
    {
        waveCountText.text = "Wave Count: " + waveCount;
    }
}

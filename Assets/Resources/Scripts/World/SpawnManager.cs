using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour 
{
	public GameObject enemyPrefab;
	private GameObject[] spawnPoints;

	private bool stop;

	private  float spawnWait;
	public float minWait = 2;
	public float maxWait = 5;
	public float startWait = 3;

	void Start () 
	{
		spawnPoints = GameObject.FindGameObjectsWithTag ("SpawnPoint");

		StartCoroutine (waitSpawner());
	}
	
	void Update () 
	{
		spawnWait = Random.Range (minWait, maxWait);
	}

	IEnumerator waitSpawner()
	{
	
		yield return new WaitForSeconds (startWait);

		while (!stop) 
		{
			foreach (GameObject spawnPoint in spawnPoints)
			{
				Instantiate (enemyPrefab, spawnPoint.transform.position, Quaternion.identity);
			}
			yield return new WaitForSeconds (spawnWait);
		}
	}
}

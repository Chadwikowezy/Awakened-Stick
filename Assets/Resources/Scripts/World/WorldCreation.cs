using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCreation : MonoBehaviour
{
    public int level;

	void Awake ()
    {
        GenerateLevel();
        Debug.Log("Level at: " + level);
        Debug.Log(level);
	}

    public int GenerateLevel()
    {
        level = Random.Range(1, 6);
        return level;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Button saveButton;
    public Button loadButton;

    public GameObject playerPrefab;
    public const string playerPath = "Prefabs/Loader";

    private static string dataPath = string.Empty;

    public object JsonConvert { get; private set; }

    void Awake()
    {
        dataPath = System.IO.Path.Combine(Application.persistentDataPath, "actors.json");
        Debug.Log(dataPath);
    }

    public static Actor CreateActor(string path, Vector3 pos, Quaternion rotation)
    {
        GameObject prefab = Resources.Load<GameObject>(path);

        GameObject go = Instantiate(prefab, pos, rotation) as GameObject;

        Actor actor = go.GetComponent<Actor>() ?? go.AddComponent<Actor>();

        return actor;
    }

    public static Actor CreateActor(ActorData data, string path, Vector3 pos, Quaternion rotation)
    {
        Actor actor = CreateActor(path, pos, rotation);

        actor.data = data;

        return actor;
    }

    public void Save()
    {
        SaveData.Save(dataPath, SaveData.actorContainer);
    }

    public void Loaded()
    {
        SaveData.Load(dataPath);
    }
}

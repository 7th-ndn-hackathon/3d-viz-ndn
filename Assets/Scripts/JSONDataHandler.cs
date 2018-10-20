
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JSONDataHandler : MonoBehaviour
{

    string filePath;
    string contents;
    public projData data = new projData();

    public void Awake()
    {
        filePath = Path.Combine(Application.streamingAssetsPath, "data.json");
        StartCoroutine(initFile());
    }

    public void addNewHost(string name, float x, float y, float z)
    {
        data.hosts.Add(new projData.host(name, x, y, z));
    }

    public void saveToJSON()
    {
        string contents = JsonUtility.ToJson(data, true);
        File.WriteAllText(filePath, string.Empty);
        File.WriteAllText(filePath, contents);
        Debug.Log("Success");
    }

    public void readFromJSON()
    {
        data = JsonUtility.FromJson<projData>(contents);
    }

    private IEnumerator initFile()
    {
        if (filePath.Contains("://") || filePath.Contains(":///"))
        {
            WWW www = new WWW(filePath);
            yield return www;
            contents = www.text;
            Debug.Log("WWW ");
            readFromJSON();
        }
        else
        {
            contents = File.ReadAllText(filePath);
            Debug.Log("NOT WWW: ");
            readFromJSON();
        }
    }

}


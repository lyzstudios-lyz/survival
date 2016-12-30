using System;
using UnityEngine;

[System.Serializable]
public class JSONItem
{
    // the index in the json list
    public int index = 0;
    // the name of the object
    public string myName = "default";
    // the objects health
    public int health = 0;
    public string img = "none";

    public static JSONItem CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<JSONItem>(jsonString);
    }

}

using UnityEngine;

[System.Serializable]
public class JSONItems
{
    public JSONItem[] items;

    public static JSONItems CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<JSONItems>(jsonString);
    }
}

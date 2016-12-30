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
    public double weight = 0.5;
    public bool isFood = false;
    public bool isForCrafting = false;
    public bool isPerishable = false;
    public bool canDoDamage = false;
    public bool canHarvest = false;
    public bool canGrow = false;
    public bool canCatchFire = false;
    public bool canBeWet = false;
    public double wetness = 0;
    public bool canBeFrozen = false;
    public double frozeness = 0;
    public double rawness = 100;
    public bool canBeSmelted = false;
    public bool canBeStacked = false;
    public bool canGiveHealth = false;
    public bool canProvideWarmth = false;
    public bool canProvideLight = false;
    public bool canProvideCooling = false;
    public bool canPoison = false;
    public bool canHeal = false;
    public bool isEmpty = false;
    public bool isLiquid = false;
    public bool tastesGood = false;
    public bool holdsOtherItems = false;

    public static JSONItem CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<JSONItem>(jsonString);
    }

}

using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
    // the index in the json list
    public int index = 0;
    // the name of the object
    public string myName = "default";
    // the objects health
    public int health = 0;
    public double weight = 0.5;
    public bool isFood = false;
    public bool isForCrafting = true;
    public bool isPerishable = false;
    public bool canDoDamage = true;
    public bool canHarvest = true;
    public bool canGrow = false;
    public bool canCatchFire = false;
    public bool canBeWet = false;
    public double wetness = 0;
    public bool canBeFrozen = false;
    public double frozeness = 0;
    public double rawness = 100;
    public bool canBeSmelted = false;
    public bool canBeStacked = true;
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

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

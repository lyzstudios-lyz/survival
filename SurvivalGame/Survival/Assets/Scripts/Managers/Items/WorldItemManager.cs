using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
using System;
using UnityEngine.UI;

public class WorldItemManager : MonoBehaviour {

    public GameObject itemPrefab;

    public Sprite defaultSprite;

    // Array containing all items that are only in the world
    // not on player, in bag, etc
    private JSONItems itemList = new JSONItems();

    private String jsonItemPath = "Assets/Resources/Json/items.json";

    string jsonString;

    // Use this for initialization
    void Start() {
        
        WorldItemListInit();

        CreateWorldItem(0);
        CreateWorldItem(1);
    }

    /// <summary>
    /// Create a list of items that can be spawned in the world
    /// </summary>
    private void WorldItemListInit()
    {
        // if the item.json was able to be loaded
        if (LoadJSON(jsonItemPath))
        {
            Debug.Log("** The World Items have been saved to a string! **");
            // create an Item list from the json file
            itemList = JSONItems.CreateFromJSON(jsonString);
            // for each item in the list
            for (int i = 0; i < itemList.items.Length; i++)
            {
                // print out the item's name
                Debug.Log(itemList.items[i].ToString());
            }
        } else
        {
            Debug.Log("** No World Items were loaded :( **");
        }
    }

    /// <summary>
    /// Load a .json file from a given file name
    /// </summary>
    /// <param name="fileName">The path and name of the .json file</param>
    /// <returns>true if string was created</returns>
    private bool LoadJSON(string fileName)
    {
        string line;
        // Handle any problems that might arise when reading the text
        try
        {
            // Create a new StreamReader, tell it which file to read and what encoding the file
            // was saved as
            StreamReader theReader = new StreamReader(fileName);
            // Immediately clean up the reader after this block of code is done.
            // You generally use the "using" statement for potentially memory-intensive objects
            // instead of relying on garbage collection.
            // (Do not confuse this with the using directive for namespace at the 
            // beginning of a class!)
            using (theReader)
            {
                // While there's lines left in the text file, do this:
                do
                {
                    line = theReader.ReadLine();
                    if (line != null)
                    {
                        jsonString += line;
                    }
                }
                while (line != null);

                // Done reading, close the reader and return true to broadcast success    
                theReader.Close();
                return true;
            }
        }

        // If anything broke in the try block, we throw an exception with information
        // on what didn't work
        catch (Exception e)
        {
            Debug.Log("An exception was thrown : " + e);
            Console.WriteLine("{0}\n", e.Message);
            return false;
        }
    }


    public void CreateWorldItem(int index)
    {
        // create a new game object
        GameObject newObject = Instantiate(itemPrefab);
        // create a reference to the newItem's script component
        Item newItem = newObject.GetComponent<Item>();

        // Set item properties equal to the default properties
        newItem.myName = itemList.items[index].myName;
        newItem.index = itemList.items[index].index;
        newItem.health = itemList.items[index].health;
        newItem.weight = itemList.items[index].weight;
        newItem.isFood = itemList.items[index].isFood;
        newItem.isForCrafting = itemList.items[index].isForCrafting;
        newItem.isPerishable = itemList.items[index].isPerishable;
        newItem.canDoDamage = itemList.items[index].canDoDamage;
        newItem.canHarvest = itemList.items[index].canHarvest;
        newItem.canGrow = itemList.items[index].canGrow;
        newItem.canCatchFire = itemList.items[index].canCatchFire;
        newItem.canBeWet = itemList.items[index].canBeWet;
        newItem.wetness = itemList.items[index].wetness;
        newItem.canBeFrozen = itemList.items[index].canBeFrozen;
        newItem.frozeness = itemList.items[index].frozeness;
        newItem.rawness = itemList.items[index].rawness;
        newItem.canBeSmelted = itemList.items[index].canBeSmelted;
        newItem.canBeStacked = itemList.items[index].canBeStacked;
        newItem.canGiveHealth = itemList.items[index].canGiveHealth;
        newItem.canProvideWarmth = itemList.items[index].canProvideWarmth;
        newItem.canProvideLight = itemList.items[index].canProvideLight;
        newItem.canProvideCooling = itemList.items[index].canProvideCooling;
        newItem.canPoison = itemList.items[index].canPoison;
        newItem.canHeal = itemList.items[index].canHeal;
        newItem.holdsOtherItems = itemList.items[index].holdsOtherItems;
        newItem.isEmpty = itemList.items[index].isEmpty;
        newItem.isLiquid = itemList.items[index].isLiquid;
        newItem.tastesGood = itemList.items[index].tastesGood;
        

    // assign new sprite image to the object
    SpriteRenderer img = newObject.GetComponent<SpriteRenderer>();
        Sprite testSprite = Resources.Load<Sprite>(itemList.items[index].img);
        if(testSprite != null)
        {
            img.sprite = testSprite;
        } else
        {
            img.sprite = defaultSprite;
        }


        // assign new name to object the matches the given name
        newObject.name = newItem.myName;
    }
}
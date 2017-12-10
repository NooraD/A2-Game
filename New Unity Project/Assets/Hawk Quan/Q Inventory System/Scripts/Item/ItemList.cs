using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemList : ScriptableObject
{
    public List<Itemm> itemList = new List<Itemm>();
    public List<Currency> currencies = new List<Currency>();
    public List<ItemAttribute> attributes = new List<ItemAttribute>();
    public List<CraftingBluePrint> bluePrints = new List<CraftingBluePrint>();

    public Itemm getItemByID(int id)
    {
        for (int i = 0; i < itemList.Count; i++)
        {
            if (itemList[i].ID == id)
                return itemList[i];
        }
        return null;
    }

    public Itemm getItemByName(string name)
    {
        for (int i = 0; i < itemList.Count; i++)
        {
            if (itemList[i].itemName == name)
                return itemList[i];
        }
        return null;
    }
}

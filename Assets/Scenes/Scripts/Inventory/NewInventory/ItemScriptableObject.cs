using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType 
{
    Default,
    Food,
    Health,
    Weapon,
    Instrument,
    Bullet
}

public class ItemScriptableObject : ScriptableObject
{
    public ItemType itemType;
    public string itemName;
    //public int maximumAmount;
    public string itemDescription;
    public Sprite icon;
}

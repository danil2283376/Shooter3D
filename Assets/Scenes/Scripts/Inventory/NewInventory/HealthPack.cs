using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Health Item",
     menuName = "Inventory/Items/Health Item")]
public class HealthPack : ItemScriptableObject
{
    public float valueHealth;

    private void Start() 
    {
        itemType = ItemType.Health; 
    }
}

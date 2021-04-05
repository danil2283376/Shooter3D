using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeBullet
{
    Explosive,
    ArmorPiercing,
    Default
}

[CreateAssetMenu(fileName = "Bullets",
    menuName = "Inventory/Items/Bullets")]
public class BulletsScriptable : ItemScriptableObject
{
    public TypeBullet typeBullet;
    public int timeLive;
    public int damage;

    private void Start()
    {
        itemType = ItemType.Bullet;
    }
}

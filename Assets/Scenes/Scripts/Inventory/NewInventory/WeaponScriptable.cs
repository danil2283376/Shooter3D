using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon Item", 
    menuName = "Inventory/Items/Weapon Item")]
public class WeaponScriptable : ItemScriptableObject
{
    public GameObject player;
    public GameObject prefabBullet;
    public int magazineAmmo = 6; // патроны
    public int maximumAmmo; // максимальное кол-во патрон
    public int damage = 10; // урон
    public float speedBullet = 1f; // скрость пули
    public float timeReload = 3f; // время перезарядки
    public float rateFire = 5; // кол-во патрон за минуту
    public bool weaponOnPlayer = false; // оружие на игроке
    public void Start() 
    {
        itemType = ItemType.Weapon;
    }
}

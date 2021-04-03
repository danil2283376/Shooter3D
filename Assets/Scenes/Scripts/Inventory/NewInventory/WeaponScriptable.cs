using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon Item", 
    menuName = "Inventory/Items/Weapon Item")]
public class WeaponScriptable : ItemScriptableObject
{
    public GameObject player;
    public GameObject prefabBullet;
    public int magazineAmmo = 6; // �������
    public int maximumAmmo; // ������������ ���-�� ������
    public int damage = 10; // ����
    public float speedBullet = 1f; // ������� ����
    public float timeReload = 3f; // ����� �����������
    public float rateFire = 5; // ���-�� ������ �� ������
    public bool weaponOnPlayer = false; // ������ �� ������
    public void Start() 
    {
        itemType = ItemType.Weapon;
    }
}

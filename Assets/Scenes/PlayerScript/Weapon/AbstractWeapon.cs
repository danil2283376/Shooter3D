using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractWeapon : MonoBehaviour
{
    // Start is called before the first frame update
    public float speedBullet = 1f; // скрость пули
    public float timeReload = 3f; // время перезарядки
    public int magazineAmmo = 6; // патроны
    public int damage = 10; // урон
    public float rateFire = 5; // кол-во патрон за минуту
    public GameObject prefabBullet;
    public abstract void Shoot();
    public abstract void Reload();
}

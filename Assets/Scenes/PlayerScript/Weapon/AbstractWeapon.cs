using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractWeapon : MonoBehaviour
{
    // Start is called before the first frame update
    public float speedBullet = 1f; // ������� ����
    public float timeReload = 3f; // ����� �����������
    public int magazineAmmo = 6; // �������
    public int damage = 10; // ����
    public float rateFire = 5; // ���-�� ������ �� ������
    public GameObject prefabBullet;
    public abstract void Shoot();
    public abstract void Reload();
}

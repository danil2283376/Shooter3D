using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public WeaponScriptable weaponObject;
    private float timeShoot = 0.0f;
    // ������� ����� �����������
    private float currentReload = 0.0f;
    private float bulletInMinute;
    private int currentBullet;
    private bool activateReloading;
    void Start()
    {
        // ��������� � ������
        bulletInMinute = 60.0f / weaponObject.rateFire;
        // ������� ����� ������ �����
        currentBullet = weaponObject.magazineAmmo;
        activateReloading = false;
        //weaponObject.player = gameObject.transform.parent.transform.parent.gameObject;
    }
    void Update()
    {
        if (weaponObject.weaponOnPlayer)
        {
            // �������� ���� � ������ ������� ������ R
            if (Input.GetKey(KeyCode.R))
                activateReloading = true;
            // ���� ����� ����������� ������
            if (currentReload > weaponObject.timeReload)
                Reload();
            timeShoot += Time.deltaTime;
            // ���� ���� ������ ����� R
            if (activateReloading)
                currentReload += Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        if (weaponObject.weaponOnPlayer)
        {
            if (Input.GetButton("Fire1"))
            {
                // ���� ������� ���������
                if (currentBullet <= 0)
                    currentBullet = 0;
                else if ((timeShoot > bulletInMinute) && currentBullet > 0)
                    Shoot();
            }
        }
    }

    public void Reload()
    {
        currentBullet = weaponObject.magazineAmmo;
        currentReload = 0.0f;
        activateReloading = false;
    }

    public void Shoot()
    {
        currentBullet--;
        GameObject objectBullet = Instantiate(weaponObject.prefabBullet, transform.position, gameObject.transform.rotation);
        Rigidbody rigidbody = objectBullet.GetComponent<Rigidbody>();
        rigidbody.AddForce(gameObject.transform.forward * weaponObject.speedBullet, ForceMode.VelocityChange);
        timeShoot = 0.0f;
    }
}

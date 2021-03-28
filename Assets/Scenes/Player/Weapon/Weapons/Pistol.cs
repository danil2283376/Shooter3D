using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : AbstractWeapon
{
    // Start is called before the first frame update
    private float timeShoot = 0.0f;
    private float currentReload = 0.0f;
    private float bulletInMinute;
    private int currentBullet;
    private bool activateReloading;
    void Start()
    {
        // ��������� � ������
        bulletInMinute = 60.0f / rateFire;
        // ������� ����� ������ �����
        currentBullet = magazineAmmo;
        activateReloading = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            // ���� ������� ���������
            if (currentBullet <= 0)
            {
                currentBullet = 0;
            }
            else if ((timeShoot > bulletInMinute) && currentBullet > 0)
                Shoot();
        }
        // �������� ���� � ������ ������� ������ R
        if (Input.GetKey(KeyCode.R))
            activateReloading = true;
        // ���� ����� ����������� ������
        if (currentReload > timeReload)
            Reload();
        timeShoot += Time.deltaTime;
        // ���� ���� ������ ����� R
        if (activateReloading)
            currentReload += Time.deltaTime;
    }

    public override void Reload()
    {
        currentBullet = magazineAmmo;
        currentReload = 0.0f;
        activateReloading = false;
    }

    public override void Shoot()
    {
        currentBullet--;
        Object objectBullet = Instantiate(prefabBullet, transform.position, Quaternion.identity);
        timeShoot = 0.0f;
    }
}

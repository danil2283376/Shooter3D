using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : AbstractWeapon
{
    // ����� ����� ����������
    private float timeShoot = 0.0f;
    // ������ ����� �����������
    private float currentReload = 0.0f;
    private float bulletInMinute;
    private int currentBullet;
    private bool activateReloading;
    // Start is called before the first frame update
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
        if (weaponOnPlayer)
        {
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
    }

    private void FixedUpdate()
    {
        if (weaponOnPlayer)
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

    public override void Reload()
    {
        currentBullet = magazineAmmo;
        currentReload = 0.0f;
        activateReloading = false;
    }

    public override void Shoot()
    {
        currentBullet--;
        GameObject objectBullet = Instantiate(prefabBullet, transform.position, gameObject.transform.rotation);
        Rigidbody rigidbody = objectBullet.GetComponent<Rigidbody>();
        rigidbody.AddForce(gameObject.transform.forward * speedBullet, ForceMode.VelocityChange);
        timeShoot = 0.0f;
    }
}

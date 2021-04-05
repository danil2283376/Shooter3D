using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public WeaponScriptable weaponObject;
    private float timeShoot = 0.0f;
    // текущее время перезарядки
    private float currentReload = 0.0f;
    private float bulletInMinute;
    private int currentBullet;
    private bool activateReloading;
    void Start()
    {
        // выстрелов в минуту
        bulletInMinute = 60.0f / weaponObject.rateFire;
        // магазин равен объему рожка
        currentBullet = weaponObject.magazineAmmo;
        activateReloading = false;
        //weaponObject.player = gameObject.transform.parent.transform.parent.gameObject;
    }
    void Update()
    {
        if (weaponObject.weaponOnPlayer)
        {
            // поднимаю флаг в случае нажатия кнопки R
            if (Input.GetKey(KeyCode.R))
                activateReloading = true;
            // если время перезарядки прошло
            if (currentReload > weaponObject.timeReload)
                Reload();
            timeShoot += Time.deltaTime;
            // если была нажата кнопа R
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
                // если патроны кончились
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

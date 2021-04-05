using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveInventory : MonoBehaviour
{
    private Camera mainCamera;
    private GameObject inventoryObject;
    private GameObject fastSlots;
    private void Awake()
    {
        inventoryObject = GameObject.Find("ManagerInventory");
        fastSlots = GameObject.Find("Fast Slots");
        mainCamera = Camera.main;
    }

    private void Update()
    {
        //Vector3 dir = mainCamera.ScreenToWorldPoint(new Vector3(200, 200, 0));
        Ray ray = mainCamera.ScreenPointToRay(new Vector3(Screen.width / 2,
            Screen.height / 2, 0));
        //new Vector3(Screen.width / 2, Screen.height / 2);
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            Physics.Raycast(ray, out hit, 30);
            Debug.DrawLine(ray.origin, ray.direction * 20);
            //Debug.DrawRay(transform.position, transform.forward, Color.yellow);
            if (hit.transform != null)
            {
                if (hit.transform.tag == "Drop")
                    AddItemInInventory();
                print(hit.transform.tag);
            }
        }
    }

    private void AddItemInInventory() 
    {

    }
}

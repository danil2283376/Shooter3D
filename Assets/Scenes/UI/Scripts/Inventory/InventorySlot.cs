using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public Sprite spriteSlot;
    public string description;
    public int countElementsInSlot;
    public GameObject item;

    //public GameObject copy;
    public void ChangeItemSlot(GameObject drop) 
    {
        //copy = item;
        item = drop;
        // Нужен какой то общий компонент
        //spriteSlot = drop.GetComponent<>
    }
}

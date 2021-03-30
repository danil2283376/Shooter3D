using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // можно получать компоненты скриптов и использовать их переменные
public class ChangeItem : MonoBehaviour
{
    public GameObject[] items;

    public void ChangeItemInHand(string nameItem, string tagItem) 
    {
        GameObject oldItem = null;
        Transform oldTransform = null;
        Transform child = null;

        // нахожу старую вещь на игроке
        for (int i = 0; i < gameObject.transform.childCount; i++) 
        {
            child = gameObject.transform.GetChild(i);
            if (child.tag == tagItem)
            {
                //print("Delete");
                oldItem = child.gameObject;
                oldTransform = child;
                break;
            }
        }
        // уничтожение объекта старого итема
        Destroy(oldItem);
        // поиск в weapons по имени нужного итема
        int indexItem = 0;
        while (indexItem < items.Length) 
        {
            if (items[indexItem].name == nameItem)
                break;
            indexItem++;
        }
        //получил индекс элемента можно использовать для прикрепления к игроку!!!
        // и присобачивание его уже как ребенка к игроку
        //ИНДЕКС НЕ ВЕРНЫЙ ПОДУМАТЬ ПОЧЕМУ
        GameObject clone = Instantiate(items[indexItem], gameObject.transform);
        clone.transform.position = new Vector3(oldTransform.transform.position.x,
            oldTransform.transform.position.y, oldTransform.transform.position.z);
        clone.transform.GetChild(0).GetComponent<Weapon>().weaponOnPlayer = true;
    }
}

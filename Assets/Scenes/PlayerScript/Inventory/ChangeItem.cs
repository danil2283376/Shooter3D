using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����� �������� ���������� �������� � ������������ �� ����������
public class ChangeItem : MonoBehaviour
{
    public GameObject[] items;

    public void SearchOldItemDestroy(string nameItem, string tagItem,
           ref Transform oldTransform)
    {
        GameObject oldItem = null;
        Transform child = null;
        // ������ ������ ���� �� ������
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
        Destroy(oldItem);
    }

    public void ChangeItemInHand(string nameItem, string tagItem) 
    {
        //GameObject oldItem = null;
        Transform oldTransform = null;
        //Transform child = null;

        // ������ ������ ���� �� ������
        SearchOldItemDestroy(nameItem, tagItem, ref oldTransform);
        //for (int i = 0; i < gameObject.transform.childCount; i++) 
        //{
        //    child = gameObject.transform.GetChild(i);
        //    if (child.tag == tagItem)
        //    {
        //        //print("Delete");
        //        oldItem = child.gameObject;
        //        oldTransform = child;
        //        break;
        //    }
        //}
        //// ����������� ������� ������� �����
        //Destroy(oldItem);
        // ����� � weapons �� ����� ������� �����
        int indexItem = 0;
        while (indexItem < items.Length) 
        {
            if (items[indexItem].name == nameItem)
                break;
            indexItem++;
        }
        GameObject clone = Instantiate(items[indexItem], gameObject.transform);
        clone.transform.position = new Vector3(oldTransform.transform.position.x,
            oldTransform.transform.position.y, oldTransform.transform.position.z);
        clone.transform.GetChild(0).GetComponent<Weapon>().weaponOnPlayer = true;
    }
}

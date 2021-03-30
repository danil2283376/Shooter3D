using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // ����� �������� ���������� �������� � ������������ �� ����������
public class ChangeItem : MonoBehaviour
{
    public GameObject[] items;

    public void ChangeItemInHand(string nameItem, string tagItem) 
    {
        GameObject oldItem = null;
        Transform oldTransform = null;
        Transform child = null;
        //Transform[] transformChilds = new Transform[gameObject.transform.childCount];

        // ������ ������ ���� �� ������
        //transformChilds = gameObject.GetComponentsInChildren<Transform>();
        //transformChild = gameObject.GetComponentsInChildren<Transform>();
        for (int i = 0; i < gameObject.transform.childCount; i++) 
        {
            //print(transformChilds[i].tag);
            //print(tagItem);
            child = gameObject.transform.GetChild(i);
            if (child.tag == tagItem)
            {
                //print("Delete");
                oldItem = child.gameObject;
                oldTransform = child;
                break;
            }
        }
        // ����������� ������� ������� �����
        Destroy(oldItem);
        //oldItem.transform.localPosition = new Vector3(oldTransform.transform.position.x, oldTransform.transform.position.y, oldTransform.transform.position.z);
        // ����� � weapons �� ����� ������� �����
        int indexItem = 0;
        while (indexItem < items.Length) 
        {
            if (items[indexItem].name == nameItem)
            {
                break;
            }
            indexItem++;
        }
        //������� ������ �������� ����� ������������ ��� ������������ � ������!!!
        // � �������������� ��� ��� ��� ������� � ������
        //������ �� ������ �������� ������
        //print(indexItem);
        //items[indexItem].transform.parent = gameObject.transform;
        GameObject clone = Instantiate(items[indexItem], gameObject.transform);
        clone.transform.position = new Vector3(oldTransform.transform.position.x,
            oldTransform.transform.position.y, oldTransform.transform.position.z);
        //items[indexItem].transform.localPosition = new Vector3(oldTransform.transform.position.x, 
        //    oldTransform.transform.position.y, oldTransform.transform.position.z);
    }
}

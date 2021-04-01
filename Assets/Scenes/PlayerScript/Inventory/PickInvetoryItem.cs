using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PickInvetoryItem : MonoBehaviour
{
    public Color standartColor;
    public Color clickColor;
    public GameObject[] cells;
    // ������� ����� ������������ � ���������
    public KeyCode maxCeills;
    public Vector3 sizeCeillsInPick = new Vector3(1, 1, 1);

    private ChangeItem scriptChangeItem;
    private Image imageCells;
    private RectTransform transformCells;
    private Vector3 oldSizeCeills;
    private void Start()
    {
        // ������� �������� ������
        imageCells = cells[0].GetComponent<Image>();
        // ������������ ����
        imageCells.color = clickColor;
        // ������� RectTransform ������
        transformCells = cells[0].GetComponent<RectTransform>();
        // ������� ������ ������ ������
        oldSizeCeills = transformCells.localScale;
        // ����� ����� �������
        transformCells.localScale = sizeCeillsInPick;//new Vector3(1.15f, 1.21f, 1f);
        // ������� ������ ������� �����
        scriptChangeItem = gameObject.GetComponent<ChangeItem>();
    }

    // �������� ������� �������
    private void OnGUI()
    {
        KeyCode keyCode = 0;
        // ����� ����� �� ����� �������
        if (Event.current.isKey)
        {
            // ������� ������� KeyCode ������� �������
            keyCode = Event.current.keyCode;
            if (keyCode >= KeyCode.Alpha1 && keyCode <= maxCeills) 
            {
                // ������� ����������� �������
                int number = (int)keyCode;
                int numberButton = 0;
                // ���� �������� ������� � ���������� ��� � int
                // ����� ����� � numberButton ������ �� �������
                // ����� ���������� ��������
                int.TryParse(Input.inputString, out numberButton);
                // ������� ���� ���
                if (numberButton != 0)
                {
                    print(numberButton);
                    ChangeItemInGUI(numberButton - 1);
                    SelectItemInInventory(numberButton - 1);
                }
            }
        }
    }

    public void ChangeItemInGUI(int indexButton) 
    {
        if (indexButton < cells.Length)
        {
            transformCells.localScale = oldSizeCeills;
            imageCells.color = standartColor;
            transformCells = cells[indexButton].GetComponent<RectTransform>();
            transformCells.localScale = sizeCeillsInPick;
            imageCells = cells[indexButton].GetComponent<Image>();
            imageCells.color = clickColor;
        }
    }

    void SelectItemInInventory(int indexButton) 
    {
        // ���� ���� ���� ������ ������������ ������� �������� ������� �����
        if (indexButton < cells.Length)
        {
            // �������� sprite
            if (cells[indexButton].GetComponent<Image>().sprite != null)
                scriptChangeItem.ChangeItemInHand(
                    cells[indexButton].GetComponent<Image>().sprite.name,
                        "Drop");
            ChangeItemInGUI(indexButton);
        }
    }
}

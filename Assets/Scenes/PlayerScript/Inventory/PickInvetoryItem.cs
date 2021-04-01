using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PickInvetoryItem : MonoBehaviour
{
    public Color standartColor;
    public Color clickColor;
    public GameObject[] cells;
    // выбираю цифру максимальную в инвентаре
    public KeyCode maxCeills;
    public Vector3 sizeCeillsInPick = new Vector3(1, 1, 1);

    private ChangeItem scriptChangeItem;
    private Image imageCells;
    private RectTransform transformCells;
    private Vector3 oldSizeCeills;
    private void Start()
    {
        // получаю картинку ячейки
        imageCells = cells[0].GetComponent<Image>();
        // устанавливаю цвет
        imageCells.color = clickColor;
        // получаю RectTransform ячейки
        transformCells = cells[0].GetComponent<RectTransform>();
        // получаю старый размер клетки
        oldSizeCeills = transformCells.localScale;
        // задаю новые размеры
        transformCells.localScale = sizeCeillsInPick;//new Vector3(1.15f, 1.21f, 1f);
        // получаю скрипт Измения итема
        scriptChangeItem = gameObject.GetComponent<ChangeItem>();
    }

    // проверка нажатых клавишь
    private void OnGUI()
    {
        KeyCode keyCode = 0;
        // узнаю нажал ли игрок клавишу
        if (Event.current.isKey)
        {
            // получаю текущий KeyCode нажатой клавиши
            keyCode = Event.current.keyCode;
            if (keyCode >= KeyCode.Alpha1 && keyCode <= maxCeills) 
            {
                // Сделать регистрацию клавишь
                int number = (int)keyCode;
                int numberButton = 0;
                // беру название клавиши и преобразую его в int
                // ответ кладу в numberButton дальше по индексу
                // можно обращаться спокойно
                int.TryParse(Input.inputString, out numberButton);
                // клавиши ноль нет
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
        // фикс бага если нажать одновременно клавиши вылетает большое число
        if (indexButton < cells.Length)
        {
            // проверяю sprite
            if (cells[indexButton].GetComponent<Image>().sprite != null)
                scriptChangeItem.ChangeItemInHand(
                    cells[indexButton].GetComponent<Image>().sprite.name,
                        "Drop");
            ChangeItemInGUI(indexButton);
        }
    }
}

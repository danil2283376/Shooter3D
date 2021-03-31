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
    private void Start()
    {
        Image imageCells = cells[0].GetComponent<Image>();
        imageCells.color = clickColor;
    }

    // проверка нажатых клавишь
    private void OnGUI()
    {
        KeyCode keyCode = 0;
        // узнаю нажал ли игрок клавишу
        if (Event.current.isKey)
        {
            keyCode = Event.current.keyCode;
            if (keyCode >= KeyCode.Alpha1 && keyCode <= maxCeills) 
            {
                // Сделать регистрацию клавишь
            }
        }
    }
}

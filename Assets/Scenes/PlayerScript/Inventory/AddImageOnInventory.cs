using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AddImageOnInventory : MonoBehaviour
{
    // клеточки
    public GameObject[] cells;
    // спрайты предметов
    public Sprite[] itemSprite;
    public char numberCells;
    private int numberAscii;
    private ChangeItem scriptChangeItem;
    private PickInvetoryItem scriptChangeCells;
    // Start is called before the first frame update
    void Start()
    {
        // преобразую в кейкод через таблицу Ascii
        numberAscii = numberCells;
        scriptChangeItem = gameObject.GetComponent<ChangeItem>();
        scriptChangeCells = GetComponent<PickInvetoryItem>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey((KeyCode)numberAscii))
        //{

        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        // сделать "Items"
        if (other.transform.tag == "Drop")
        {
            AddImageOnGUI(other.transform.name);
            scriptChangeItem.ChangeItemInHand(other.name, other.tag);
            Destroy(other.gameObject);
        }
    }
    void AddImageOnGUI(string nameItem) 
    {
        Sprite sprite = null;
        // поиск спрайта по названию
        for (int i = 0; i < itemSprite.Length; i++)
        {
            if (nameItem == itemSprite[i].name)
            {
                sprite = itemSprite[i];
                break;
            }
        }
        // поиск свободной клетки инвентаря
        for (int i = 0; i < cells.Length; i++)
        {
            Image componentImage = cells[i].GetComponent<Image>();
            if (componentImage.sprite == null)
            {
                componentImage.sprite = sprite;
                scriptChangeCells.ChangeItemInGUI(i);
                break;
            }
        }
    }
}

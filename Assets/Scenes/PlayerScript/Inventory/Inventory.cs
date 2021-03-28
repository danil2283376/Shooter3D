using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject[] cells;
    public Sprite[] itemSprite;
    public Sprite[] sprites;
    public char numberCells;
    // Start is called before the first frame update
    private int numberAscii;
    void Start()
    {
        // преобразую в кейкод через таблицу Ascii
        numberAscii = numberCells;
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
        }
    }
    void AddImageOnGUI(string nameItem) 
    {
        print(itemSprite[0].name);
        //Image imageItem = null;
        Sprite sprite = null;
        // поиск спрайта по названию
        for (int i = 0; i < itemSprite.Length; i++)
        {
            if (nameItem == itemSprite[i].name)
            {
                //ЭЛЕМЕНТ СПРАЙТА НЕ СУЩЕСЕСТВУЕТ ПРИДУМАТЬ КАК СДЕЛАТЬ ТАК
                //ЧТО БЫ СУЩЕСТВОВАЛ
                //Sprite sprite = Resources.Load("kalash", typeof(Sprite)) as Sprite;
                sprite = itemSprite[i];//sprites[i].GetComponent<SpriteRenderer>().sprite;
                break;
            }
        }
        // поиск свободной клетки инвентаря
        for (int i = 0; i < cells.Length; i++)
        {
            Image componentImage = cells[i].GetComponent<Image>();
            if (componentImage.sprite == null)
            {
                componentImage.sprite = sprite;//imageItem.sprite;
                break;
            }
        }
    }
}

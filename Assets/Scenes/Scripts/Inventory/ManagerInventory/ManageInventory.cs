using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageInventory : MonoBehaviour
{
    public List<GameObject> inventoryItems;
    public List<GameObject> fastItems;

    private GameObject playerHand;

    private void Awake()
    {
        playerHand = GameObject.Find("Hand");
    }
    private void OnGUI()
    {
        if (Event.current.isKey)
        {
            KeyCode keyCode = Event.current.keyCode;
            if (keyCode >= KeyCode.Alpha1 && keyCode <= KeyCode.Alpha7)
            {
                int number = (int)keyCode;
                int numberButton = 0;

                int.TryParse(Input.inputString, out numberButton);
                if (numberButton != 0)
                {
                    //print(numberButton);
                    ChangeItemInHand();
                }
            }

        }
    }

    void ChangeItemInHand() 
    {

    }
}

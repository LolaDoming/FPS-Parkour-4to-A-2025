using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroManagment : MonoBehaviour
{
    public float playerMoney;
    public UIManager UIManager;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        uiManager.UpdateTxTMoney(playerMoney);
    }

    public void UpdateMoney(float amount)
    {

        if (playerMoney + amount < 0)
        {
            //impedir compra
            return false;
        }
        else
        {
            playerMoney += amount;
            UIManager.UpdateMoneyUI(playerMoney);
            return true;
        }
    }

}

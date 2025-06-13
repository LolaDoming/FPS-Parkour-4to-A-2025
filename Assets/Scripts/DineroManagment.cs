﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroManagment : MonoBehaviour
{
    public float playerMoney;
    public UIManager UIManager;
    public bool UpdateMoney(float amount)
    {
        playerMoney += amount;

        if (playerMoney + amount < 0)
        {
            //impedir compra
            return false;
        }
        else
        {
            playerMoney += amount;
            UIManager.UpdateMoneyUI(playerMoney.ToString());
            return true;
        }
    }
    private void Start()
    {
        UIManager.UpdateMoneyUI(playerMoney.ToString());
    }

}

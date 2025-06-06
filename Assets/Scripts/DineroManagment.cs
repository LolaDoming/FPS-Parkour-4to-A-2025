using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroManagment : MonoBehaviour
{
    public float playerMoney;
    public UIManager UIManager;
    public void UpdateMoney(float amount)
    {
        playerMoney += amount;

        if (playerMoney + amount < 0)
        {
            //impedir compra
        }
        else
        {
            playerMoney += amount;
            UIManager.UpdateMoneyUI(playerMoney.ToString());
        }
    }
    //public void texto()
    //UIManager.UpdateMoney(-precio)
        
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtingObjects : MonoBehaviour
{
    public int playerHealth;
    public UIManager UIManager;
    public bool UpdateHealth(int salud);
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
            UIManager.UpdateHealthUI(playerHealth.ToString());
            return true;
        }
    }
    private void Start()
    {
        UIManager.UpdateHealthUI(playerHealth.ToString());
    }

}

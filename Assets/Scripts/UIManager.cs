using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text moneyTexto;
    float Money;

    public TMP_Text healthText;
    float Health;


    public void UpdateTxTMoney(float money)
    {
      Money = money;
      moneyTexto.text = "Plata: " + Money.ToString();
    }
    public void UpdateTXTHealth(float health)
    {  
    Health = health;
    healthText.text = "Salud: " + Health.ToString();
    }

}

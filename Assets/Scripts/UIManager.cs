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

void Start()
{
    moneyText.text = "Plata: " + Money.ToString();
    healthText.text = "Salud: " + Health.ToString();
}

public void UpdateTxTMoney(float money)
{
    Money = money;
    moneyText.text = "Plata: " + Money.ToString();
}
public void UpdateTXTHealth(float health)
{
    Health = health;
    healthText.text = "Salud: " + Health.ToString();
}

}

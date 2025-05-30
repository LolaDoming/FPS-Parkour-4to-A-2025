using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public int precio;
    public DineroManagment dineroManager;

    private void Start()
    {
        dineroManager = FindObjectOfType<DineroManagment>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            //restar precio al dinero del player
            dineroManager.UpdateMoney(precio);
            Destroy(gameObject);
        }
    }
}

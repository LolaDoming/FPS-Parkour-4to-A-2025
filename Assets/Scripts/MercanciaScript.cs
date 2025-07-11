using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
<<<<<<< HEAD
    public int precio = 10;
    public DineroManager dineroManager;

    void Start()
    {
        dineroManager = FindObjectOfType<DineroManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //restar precio al dinero del player
            if (dineroManager.UpdateMoney(-precio))
            {
                Destroy(gameObject);
            }            
        } 
=======
    public float precio;
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
            if(dineroManager.UpdateMoney(-precio));
            {
                Destroy(gameObject);
            }
           
        }
>>>>>>> 9ccd5404a6b304fa37a88fd02aaf05e3bf470f2e
    }
}

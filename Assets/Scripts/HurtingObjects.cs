    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtingObjects : MonoBehaviour
{
    public float damage;
    public HealthManager healthManager;

    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            healthManager.UpdateHealth(damage);
        }
    }

}

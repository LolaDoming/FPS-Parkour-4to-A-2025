using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
   void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto con " + collision.gameObject.name);
<<<<<<< HEAD
        Destroy(collision.gameObject);
=======
        Destroy(collision.gameObject); // el objeto que tiene el script
>>>>>>> 9ccd5404a6b304fa37a88fd02aaf05e3bf470f2e
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public string collisionObjectName = "OfficeChair_1"; // il nome dell'oggetto con cui l'oggetto corrente deve collidere per essere distrutto

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == collisionObjectName)
        {
            Destroy(gameObject);
        }
    }
}

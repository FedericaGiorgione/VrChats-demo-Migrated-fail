using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Connect : UdonSharpBehaviour
{
    public GameObject GameObject2; // Riferimento al secondo GameObject da unire
    public GameObject mergedObjectPrefab; // Prefab dell'oggetto unito

    private bool isMerged = false; // Indica se i GameObject sono stati uniti

    private void OnTriggerEnter(Collider other)
    {
        if (!isMerged && other.gameObject == GameObject2)
        {
            // Unisci i due GameObject
            Merge();
        }
    }

    private void Merge()
    {
        // Ottieni la posizione e la rotazione del GameObject1
        Vector3 position = transform.position;
        Quaternion rotation = transform.rotation;

        // Crea una nuova istanza dell'oggetto unito utilizzando il prefab
        GameObject mergedObject = VRCInstantiate(mergedObjectPrefab);
        mergedObject.transform.position = position;
        mergedObject.transform.rotation = rotation;

        // Sposta il GameObject1 e GameObject2 sotto il nuovo GameObject
        transform.parent = mergedObject.transform;
        GameObject2.transform.parent = mergedObject.transform;

        // Disabilita i collider del GameObject1 e GameObject2
        Collider collider1 = GetComponent<Collider>();
        if (collider1 != null)
        {
            collider1.enabled = false;
        }

        Collider collider2 = GameObject2.GetComponent<Collider>();
        if (collider2 != null)
        {
            collider2.enabled = false;
        }

        isMerged = true;
    }
}
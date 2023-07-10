using UnityEngine;

public class AccessLocalPlayer : MonoBehaviour
{
    private void Start()
    {
        // Accedi al giocatore locale
        GameObject localPlayer = GameObject.FindWithTag("PlayerLocal");

        if (localPlayer != null)
        {
            // Ottieni la posizione della testa del giocatore locale
            Transform headTransform = localPlayer.transform.Find("Head");

            if (headTransform != null)
            {
                // Accedi alla posizione della testa
                Vector3 headPosition = headTransform.position;

                // Utilizza la posizione della testa come preferisci
                Debug.Log("Posizione della testa del giocatore locale: " + headPosition);
            }
            else
            {
                Debug.LogError("Impossibile trovare il transform 'Head' del giocatore locale.");
            }
        }
        else
        {
            Debug.LogError("Impossibile trovare il GameObject del giocatore locale.");
        }
    }
}
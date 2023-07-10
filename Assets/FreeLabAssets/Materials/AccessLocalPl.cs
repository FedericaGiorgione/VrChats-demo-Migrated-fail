using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using static VRC.SDKBase.VRCPlayerApi;

public class AccessLocalPl : UdonSharpBehaviour
{
    public Transform headTransform; // Riferimento al transform della testa del giocatore locale

    private void Start()
    {
        // Accedi al giocatore locale
        VRCPlayerApi localPlayer = Networking.LocalPlayer;

        if (localPlayer != null)
        {
            if (headTransform != null)
            {
                // Ottieni il GameObject del giocatore locale utilizzando l'API di VRCPlayerApi
                //GameObject localPlayerGameObject = localPlayer.gameObject;
                // Ottieni il transform della testa del giocatore locale
                //Transform localPlayerHeadTransform = localPlayer.transform.Find("Head");
                Vector3 headPos = localPlayer.GetTrackingData(TrackingDataType.Head).position;

                if (headPos != null)
                {
                    // Accedi alla posizione della testa del giocatore locale
                    Vector3 headPosition = headPos;

                    // Utilizza la posizione della testa come preferisci
                    Debug.Log("Posizione della testa del giocatore locale: " + headPosition);
                }
                else
                {
                    Debug.LogError("Il transform della testa non è stato trovato.");
                }
            }
            else
            {
                Debug.LogError("Il transform della testa non è stato assegnato.");
            }
        }
        else
        {
            Debug.LogError("Impossibile accedere al giocatore locale.");
        }
    }
}
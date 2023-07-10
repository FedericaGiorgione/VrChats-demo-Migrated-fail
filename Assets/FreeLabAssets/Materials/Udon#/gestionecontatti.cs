using UnityEngine;
using UnityEngine.UI;

public class gestionecontatti : MonoBehaviour
{
    private int elementACounter = 0; // Contatore degli elementi A
    [SerializeField] private Button button; // Riferimento al button nel canvas locale

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Assicurarsi che il riferimento al button sia stato assegnato correttamente
            if (button != null)
            {
                // Incrementare il contatore degli elementi A
                elementACounter++;

                // Aggiornare il testo del contatore nel button
                Text counterText = button.GetComponentInChildren<Text>();
                if (counterText != null)
                {
                    counterText.text = "Elementi A: " + elementACounter.ToString();
                }
                else
                {
                    Debug.LogError("Riferimento al testo del contatore mancante nel button!");
                }
            }
            else
            {
                Debug.LogError("Riferimento al button mancante!");
            }
        }
    }
}
using UnityEngine;

public class DontDestroyOnLoadPrinter : MonoBehaviour
{
    public string layerName = "Default";
    public Transform elementA;
    public GameObject elementB;
    public CharacterController cC;
    public GameObject gg;

    private void Start()
    {
        int layerID = LayerMask.NameToLayer(layerName);
        

        if (layerID == -1)
        {
            Debug.LogError("Il nome del layer non è valido!");
            return;
        }
        GameObject[] layerObjects = FindObjectsOfType<GameObject>();
        foreach (GameObject obj in layerObjects)
        {
            if (obj.layer == layerID)
            {
                Debug.Log("Questo elemento: " + obj.name);
                foreach (Transform child in obj.transform)
                {
                 
                    if(child.name == "PlayerController")
                    {
                       Debug.Log("TROVATO");
                        gg.SetActive(true);
                        /*foreach(Transform cild in obj.transform)
                        {
                            if(cild.name == "DesktopTrackingData")
                            {
                                Debug.Log("questa è la sua altezza: " + elementA);
                                elementA = cild.transform;
                                
                            }
                        }*/
                        cC = child.GetComponent<CharacterController>();
                        if (cC != null)
                        {
                            //cC.height = 0.4f;
                        }
                    }
                }
            }
        }
    }
    private void Update()
    {
        if(cC!= null) { 
        Debug.Log("siamo all'update " + cC.height);
        }
        /*if (elementA != null && cC != null)
        {
            float elementAY = elementA.position.y;
            if (elementAY == 1.75f)
            {
                cC.height = 1.6f;
            }
            else
            {
                cC.height = 0.9f;
            }
        }
*/
    }
}
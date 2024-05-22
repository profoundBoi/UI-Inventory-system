using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockManager : MonoBehaviour
{
    public GameObject[] objectsToActivate; // Array of objects to be activated
    public Button buttonToDestroy;         // Reference to the button
    public MoneyManager moneySystem;

    // Method to activate objects and destroy the button
    public void ActivateAllObjects()
    { if(moneySystem.money >= moneySystem.UnlockPrice)
        // Activate all objects in the array
        foreach (GameObject obj in objectsToActivate)
        {
            obj.SetActive(true);
                moneySystem.DeductButton9();
            }

        // Destroy the button
        Destroy(buttonToDestroy.gameObject);
    }
}

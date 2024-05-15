using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellObject : MonoBehaviour
{
    public int sellPrice = 10; // Set the selling price here

    private void OnMouseDown()
    {
        Sell();
    }

    private void Sell()
    {
        // Add the sell price to the player's currency or whatever system you have for tracking currency
        // For demonstration purposes, let's just print the sold amount
        Debug.Log("Sold for: " + sellPrice);

        // Destroy the object after selling
        Destroy(gameObject);
    }

}

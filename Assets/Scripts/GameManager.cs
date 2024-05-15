using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public float Balance { get; private set; }
    public static Action OnBalanceChanged { get; internal set; }

    public Text balanceText; // Reference to the Text UI element

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Balance = 100f; // Initial balance
        UpdateBalanceUI();
    }

    public void UpdateBalance(float amount)
    {
        Balance += amount;
        UpdateBalanceUI();
    }

    private void UpdateBalanceUI()
    {
        balanceText.text = "Balance: $" + Balance.ToString("0.00"); // Update the Text UI element with the balance
    }
}

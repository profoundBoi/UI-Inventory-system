using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public int money = 100;
    public Text moneyText;
    public int RShieldPrice = 10;
    public int RedBottlePrice = 20;
    public int PShieldPrice = 10;
    public int PinkBottlePrice = 20;
    public int GShieldPrice = 10;
    public int GreenBottlePrice = 20;
    public int BShieldPrice = 10;
    public int BlueBottlePrice = 20;
    
    public Transform boxAboveButton;
    private void Start()
    {
        UpdateMoneyText();
    }
    public void UpdateMoneyText()
    {
        moneyText.text = "Money: $" + money.ToString();
    }
    public void DeductButton1()
    {
        if (money >= 10)
        {
            money -= RShieldPrice;
            UpdateMoneyText();
        }
    }
    public void DeductButton2()
    {
        if (money >= 20)
        {
            money -= RedBottlePrice;
            UpdateMoneyText();
        }

    }
    public void DeductButton3()
    {
        if (money >= 10)
        {
            money -= PShieldPrice;
            UpdateMoneyText();
        }

    }
    public void DeductButton4()
    {
        if (money >= 20)
        {
            money -= PinkBottlePrice;
            UpdateMoneyText();
        }
    }
    public void DeductButton5()
    {
        if (money >= 10)
        {
            money -= GShieldPrice;
            UpdateMoneyText();
        }
    }
    public void DeductButton6()
    {
        if (money >= 20)
        {
            money -= GreenBottlePrice;
            UpdateMoneyText();
        }
    }
    public void DeductButton7()
    {
        if (money >= 10)
        {
            money -= BShieldPrice;
            UpdateMoneyText();
        }
    }
    public void DeductButton8()
    {
        if (money >= 20)
        {
            money -= BlueBottlePrice;
            UpdateMoneyText();
        }
    }
    public void ChocolateBarSell()
    {
        money += RShieldPrice;
        UpdateMoneyText();
    }

    public void GummyBearSell()
    {
        money += RedBottlePrice;
        UpdateMoneyText();
    }

    public void DonutSell()
    {
        money += PShieldPrice;
        UpdateMoneyText();
    }

    public void LollipopSell()
    {
        money += PinkBottlePrice;
        UpdateMoneyText();
    }

    public void CandyCaneSell()
    {
        money += GShieldPrice;
        UpdateMoneyText();
    }

    public void StrawberrySell()
    {
        money += GreenBottlePrice;
        UpdateMoneyText();
    }

    public void GingerBreadSell()
    {
        money += BShieldPrice;
        UpdateMoneyText();
    }

    public void CakePopSell()
    {
        money += BlueBottlePrice;
        UpdateMoneyText();
    }
}

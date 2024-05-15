using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellButtonManager : MonoBehaviour
{
    public GameObject RShield;
    public GameObject RedBottle;
    public GameObject PShield;
    public GameObject PinkBottle;
    public GameObject GShield;
    public GameObject GreenBottle;
    public GameObject BShield;
    public GameObject BlueBottle;
    
    private int RShieldPrice = 10;
    private int RedBottlePrice = 20;
    private int PShieldPrice = 10;
    private int PinkBottlePrice = 20;
    private int GShieldPrice = 10;
    private int GreenBottlePrice = 20;
    private int BShieldPrice = 10;
    private int BlueBottlePrice = 20;
    
    public MoneyManager moneySystem;
    public LayerMask layerMask;
    public float raycastDistance = 1.0f;
    public GameObject inSlot1;
    [SerializeField]
    Transform [] Slots ;
    public void Sell(GameObject slot)
    {
        
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, raycastDistance, layerMask);

            if (slot.transform.GetChild(0) != null)
            {
                moneySystem.money += slot.transform.GetComponentInChildren<Item>().price;
                //moneySystem.money += RShieldPrice;
                moneySystem.UpdateMoneyText();
                Destroy(slot.transform.GetChild(0).gameObject);
            }
            else
            {
                return;
            }







        //if (hit.collider != null)
        //{
        //    GameObject objectAboveButton = hit.collider.gameObject;
        //    Destroy(objectAboveButton);
        //    Debug.Log("Object aboce button:" + objectAboveButton);


        //    if (objectAboveButton.name == "RShield(Clone)")
        //    {
        //        moneySystem.money += RShieldPrice;
        //        moneySystem.UpdateMoneyText();
        //    }
        //    if (objectAboveButton.name == "RedBottle(Clone)")
        //    {
        //        moneySystem.money += RedBottlePrice;
        //        moneySystem.UpdateMoneyText();
        //    }
        //    if (objectAboveButton.name == "PShield(Clone)")
        //    {
        //        moneySystem.money += PShieldPrice;
        //        moneySystem.UpdateMoneyText();
        //    }
        //    if (objectAboveButton.name == "PinkBottle(Clone)")
        //    {
        //        moneySystem.money += PinkBottlePrice;
        //        moneySystem.UpdateMoneyText();
        //    }
        //    if (objectAboveButton.name == "GShield(Clone)")
        //    {
        //        moneySystem.money += GShieldPrice;
        //        moneySystem.UpdateMoneyText();
        //    }
        //    if (objectAboveButton.name == "GreenBottle(Clone)")
        //    {
        //        moneySystem.money += GreenBottlePrice;
        //        moneySystem.UpdateMoneyText();
        //    }
        //    if (objectAboveButton.name == "BShield(Clone)")
        //    {
        //        moneySystem.money += BShieldPrice;
        //        moneySystem.UpdateMoneyText();
        //    }
        //    if (objectAboveButton.name == "BlueBottle(Clone)")
        //    {
        //        moneySystem.money += BlueBottlePrice;
        //        moneySystem.UpdateMoneyText();
        //    }
        //}
        //else
        //{
        //    Debug.Log("No object");
        //}


    }

}

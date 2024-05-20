using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyButtonManager : MonoBehaviour
{
    public Transform[] Slots;
    public MoneyManager moneySystem;
    public GameObject RShield;
    public GameObject RedBottle;
    public GameObject PShield;
    public GameObject PinkBottle;
    public GameObject GShield;
    public GameObject GreenBottle;
    public GameObject BShield;
    public GameObject BlueBottle;

    public Transform[] StorageSlot;

    public Vector3 sizes = new Vector3(70f, 70f, 0);

    private int Lastpoint = -1;



    public void Buy1()
    {
        if (moneySystem.money >= moneySystem.RShieldPrice)
        {
            int startIndex = Lastpoint + 1;

            if (startIndex >= Slots.Length)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i < Slots.Length; i++)
            {
                Transform space = Slots[i];
                Debug.Log(i);
              
                if (StorageSlot[i].childCount == 0)
                {

                    GameObject CloneObject = Instantiate(RShield, space.position, Quaternion.identity, StorageSlot[i].transform);
                    // CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.3f, 0);
                    CloneObject.transform.position += new Vector3(0, 0.1f, 0); // Adjust position as needed


                    //CloneObject.transform.localScale = sizes;
                    CloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed


                    Lastpoint = i;
                    moneySystem.DeductButton1();

                    return;
                }

            }

        }
    }

    public void Buy2()
    {
        if (moneySystem.money >= moneySystem.RedBottlePrice)
        {
            int startIndex = Lastpoint + 1;

            if (startIndex >= Slots.Length)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i < Slots.Length; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(RedBottle, space.position, Quaternion.identity, StorageSlot[i].transform);
                    //CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.3f, 0);
                    CloneObject.transform.position += new Vector3(0, 0.0f, 0); // Adjust position as needed

                    //CloneObject.transform.localScale = sizes;
                    CloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                    Lastpoint = i;
                    moneySystem.DeductButton2();

                    return;
                }
            }
            for (int i = 0; i < startIndex; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(RedBottle, space.position, Quaternion.identity, StorageSlot[i].transform);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.3f, 0);

                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    moneySystem.DeductButton2();

                    return;
                }
            }
        }
    }

    public void Buy3()
    {
        if (moneySystem.money >= moneySystem.PShieldPrice)
        {
            int startIndex = Lastpoint + 1;

            if (startIndex >= Slots.Length)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i < Slots.Length; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(PShield, space.position, Quaternion.identity, StorageSlot[i].transform);
                    //CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.1f, 0);
                    CloneObject.transform.position += new Vector3(0, 0.0f, 0); // Adjust position as needed

                    // CloneObject.transform.localScale = new Vector3(50, 50, 0);
                    CloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed


                    Lastpoint = i;
                    moneySystem.DeductButton3();

                    return;
                }
            }
            for (int i = 0; i < startIndex; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(PShield, space.position, Quaternion.identity, StorageSlot[i].transform);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.3f, 0);

                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    moneySystem.DeductButton3();

                    return;
                }
            }
        }
    }

    public void Buy4()
    {
        if (moneySystem.money >= moneySystem.PinkBottlePrice)
        {
            int startIndex = Lastpoint + 1;

            if (startIndex >= Slots.Length)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i < Slots.Length; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(PinkBottle, space.position, Quaternion.identity, StorageSlot[i].transform);
                    //CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.5f, 0);
                    CloneObject.transform.position += new Vector3(0, 0.0f, 0); // Adjust position as needed

                    //CloneObject.transform.localScale = sizes;
                    CloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                    Lastpoint = i;
                    moneySystem.DeductButton4();

                    return;
                }
            }
            for (int i = 0; i < startIndex; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(PinkBottle, space.position, Quaternion.identity, StorageSlot[i].transform);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.3f, 0);

                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    moneySystem.DeductButton4();

                    return;
                }
            }
        }
    }

    public void Buy5()
    {
        if (moneySystem.money >= moneySystem.GShieldPrice)
        {
            int startIndex = Lastpoint + 1;

            if (startIndex >= Slots.Length)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i < Slots.Length; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(GShield, space.position, Quaternion.identity, StorageSlot[i].transform);
                    //CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.5f, 0);
                    CloneObject.transform.position += new Vector3(0, 0.0f, 0); // Adjust position as needed

                    //CloneObject.transform.localScale = sizes;
                    CloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                    Lastpoint = i;
                    moneySystem.DeductButton5();

                    return;
                }
            }
            for (int i = 0; i < startIndex; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(GShield, space.position, Quaternion.identity, StorageSlot[i].transform);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.3f, 0);

                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    moneySystem.DeductButton5();

                    return;
                }
            }
        }
    }

    public void Buy6()
    {
        if (moneySystem.money >= moneySystem.GreenBottlePrice)
        {
            int startIndex = Lastpoint + 1;

            if (startIndex >= Slots.Length)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i < Slots.Length; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(GreenBottle, space.position, Quaternion.identity, StorageSlot[i].transform);
                    //CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.2f, 0);
                    CloneObject.transform.position += new Vector3(0, 0.0f, 0); // Adjust position as needed

                    //CloneObject.transform.localScale = sizes;
                    CloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                    Lastpoint = i;
                    moneySystem.DeductButton6();

                    return;
                }
            }
            for (int i = 0; i < startIndex; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(GreenBottle, space.position, Quaternion.identity, StorageSlot[i].transform);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0f, 0);

                    CloneObject.transform.localScale = new Vector3(200, 200, 0);

                    Lastpoint = i;
                    moneySystem.DeductButton6();

                    return;
                }
            }
        }
    }

    public void Buy7()
    {
        if (moneySystem.money >= moneySystem.BShieldPrice)
        {
            int startIndex = Lastpoint + 1;

            if (startIndex >= Slots.Length)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i < Slots.Length; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(BShield, space.position, Quaternion.identity, StorageSlot[i].transform);
                    //CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.5f, 0);
                    CloneObject.transform.position += new Vector3(0, 0.0f, 0); // Adjust position as needed

                    //CloneObject.transform.localScale = sizes;
                    CloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                    Lastpoint = i;
                    moneySystem.DeductButton7();

                    return;
                }
            }
            for (int i = 0; i < startIndex; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(BShield, space.position, Quaternion.identity, StorageSlot[i].transform);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.3f, 0);

                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    moneySystem.DeductButton7();

                    return;
                }
            }
        }
    }
    public void Buy8()
    {
        if (moneySystem.money >= moneySystem.BlueBottlePrice)
        {
            int startIndex = Lastpoint + 1;

            if (startIndex >= Slots.Length)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i < Slots.Length; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(BlueBottle, space.position, Quaternion.identity, StorageSlot[i].transform);
                    //CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.4f, 0);
                    CloneObject.transform.position += new Vector3(0, 0.0f, 0); // Adjust position as needed

                    //CloneObject.transform.localScale = new Vector3(40, 40, 0);
                    CloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                    Lastpoint = i;
                    moneySystem.DeductButton8();

                    return;
                }
            }
            for (int i = 0; i < startIndex; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(BlueBottle, space.position, Quaternion.identity, StorageSlot[i].transform);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.3f, 0);

                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    moneySystem.DeductButton8();

                    return;
                }
            }
        }
    }
}

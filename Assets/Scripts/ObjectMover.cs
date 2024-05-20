using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ObjectMover : MonoBehaviour
{
    public Transform[] Slots; // Array of slots where objects can be placed

    public Transform[] StorageSlot; // Array of storage slots where objects can be moved
    public Button[] MoveButton; // Button to trigger the move action
    private List<GameObject> clonedObjects = new List<GameObject>(); // List to track cloned objects

    private int lastPoint = -1;
     public Vector3 sizes = new Vector3(70f, 70f, 0);



    void Start()
    {
        for (int i = 0; i < MoveButton.Length; i++)
        {
            int index = i; // Capture the index to avoid closure issues
            MoveButton[index].onClick.AddListener(() => MoveObjectToNextSlot(index)); // Add listener to the button
        }
    }


    public void MoveObjectToNextSlot(int objectIndex)
    {
        // Assuming you have a way to get the original object based on index
        GameObject originalObject = GetOriginalObjectByIndex(objectIndex);
        CloneObject(originalObject);
    }

    private void CloneObject(GameObject originalObject)
    {
        throw new NotImplementedException();
    }

    private GameObject GetOriginalObjectByIndex(int objectIndex)
    {
        throw new NotImplementedException();
    }

    public void CloneObject1(GameObject originalObject)
    {
        int startIndex = lastPoint + 1;
        if (startIndex >= Slots.Length)
        {
            startIndex = 0;
        }

        for (int i = startIndex; i < Slots.Length; i++)
        {
            Transform space = Slots[i];
           
            if (StorageSlot[i].childCount == 0)
            {

                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(8.8f, 0.0f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.05f, 1.05f, 0.5f); // Adjust scale as needed
                cloneObject.transform.parent = StorageSlot[i].transform;
                Destroy(originalObject.GetComponentInChildren<Image>().gameObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
  
        }
        for (int i = 0; i < startIndex; i++)
        {
            Transform space = Slots[i];
            //Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);
            if (StorageSlot[i].childCount == 0)
            {

                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(8.8f, 0.0f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.05f, 1.05f, 0.5f); // Adjust scale as needed
                cloneObject.transform.parent = StorageSlot[i].transform;
                Destroy(originalObject.GetComponentInChildren<Image>().gameObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
    }
    public void CloneObject2(GameObject originalObject)
    {
        int startIndex = lastPoint + 1;
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
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(7.0f, 0.0f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.05f, 1.05f, 0.5f); // Adjust scale as needed
                Debug.Log(originalObject);
                
                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
        for (int i = 0; i < startIndex; i++)
        {
            Transform space = Slots[i];
            Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

            if (colliders.Length == 0)
            {
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(0, 0.1f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
    }
    public void CloneObject3(GameObject originalObject)
    {
        int startIndex = lastPoint + 1;
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
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(7.0f, 0.0f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.05f, 1.05f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
        for (int i = 0; i < startIndex; i++)
        {
            Transform space = Slots[i];
            Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

            if (colliders.Length == 0)
            {
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(0, 0.1f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
    }
    public void CloneObject4(GameObject originalObject)
    {
        int startIndex = lastPoint + 1;
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
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(7.0f, 0.0f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.05f, 1.05f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
        for (int i = 0; i < startIndex; i++)
        {
            Transform space = Slots[i];
            Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

            if (colliders.Length == 0)
            {
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(0, 0.1f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
    }

    public void CloneObject5(GameObject originalObject)
    {
        int startIndex = lastPoint + 1;
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
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(7.0f, 0.0f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.05f, 1.05f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
        for (int i = 0; i < startIndex; i++)
        {
            Transform space = Slots[i];
            Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

            if (colliders.Length == 0)
            {
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(0, 0.1f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
    }

    public void CloneObject6(GameObject originalObject)
    {
        int startIndex = lastPoint + 1;
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
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(7.0f, 0.0f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.05f, 1.05f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
        for (int i = 0; i < startIndex; i++)
        {
            Transform space = Slots[i];
            Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

            if (colliders.Length == 0)
            {
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(0, 0.1f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
    }

    public void CloneObject7(GameObject originalObject)
    {
        int startIndex = lastPoint + 1;
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
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(7.0f, 0.0f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.05f, 1.05f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
        for (int i = 0; i < startIndex; i++)
        {
            Transform space = Slots[i];
            Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

            if (colliders.Length == 0)
            {
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(0, 0.1f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
    }

    public void CloneObject8(GameObject originalObject)
    {
        int startIndex = lastPoint + 1;
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
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(7.0f, 0.0f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.05f, 1.05f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
        for (int i = 0; i < startIndex; i++)
        {
            Transform space = Slots[i];
            Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

            if (colliders.Length == 0)
            {
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(0, 0.1f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
    }

    public void CloneObject9(GameObject originalObject)
    {
        int startIndex = lastPoint + 1;
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
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(7.0f, 0.0f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.05f, 1.05f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
        for (int i = 0; i < startIndex; i++)
        {
            Transform space = Slots[i];
            Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

            if (colliders.Length == 0)
            {
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(0, 0.1f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
    }

    public void CloneObject10(GameObject originalObject)
    {
        int startIndex = lastPoint + 1;
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
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(7.0f, 0.0f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.05f, 1.05f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
        for (int i = 0; i < startIndex; i++)
        {
            Transform space = Slots[i];
            Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

            if (colliders.Length == 0)
            {
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(0, 0.1f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
    }

    public void CloneObject11(GameObject originalObject)
    {
        int startIndex = lastPoint + 1;
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
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(7.0f, 0.0f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.05f, 1.05f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
        for (int i = 0; i < startIndex; i++)
        {
            Transform space = Slots[i];
            Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

            if (colliders.Length == 0)
            {
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(0, 0.1f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
    }

    public void CloneObject12(GameObject originalObject)
    {
        int startIndex = lastPoint + 1;
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
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(7.0f, 0.0f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.05f, 1.05f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
        for (int i = 0; i < startIndex; i++)
        {
            Transform space = Slots[i];
            Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

            if (colliders.Length == 0)
            {
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(0, 0.1f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
    }

    public void CloneObject13(GameObject originalObject)
    {
        int startIndex = lastPoint + 1;
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
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(7.0f, 0.0f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.05f, 1.05f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
        for (int i = 0; i < startIndex; i++)
        {
            Transform space = Slots[i];
            Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

            if (colliders.Length == 0)
            {
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(0, 0.1f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
    }

    public void CloneObject14(GameObject originalObject)
    {
        int startIndex = lastPoint + 1;
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
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(7.0f, 0.0f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.05f, 1.05f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
        for (int i = 0; i < startIndex; i++)
        {
            Transform space = Slots[i];
            Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

            if (colliders.Length == 0)
            {
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(0, 0.1f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
    }

    public void CloneObject15(GameObject originalObject)
    {
        int startIndex = lastPoint + 1;
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
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(7.0f, 0.0f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.05f, 1.05f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
        for (int i = 0; i < startIndex; i++)
        {
            Transform space = Slots[i];
            Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

            if (colliders.Length == 0)
            {
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(0, 0.1f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
    }

    public void CloneObject16(GameObject originalObject)
    {
        int startIndex = lastPoint + 1;
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
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(7.0f, 0.0f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.05f, 1.05f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
        for (int i = 0; i < startIndex; i++)
        {
            Transform space = Slots[i];
            Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

            if (colliders.Length == 0)
            {
                GameObject cloneObject = Instantiate(originalObject, space.position, Quaternion.identity, StorageSlot[i].transform);
                cloneObject.transform.position += new Vector3(0, 0.1f, 0); // Adjust position as needed
                cloneObject.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

                Destroy(originalObject); // Destroy the original object

                lastPoint = i;
                clonedObjects.Add(cloneObject); // Add the cloned object to the list
                return;
            }
        }
    }
    public void MoveObjectToNextSlot()//might need to delete this part of the code #for future.
    {
        if (clonedObjects.Count == 0) return; // Check if there are any cloned objects

        GameObject selectedObject = clonedObjects[clonedObjects.Count - 1]; // Get the last cloned object

        int startIndex = lastPoint + 1;
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
                MoveObject(selectedObject, space, i);
                return;
            }
        }

        for (int i = 0; i < startIndex; i++)
        {
            Transform space = Slots[i];
            Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

            if (colliders.Length == 0)
            {
                MoveObject(selectedObject, space, i);
                return;
            }
        }
    }

    private void MoveObject(GameObject obj, Transform targetSlot, int slotIndex)
    {
        obj.transform.position = targetSlot.position;
        obj.transform.SetParent(StorageSlot[slotIndex]);
        obj.transform.localPosition += new Vector3(750, -5.5f, 0); // Adjust position as needed
        obj.transform.localScale = new Vector3(1.0f, 1.0f, 0.5f); // Adjust scale as needed

        lastPoint = slotIndex; // Update the last point
    }
}


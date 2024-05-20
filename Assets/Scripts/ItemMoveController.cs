using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemMoveController : MonoBehaviour
{
    public Transform[] SourceSlots; // Slots where items are currently located
    public Transform[] TargetSlots; // Slots where items will be moved

    public void MoveChildToSlot(Transform childTransform, int sourceSlotIndex, int targetSlotIndex)
    {
        if (sourceSlotIndex >= 0 && sourceSlotIndex < childTransform.childCount &&
            targetSlotIndex >= 0 && targetSlotIndex < TargetSlots.Length)
        {
            // Get the child transform from the parent
            Transform itemTransform = childTransform.GetChild(sourceSlotIndex);

            // Move the child to the target slot
            itemTransform.SetParent(TargetSlots[targetSlotIndex]);
            itemTransform.localPosition = Vector3.zero; // Reset local position to fit new slot
        }
        else
        {
            Debug.LogError("Invalid slot index!");
        }
    }
}

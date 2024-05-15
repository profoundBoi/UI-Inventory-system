using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragItem : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    [SerializeField] private Canvas canvas;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        if (rectTransform == null)
        {
            Debug.LogError("ERROR: No RectTransform found!");
        }
    }


    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("On drag!");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pointer down!");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin drag!");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End drag!");
        //if it's in the chest then make it a child of the chest
        //find the component for the chest, set the chest as the parent.
        //mouseoverlap code, then check the slot position see if they overlap, them Set as Parent
        //On enddrag, clone the object in the chest and destory the object in the bag. Move the other objects up a slot.
        rectTransform.SetAsLastSibling();
    }

}
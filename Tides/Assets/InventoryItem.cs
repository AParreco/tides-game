using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI; 

public class InventoryItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [Header("UI")]
    public Image image;

    [HideInInspector] public Transform parentAfterDrag;
    [HideInInspector] public Item item;

    public void InitializeItem(Item newItem)
    {
        image.sprite = newItem.image; 
    }


    // Drag and Drop 
    public void OnBeginDrag(PointerEventData eventData)
    {
        image.raycastTarget = false; // stops detecting if it is on an inventory slot
        parentAfterDrag = transform.parent; 
        transform.SetParent(transform.root); 
    }

    public void OnDrag(PointerEventData eventData)
    {
        // while dragging, the item will follow the position of the mouse
        transform.position = Input.mousePosition; 
    }

    public void OnEndDrag(PointerEventData eventData)
    { 
        image.raycastTarget = true;
        transform.SetParent(parentAfterDrag); 
    }
}

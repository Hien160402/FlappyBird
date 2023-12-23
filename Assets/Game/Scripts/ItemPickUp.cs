using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
   public Item Item;
    public void PickUp()
    {
        InventoryManager.instance.Add(Item);
        DestroyObject(gameObject);
    }
    public void OnMouseDown()
    {
        PickUp();
    }
}

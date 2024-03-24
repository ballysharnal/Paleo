using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class InventoryManager : ScriptableObject
{
    public List<ItemSlot> Container = new List<ItemSlot>();
    public void AddItem(Item _item) {
        for (int i = 0; i < Container.Count; i++) {
            if(Container[i].isFull == false) {
                Container[i].AddItem(_item);
                return;
            }
        }
    }
}
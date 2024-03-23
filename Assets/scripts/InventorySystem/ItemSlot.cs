using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    //======ITEM DATA=====//
    public string id;
    public string displayName;
    public string description;
    public Sprite itemSprite;
    public TypeVetementEnum typeVetement;
    public TypeClicheEnum typeCliche;
    public bool isFull;

//=========ITEM SLOT=======//
    public InventoryManager inventory;
    private GameObject item;
    [SerializeField]
 private TMP_Text quantityText;

    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            var item = eventData.pointerDrag.GetComponent<Item>();
            if (item) {
                inventory.AddItem(item);
            }
        }
    }

    public void AddItem(Item _item) {
        this.id = _item.id;
        this.displayName = _item.displayName;
        this.description = _item.description;
        this.itemSprite = _item.itemSprite;
        this.typeVetement = _item.typeVetement;
        this.typeCliche = _item.typeCliche;
        isFull = true;
    }
}
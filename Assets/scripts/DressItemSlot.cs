using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DressItemSlot : MonoBehaviour, IDropHandler
{
    public InventoryManager inventory;
    [SerializeField] private bool isTrash;
    private GameObject gameItem;
 
    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            var item = eventData.pointerDrag.GetComponent<Item>();
            /*if (item) {
                inventory.AddItem(item.item, 1);
            }*/
        }
        if (isTrash == true) {
            Debug.Log("Delete");
            gameItem = eventData.pointerDrag.gameObject;
            StartCoroutine(WaitBeforeDestroyRoutine(.5f));
        }
    }

    public void DestroyItem() {
        if (gameItem != null) {
           Destroy(gameItem); 
        }
    }

    IEnumerator WaitBeforeDestroyRoutine(float duration)
    {
        Debug.Log($"Started at {Time.time}, waiting for {duration} seconds");
        yield return new WaitForSeconds(duration);
        Debug.Log($"Ended at {Time.time}"); 
        DestroyItem();
    }
}

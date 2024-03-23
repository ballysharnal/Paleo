using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SetSpriteImage : MonoBehaviour, IPointerDownHandler
{
    public Image image;
    public Sprite sprite;

    public void OnPointerDown(PointerEventData eventData) {
        this.image.sprite = this.sprite;
    }
}

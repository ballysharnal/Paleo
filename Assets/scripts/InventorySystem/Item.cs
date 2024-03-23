using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject
{
    public int id;
    public string displayName;
    public string description;
    public Sprite itemSprite;
    public TypeVetementEnum typeVetement;
    public TypeClicheEnum typeCliche;

    public void setItemData(int _id, string _displayName, string _description, Sprite _itemSprite, TypeVetementEnum _typeVet, TypeClicheEnum _typeCliche) {
        this.id = _id;
        this.displayName = _displayName;
        this.description = _description;
        this.itemSprite = _itemSprite;
        this.typeVetement = _typeVet;
        this.typeCliche = _typeCliche;
    }
}

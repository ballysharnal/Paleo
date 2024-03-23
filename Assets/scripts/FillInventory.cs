using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillInventory : MonoBehaviour
{
    private int id;
    private string displayName;
    private string description;
    private Sprite itemSprite;
    
    private InventoryManager inventory;
    private Item randomItem;

    private List<Item> randomItemList = new List<Item>();

    private TypeVetementEnum typeVetement;
    private TypeClicheEnum typeCliche;

    public void FillInventoryRandomly() {
        for (int i = 0; i < 5; i++) {
            id = i;
            displayName = "displayName " + i.ToString();
            description = "description " + i.ToString();
            var rand = Random.Range(0,3);
            switch (rand) {
                case (0) :
                    typeVetement = TypeVetementEnum.Tete;
                    break;
                case (1) :
                    typeVetement = TypeVetementEnum.Cou;
                    break;
                case (2) :
                    typeVetement = TypeVetementEnum.Bas;
                    break;
                case (3) :
                    typeVetement = TypeVetementEnum.Pied;
                    break;
                default:
                    print("Incorrect enum type vetement");
                    break;
            }
            rand = Random.Range(0,2);
            switch (rand) {
                case (0) :
                    typeCliche = TypeClicheEnum.Cliche;
                    break;
                case (1) :
                    typeCliche = TypeClicheEnum.Piege;
                    break;
                case (2) :
                    typeCliche = TypeClicheEnum.Vrai;
                    break;
                default:
                    print("Incorrect enum type cliche");
                    break;
            }
            this.randomItem = new Item();
            this.randomItem.setItemData(i, displayName, description, itemSprite, typeVetement, typeCliche);
            this.inventory.AddItem(this.randomItem);

        }
    }
}


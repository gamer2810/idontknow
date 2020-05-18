using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LootSpot : MonoBehaviour {
    public int lootWeight;

    [SerializeField]
    public InventoryObject content;

    // private void Start() {
    //     // content = ScriptableObject.CreateInstance("InventoryObject") as InventoryObject;
    //     // ItemContent toAdd = new ItemContent();
    //     // content.init(toAdd,10);
    // }

    public void getLoot(InventoryObject toAddTo){
        Debug.Log(this.content);
        KeyValuePair<int,Item> toGet = this.content.getRandomItem();
        if(toAddTo.addItem(toGet.Value,toGet.Value.amount))
            this.content.removeItem(toGet.Value.id,toGet.Value.amount);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootSpot : MonoBehaviour {

    private static Inventory playerInventory; 

    public int lootWeight;

    [SerializeField]
    private List<Item> content;

    private void Start() {
        playerInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    public void GetItem(Item toGet){
        // this.content.Remove(toGet);
        playerInventory.addItem(toGet);
    } 
}

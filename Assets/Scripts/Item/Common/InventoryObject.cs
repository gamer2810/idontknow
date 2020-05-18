using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotaryHeart.Lib.SerializableDictionary;
using System.Linq;

[System.Serializable]
public class ItemContent : SerializableDictionaryBase<int, Item> { }

[CreateAssetMenu(fileName="New Inventory",menuName="Item/New Inventory")]
public class InventoryObject: ScriptableObject
{
    [SerializeField]
    private ItemContent content;
    
    [SerializeField]
    private int capacity;

    [SerializeField]
    private int currentlyHold;

    public void init(ItemContent content, int capacity){
        this.content = new ItemContent();
        this.currentlyHold = content.Count;
        content.CopyTo(this.content);
        this.capacity = capacity;
    }

    private void Start() {
        if(this.content == null){
            //to be load later
            this.currentlyHold = 0;
            this.content = new ItemContent();
            this.capacity = 10;
        } else this.currentlyHold = this.content.Count;
    } 

    public bool addItem(Item toAdd,int amount){
        if(currentlyHold + amount >= capacity){
            return false;
        }

        if(content.ContainsKey(toAdd.id)){
            content[toAdd.id].amount += amount;
        } else {
            content[toAdd.id] = toAdd;
            content[toAdd.id].amount = amount;
        }

        this.currentlyHold += amount;
        foreach(KeyValuePair<int,Item> i in content){
            Debug.Log(i.Key + " " + i.Value);
        }
        return true;
    }

    public bool removeItem(int toRemove,int amount){
        if(content.ContainsKey(toRemove)){
            if(content[toRemove].amount - amount < 0)
                return false;
            content[toRemove].amount -= amount;
            if(content[toRemove].amount == 0){
                content.Remove(toRemove);
            }
            this.currentlyHold -= amount;
            return true;
        } else {
            return false;
        }
    }

    public KeyValuePair<int,Item> getRandomItem(){   
        int key = this.content.Keys.ElementAt(0);
        return new KeyValuePair<int, Item>(key,this.content[key]);
    }
}


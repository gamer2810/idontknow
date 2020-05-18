using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotaryHeart.Lib.SerializableDictionary;

[System.Serializable]
public class ItemContent : SerializableDictionaryBase<Item, int> { }

public class Inventory: MonoBehaviour
{
    [SerializeField]
    private ItemContent content;
    
    [SerializeField]
    private int capacity;

    [SerializeField]
    private int currentlyHold;



    private void Start() {
        if(content == null){
            //to be load later
            currentlyHold = 0;
            content = new ItemContent();
            capacity = 10;
        } else currentlyHold = content.Count;
    } 

    public bool addItem(Item toAdd){
        if(currentlyHold >= capacity){
            return false;
        }

        if(content.ContainsKey(toAdd)){
            content[toAdd] += 1;
        } else {
            content[toAdd] = 1;
        }

        currentlyHold += 1;
        foreach(KeyValuePair<Item,int> i in content){
            Debug.Log(i.Key + " " + i.Value);
        }
        return true;
    }

    public bool removeItem(Item toRemove){
        if(content.ContainsKey(toRemove)){
            content[toRemove] -= 1;
            if(content[toRemove] == 0){
                content.Remove(toRemove);
            }
            currentlyHold -= 1;
            return true;
        } else {
            return false;
        }
    }
}

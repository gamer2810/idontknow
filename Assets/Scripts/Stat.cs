using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotaryHeart.Lib.SerializableDictionary;

[System.Serializable]
public class StatDictionary : SerializableDictionaryBase<string, float> {
}

public class Stat: MonoBehaviour{
    public StatDictionary stats;
    
    private void Awake() {
        if(stats.Count == 0){
            stats.Add("hp",100);
            stats.Add("armor",0);
            stats.Add("damage",10);
            stats.Add("fireRate",10);
            stats.Add("magSize",10);
        }
    }

    Stat(){
        stats = new StatDictionary();
    }
}

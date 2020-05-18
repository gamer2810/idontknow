using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Armor",menuName="Item/Equipment/New Armor")]
public class Armor : EquipmentObject
{
    protected override void Awake() {
        base.Awake();
        this.equipmentType = EquipmentType.Armor;
        if(modifiers.Count == 0){
            this.modifiers.Add("hp",10);
            this.modifiers.Add("armor",10);
        }
    }
}

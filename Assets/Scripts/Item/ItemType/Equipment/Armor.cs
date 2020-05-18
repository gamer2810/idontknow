using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Armor",menuName="Item/Equipment/New Armor")]
public class Armor : Equipment
{
    protected override void Awake() {
        base.Awake();
        this.equipmentType = EquipmentType.Armor;
        this.modifiers.Add("hp",10);
        this.modifiers.Add("armor",10);
    }
}

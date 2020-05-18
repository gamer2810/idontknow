using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Weapon",menuName="Item/Equipment/New Weapon")]
public class Weapon : Equipment
{
    protected override void Awake() {
        base.Awake();
        this.equipmentType = EquipmentType.Weapon;
        this.modifiers.Add("damage",10);
        this.modifiers.Add("fireRate",10);
        this.modifiers.Add("magSize",10);
    }
}

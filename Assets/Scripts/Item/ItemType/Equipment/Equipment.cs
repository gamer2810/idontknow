using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EquipmentType
{
    Weapon,
    Armor,
}

public class EquipmentObject : Item
{
    public EquipmentType equipmentType;
    public string slot;
    public ModifierDictionary modifiers;

    protected virtual void Awake() {
        this.type = ItemType.Equipment;
    }

    public EquipmentObject(){
        modifiers = new ModifierDictionary();
    }
}

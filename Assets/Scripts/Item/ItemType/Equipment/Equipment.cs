using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EquipmentType
{
    Weapon,
    Armor,
}

public class Equipment : Item
{
    public EquipmentType equipmentType;
    public ModifierDictionary modifiers;

    protected virtual void Awake() {
        this.type = ItemType.Equipment;
    }

    public Equipment(){
        modifiers = new ModifierDictionary();
    }
}

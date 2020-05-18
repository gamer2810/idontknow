using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Food,
    Equipment,
    Medical
}

public class Item: ScriptableObject
{
    public new string name;
    [TextArea(15,20)]
    public string description;
    public ItemType type;
    public GameObject prefab;
}

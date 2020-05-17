using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Item", menuName="Inventory/Item")]
public class Item: ScriptableObject
{
    public new string name;
    public string description;
    private Sprite icon;
}

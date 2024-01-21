using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Scriptable object/Item")]
public class Item : ScriptableObject
{



    [Header("Only gameplay")]
    public Sprite image; // sprite shown in the inventory
    public ItemType type;
    public ActionType actionType;
    public Vector2Int range = new Vector2Int(5, 4);

    [Header("Only UI")]
    public bool stackable; // will tell us if the item is stackable or not




}


public enum ItemType
{
    Tool, 
    Weapon, 
    Armor, 
    Misc, 
    Resource, 
    Consumable
}

public enum ActionType
{
    // TODO: add action types if necessary
}

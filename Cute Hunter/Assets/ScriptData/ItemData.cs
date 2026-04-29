using System.IO.Enumeration;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ItemData", menuName = "ScriptableObject/ItemData")]

public class ItemtData : ScriptableObject
{
   [SerializeField] Sprite icon;
   [SerializeField] string itemName;
   public ItemType type;
   public Sprite Icon => icon;
   public string ItemName => itemName;
}

public enum ItemType
{
   Life, Coins
}
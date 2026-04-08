using System.IO.Enumeration;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "ScriptableObject/ItemData")]

public class ItemtData : ScriptableObject
{
   [SerializeField] Sprite icon;
   [SerializeField] string itemName;

   public Sprite Icon => Icon;
   public string ItemName => itemName;
   


}

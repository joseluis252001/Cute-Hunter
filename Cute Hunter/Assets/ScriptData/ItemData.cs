using System.IO.Enumeration;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ItemData", menuName = "ScriptableObject/ItemData")]

public class ItemtData : ScriptableObject
{
   [SerializeField] Sprite icon;
   [SerializeField] string itemName;
   [SerializeField]Image imageitem;

   public Sprite Icon => Icon;
   public string ItemName => itemName;
   


}

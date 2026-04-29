using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using NaughtyAttributes;
using UnityEngine;
using Dino.UtilityTools.Extensions.Json;
using DG.Tweening;
using System.IO;
using UnityEngine.iOS;

[Serializable]
public class RuntimeItem
{
   public Sprite Icon;
   public String ItemName;

   public RuntimeItem( Sprite icon, string itemName)
   {
     Icon = icon;
     ItemName = itemName;
   }


}
public class IventoryManager : MonoBehaviour
{
     public static IventoryManager Instance { get; private set; }
    
    public List<RuntimeItem> items;

    public List<ItemtData> itemtDatas;


     private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
        }
    public void CreateItem(ItemType itemtype)
    {
        foreach(ItemtData item in itemtDatas)
        {
            if(item.type == itemtype)
            {
              
                RuntimeItem runtimeItem = new RuntimeItem(item.Icon, item.ItemName);
                items.Add(runtimeItem);
            }
        }
    }
    
    [Button]
    public void CreateImenTest()
    {
        CreateItem(ItemType.Life);    
    }
    
    [Button]
    private void SaveInventoyManager()
    {
        string json = JsonHelper.ToJson(items.ToArray(), true);
        Debug.Log(json);

         string path = Application.persistentDataPath + "/inventoy.json";
         System.IO.File.WriteAllText(path, json);
         Debug.Log("path: "+ path);

        
    }

   public void LoadInventory()
    {
          string path = Application.persistentDataPath + "/inventoy.json";
          if(!System.IO.File.Exists(path))
        {
            Debug.LogError("No inventory " + path);
        }
        string json = System.IO.File.ReadAllText(path);
        RuntimeItem[] loadedItems = JsonHelper.FromJson<RuntimeItem>(json);

        items.Clear();
        items.AddRange(loadedItems);
    }

}


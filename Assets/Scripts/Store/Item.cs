using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Store.Items 
{
    [CreateAssetMenu(fileName = "Item")]
    public class Item : ScriptableObject
    {
        public string ID;
        public string Name;
        public int Price;
        public Sprite Icon;
        public bool InInventory;
    }
}

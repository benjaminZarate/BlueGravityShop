using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Store.Items 
{
    public enum ItemType { HOOD, WRIST, TORSO, SHOULDER, ELBOW, LEG, BOOT}
    [CreateAssetMenu(fileName = "Item", menuName = "Store/Item")]
    public class Item : ScriptableObject
    {
        public string ID;
        public string Name;
        public int Price;
        public Sprite Icon;
        public ItemType Type;
        public bool InInventory;
    }
}

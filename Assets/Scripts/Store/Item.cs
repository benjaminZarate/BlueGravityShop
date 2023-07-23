using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Store.Items 
{
    public enum ItemType { HOOD = 0, WRIST = 1, TORSO = 2, SHOULDER = 3, ELBOW = 4, LEG = 5, BOOT = 6}
    [CreateAssetMenu(fileName = "Item", menuName = "Store/Item")]
    public class Item : ScriptableObject
    {
        public string ID;
        public string Name;
        public int Price;
        public Sprite[] Icon;
        public ItemType Type;
        public bool InInventory;
    }
}

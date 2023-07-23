using Store.Items;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory 
{
    public class InventoryManager : MonoBehaviour
    { 
        private List<Item> itemsList = new();

        public void AddToInventory(Item newItem) 
        {
            itemsList.Add(newItem);
        }

        public List<Item> GetItemList() 
        {
            return itemsList;
        }
    }
}

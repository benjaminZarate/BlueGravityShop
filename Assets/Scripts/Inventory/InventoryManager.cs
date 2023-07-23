using Store;
using Store.Items;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory 
{
    public class InventoryManager : MonoBehaviour
    {
        private List<Item> itemsList = new();
        [SerializeField] private Money money;

        public void AddToInventory(Item newItem) 
        {
            itemsList.Add(newItem);
        }

        public List<Item> GetItemList() 
        {
            return itemsList;
        }

        public void SellItem(Item newItem) 
        {
            itemsList.Remove(newItem);
            money.currentMoney += newItem.Price;
        }
    }
}

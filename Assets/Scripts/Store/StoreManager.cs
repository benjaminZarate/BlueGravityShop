using Inventory;
using Store.Items;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Store 
{
    public class StoreManager : MonoBehaviour
    {
        [SerializeField] private StoreContainer container;
        [SerializeField] private Money currentMoney;
        [SerializeField] private PlayerClothesContainer playerClothesContainer;
        [SerializeField] private InventoryManager inventoryManager;
        private int totalPrice;

        [SerializeField] private List<Item> itemsInCart;

        public void AddItemToCart(Item newItem)
        {
            if (!itemsInCart.Contains(newItem)) 
            {
                itemsInCart.Add(newItem);
                totalPrice += newItem.Price;
            }
        }

        public void RemoveFromCart(Item newItem)
        {
            itemsInCart.Remove(newItem);
            totalPrice -= newItem.Price;
        }

        public void BuyClothes() 
        {
            if (currentMoney.currentMoney >= totalPrice) 
            {
                Debug.LogWarning("buy");
                playerClothesContainer.UpdateCurrentClothe();
                currentMoney.currentMoney -= totalPrice;
                foreach (Item item in itemsInCart)
                {
                    inventoryManager.AddToInventory(item);
                }
                itemsInCart.Clear();
                totalPrice = 0;
            }
        }

        public void SellClothe() 
        {
            
        }

        public StoreContainer GetStoreContainer() 
        {
            return container;
        }

        public List<Item> GetItemsInCart() 
        {
            return itemsInCart;
        }

        public int GetTotalPrice() 
        {
            return totalPrice;
        }
    }
}

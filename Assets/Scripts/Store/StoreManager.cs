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
        private int totalPrice;

        [SerializeField] private List<Item> itemsInCart;

        public void AddItemToCart(Item newItem)
        {
            if (!itemsInCart.Contains(newItem) && !itemsInCart.Find(i => i.Type == newItem.Type)) 
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
                itemsInCart.Clear();
            }
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

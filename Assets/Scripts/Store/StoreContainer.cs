using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Store.Items;

namespace Store 
{
    [CreateAssetMenu(fileName = "Store", menuName = "Store/Store")]
    public class StoreContainer : ScriptableObject
    {
        public List<Item> itemsToSell;
        public List<Item> itemsInCart;

        public void AddItemToCart(Item newItem) 
        {
            itemsInCart.Add(newItem);
            itemsToSell.Remove(newItem);
        }
    }
}

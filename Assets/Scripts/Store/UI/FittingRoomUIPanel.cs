using Store.Items;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Store.UI 
{
    public class FittingRoomUIPanel : MonoBehaviour
    {
        [SerializeField] private StoreManager storeManager;
        [SerializeField] private RectTransform container;
        [SerializeField] private ItemUI itemUIPrefab;
        [SerializeField] private ClothesPreviewUI clothesPreviewUI;

        private List<ItemUI> itemsInDisplay = new();

        private void Start()
        {
            InitStoreItems();
            FilterList(0);
        }

        private void OnEnable()
        {
            clothesPreviewUI.UpdateClothes();
        }

        private void InitStoreItems() 
        {
            foreach (Item item in storeManager.GetStoreContainer().itemsToSell)
            {
                ItemUI newItem = Instantiate(itemUIPrefab, container);
                newItem.Init(item.Icon, item.Clothes, item.Name,$"${item.Price}", item.Type, item.ID);
                itemsInDisplay.Add(newItem);
            }
        }

        public void FilterList(int itemType) 
        {
            foreach (ItemUI item in itemsInDisplay)
            {
                item.gameObject.SetActive(item.GetItemType() == (ItemType)itemType);
            }
        }

        public void UpdatePreview(ItemType type, Sprite[] sprites) 
        {
            if (sprites.Length > 1)
            {
                clothesPreviewUI.ChangeClothe(type, sprites[0], sprites[1]);
            }
            else
            {
                clothesPreviewUI.ChangeClothe(type, sprites[0]);
            }
        }

        public void AddToCart(Item newItem) 
        {
            storeManager.AddItemToCart(newItem);
        }
    }
}

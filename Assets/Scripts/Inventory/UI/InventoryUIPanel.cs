using Store.Items;
using Store.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory.UI 
{
    public class InventoryUIPanel : MonoBehaviour
    {
        [SerializeField] private InventoryItem inventoryItemPrefab;
        [SerializeField] private RectTransform inventoryParent;
        [SerializeField] private InventoryManager inventoryManager;
        [SerializeField] private ClothesPreviewUI clothesPreviewUI;

        private List<InventoryItem> inventoryItemList = new();

        private void CreateInventoryItems() 
        {
            int count = inventoryManager.GetItemList().Count;
            for (int i = 0; i < count; i++)
            {
                Item item = inventoryManager.GetItemList()[i];
                InventoryItem inventoryItem;
                if (i >= inventoryItemList.Count)
                {
                    inventoryItem = Instantiate(inventoryItemPrefab, inventoryParent);
                }
                else 
                {
                    inventoryItem = inventoryItemList[i];
                }
                inventoryItem.Init(item.Icon, item.Name, item.Type, clothesPreviewUI);
            }
        }

        public void FilterList(int itemType)
        {
            foreach (InventoryItem item in inventoryItemList)
            {
                item.gameObject.SetActive(item.GetItemType() == (ItemType)itemType);
            }
        }

        private void OnEnable()
        {
            CreateInventoryItems();
        }
    }
}

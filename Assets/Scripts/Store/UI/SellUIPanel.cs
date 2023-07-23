using Inventory;
using Inventory.UI;
using Store.Items;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellUIPanel : MonoBehaviour
{
    [SerializeField] private InventoryItem inventoryItemPrefab;
    [SerializeField] private RectTransform inventoryParent;
    [SerializeField] private InventoryManager inventoryManager;
    [SerializeField] private PlayerClothesContainer playerClothesContainer;

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
            inventoryItem.Init(item.Icon, item.Name, item.Type, item.ID);
        }
    }

    private void OnEnable()
    {
        CreateInventoryItems();
    }

    public InventoryManager GetInventoryManager() 
    {
        return inventoryManager;
    }

    public void CheckIfClotheStillAvailable() 
    {
        if (!inventoryManager.GetItemList().Find(i => i.Type == ItemType.HOOD)) 
        {
            playerClothesContainer.ApplyDefaultClothe(ItemType.HOOD);
        }
        if (!inventoryManager.GetItemList().Find(i => i.Type == ItemType.WRIST))
        {
            playerClothesContainer.ApplyDefaultClothe(ItemType.WRIST);
        }
        if (!inventoryManager.GetItemList().Find(i => i.Type == ItemType.TORSO))
        {
            playerClothesContainer.ApplyDefaultClothe(ItemType.TORSO);
        }
        if (!inventoryManager.GetItemList().Find(i => i.Type == ItemType.SHOULDER))
        {
            playerClothesContainer.ApplyDefaultClothe(ItemType.SHOULDER);
        }
        if (!inventoryManager.GetItemList().Find(i => i.Type == ItemType.LEG))
        {
            playerClothesContainer.ApplyDefaultClothe(ItemType.LEG);
        }
        if (!inventoryManager.GetItemList().Find(i => i.Type == ItemType.ELBOW))
        {
            playerClothesContainer.ApplyDefaultClothe(ItemType.ELBOW);
        }
        if (!inventoryManager.GetItemList().Find(i => i.Type == ItemType.BOOT))
        {
            playerClothesContainer.ApplyDefaultClothe(ItemType.BOOT);
        }
        playerClothesContainer.UpdateCurrentClothe();
    }
}

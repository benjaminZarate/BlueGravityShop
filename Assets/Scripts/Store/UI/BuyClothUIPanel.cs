using Store;
using Store.Items;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuyClothUIPanel : MonoBehaviour
{
    [SerializeField] private StoreManager storeManager;
    [SerializeField] private ItemCartUI itemCartUiPrefab;
    [SerializeField] private RectTransform itemCartParent;
    [SerializeField] private TMP_Text totalPriceText;
    [SerializeField] private ClothesPreviewUI clothesPreviewUI;
    [SerializeField] private PlayerClothesContainer playerClothesContainer;

    private void InitPreview() 
    {
        foreach (Item item in storeManager.GetItemsInCart())
        {
            if (item.Clothes.Length > 1)
            {
                clothesPreviewUI.ChangeClothe(item.Type, item.Clothes[0], item.Clothes[1]);
            }
            else 
            {
                clothesPreviewUI.ChangeClothe(item.Type, item.Clothes[0]);
            }
        }
    }

    private void InitItems() 
    {
        int count = storeManager.GetItemsInCart().Count;
        for (int i = 0; i < count; i++)
        {
            ItemCartUI item = Instantiate(itemCartUiPrefab, itemCartParent);
            item.Init(storeManager.GetItemsInCart()[i].Icon, storeManager.GetItemsInCart()[i].Name, storeManager.GetItemsInCart()[i].Price.ToString());
        }
    }

    private void Init() 
    {
        InitItems();
        InitPreview();
        totalPriceText.text = $"${storeManager.GetTotalPrice()}";
    }

    private void OnEnable()
    {
        Init();
    }

    private void OnDisable()
    {
        ClearItems();
    }

    private void ClearItems() 
    {
        for (int i = 0; i < itemCartParent.childCount; i++)
        {
            Destroy(itemCartParent.GetChild(i).gameObject);
        }
    }

    public void BuyItems() 
    {
        foreach (Item item in storeManager.GetItemsInCart())
        {
            if (item.Clothes.Length > 1)
            {
                playerClothesContainer.ChangeClothe(item.Type, item.Clothes[0], item.Clothes[1]);
            }
            else
            {
                playerClothesContainer.ChangeClothe(item.Type, item.Clothes[0]);
            }
        }
        storeManager.BuyClothes();
        ClearItems();
    }
}

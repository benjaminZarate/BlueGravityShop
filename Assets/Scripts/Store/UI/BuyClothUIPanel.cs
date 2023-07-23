using Store;
using Store.Items;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuyClothUIPanel : MonoBehaviour
{
    [SerializeField] private StoreManager storeManager;
    [SerializeField] private List<ItemCartUI> itemCartList;
    [SerializeField] private TMP_Text totalPriceText;
    [SerializeField] private ClothesPreviewUI clothesPreviewUI;
    [SerializeField] private PlayerClothesContainer playerClothesContainer;

    private void InitPreview() 
    {
        foreach (Item item in storeManager.GetItemsInCart())
        {
            if (item.Icon.Length > 1)
            {
                clothesPreviewUI.ChangeClothe(item.Type, item.Icon[0], item.Icon[1]);
            }
            else 
            {
                clothesPreviewUI.ChangeClothe(item.Type, item.Icon[0]);
            }
        }
    }

    private void InitItems() 
    {
        for (int i = 0; i < itemCartList.Count; i++)
        {
            if (i >= storeManager.GetItemsInCart().Count) 
            {
                itemCartList[i].gameObject.SetActive(false);
                continue;
            }
            itemCartList[i].Init(storeManager.GetItemsInCart()[i].Icon[0], storeManager.GetItemsInCart()[i].Name, storeManager.GetItemsInCart()[i].Price.ToString());
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

    public void BuyItems() 
    {
        foreach (Item item in storeManager.GetItemsInCart())
        {
            if (item.Icon.Length > 1)
            {
                playerClothesContainer.ChangeClothe(item.Type, item.Icon[0], item.Icon[1]);
            }
            else
            {
                playerClothesContainer.ChangeClothe(item.Type, item.Icon[0]);
            }
        }
        storeManager.BuyClothes();
    }
}

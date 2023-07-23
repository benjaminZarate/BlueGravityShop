using Store.Items;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private TMP_Text nameText;

    private ClothesPreviewUI clothesPreviewUI;
    private Sprite[] iconSprites;
    private ItemType type;

    public void Init(Sprite[] iconsSprite, string name, ItemType type, ClothesPreviewUI clothesPreview)
    {
        icon.sprite = iconsSprite[0];
        nameText.text = name;
        this.type = type;
        clothesPreviewUI = clothesPreview;
        iconSprites = iconsSprite;
    }

    public void SetClothe() 
    {
        if (iconSprites.Length > 1)
        {
            clothesPreviewUI.ChangeClothe(type, iconSprites[0], iconSprites[1]);
        }
        else
        {
            clothesPreviewUI.ChangeClothe(type, iconSprites[0]);
        }
    }

    public ItemType GetItemType() 
    {
        return type;
    }
}

using Inventory.UI;
using Store.Items;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Inventory.UI 
{
    public class InventoryItem : MonoBehaviour
    {
        [SerializeField] private Image icon;
        [SerializeField] private TMP_Text nameText;

        private string ID;
        private SellUIPanel sellUIPanel;
        private ClothesPreviewUI clothesPreviewUI;
        private Sprite[] iconSprites;
        private ItemType type;

        private void Start()
        {
            sellUIPanel = GetComponentInParent<SellUIPanel>();
        }

        public void Init(Sprite[] iconsSprite, string name, ItemType type, string ID, ClothesPreviewUI clothesPreview = null)
        {
            icon.sprite = iconsSprite[0];
            nameText.text = name;
            this.type = type;
            clothesPreviewUI = clothesPreview;
            iconSprites = iconsSprite;
            this.ID = ID;
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

        public void Sell() 
        {
            Item newItem = sellUIPanel.GetInventoryManager().GetItemList().Find(i => i.ID.Contains(ID));
            sellUIPanel.GetInventoryManager().SellItem(newItem);
            sellUIPanel.CheckIfClotheStillAvailable();
            this.gameObject.SetActive(false);
        }

        public ItemType GetItemType() 
        {
            return type;
        }
    }
}

using Store.Items;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Store.UI 
{
    public class ItemUI : MonoBehaviour
    {
        [SerializeField] private PlayerClothesContainer playerClothesContainer;
        [SerializeField] private StoreContainer storeContainer;
        [SerializeField] private Image icon;
        [SerializeField] private TMP_Text nameText;
        [SerializeField] private TMP_Text priceText;
        private Sprite[] iconsSprite;
        private ItemType type;
        private string ID;
        private FittingRoomUIPanel fittingRoomUIPanel;

        private void Start()
        {
            fittingRoomUIPanel = GetComponentInParent<FittingRoomUIPanel>();
        }

        public void Init(Sprite icon, Sprite[] iconsSprite, string name, string price,ItemType type, string ID) 
        {
            this.icon.sprite = icon;
            nameText.text = name;
            priceText.text = price;
            this.type = type;
            this.iconsSprite = iconsSprite;
            this.ID = ID;
        }

        public ItemType GetItemType() 
        {
            return type;
        }

        public void SetClothe() 
        {
            fittingRoomUIPanel.UpdatePreview(type, iconsSprite);
        }

        public void AddToCart() 
        {
            fittingRoomUIPanel.AddToCart(storeContainer.itemsToSell.Find(i => i.ID.Contains(ID)));
        }
    }

}

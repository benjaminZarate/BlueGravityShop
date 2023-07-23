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
        private Sprite[] iconsSprite;
        private ItemType type;
        private string ID;
        private FittingRoomUIPanel fittingRoomUIPanel;

        private void Start()
        {
            fittingRoomUIPanel = GetComponentInParent<FittingRoomUIPanel>();
        }

        public void Init(Sprite[] iconsSprite, string name, ItemType type, string ID) 
        {
            icon.sprite = iconsSprite[0];
            nameText.text = name;
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

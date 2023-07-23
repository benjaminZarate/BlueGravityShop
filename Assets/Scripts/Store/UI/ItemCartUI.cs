using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemCartUI : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text priceText;

    public void Init(Sprite icon, string name, string price) 
    {
        this.icon.sprite = icon;
        nameText.text = name;
        priceText.text = $"${price}";
    }
}

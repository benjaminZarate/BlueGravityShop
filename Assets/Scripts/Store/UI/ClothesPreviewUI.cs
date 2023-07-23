using Store.Items;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothesPreviewUI : MonoBehaviour
{
    [SerializeField] private Image hood;
    [SerializeField] private Image[] shoulder;
    [SerializeField] private Image[] elbow;
    [SerializeField] private Image[] wrist;
    [SerializeField] private Image torso;
    [SerializeField] private Image[] leg;
    [SerializeField] private Image[] boots;

    [SerializeField] private PlayerClothesContainer playerClothesContainer;

    public void ChangeClothe(ItemType itemType, Sprite clothe, Sprite clotheR = null)
    {
        switch (itemType)
        {
            case ItemType.HOOD:
                hood.sprite = clothe;
                break;
            case ItemType.SHOULDER:
                shoulder[0].sprite = clothe;
                shoulder[1].sprite = clotheR;
                break;
            case ItemType.ELBOW:
                elbow[0].sprite = clothe;
                elbow[1].sprite = clotheR;
                break;
            case ItemType.WRIST:
                wrist[0].sprite = clothe;
                wrist[1].sprite = clotheR;
                break;
            case ItemType.TORSO:
                torso.sprite = clothe;
                break;
            case ItemType.LEG:
                leg[0].sprite = clothe;
                leg[1].sprite = clotheR;
                break;
            case ItemType.BOOT:
                boots[0].sprite = clothe;
                boots[1].sprite = clotheR;
                break;
        }
    }

    public void UpdateClothes()
    {
        hood.sprite = playerClothesContainer.hood;
        shoulder[0].sprite = playerClothesContainer.shoulder[0];
        shoulder[1].sprite = playerClothesContainer.shoulder[1];
        elbow[0].sprite = playerClothesContainer.elbow[0];
        elbow[1].sprite = playerClothesContainer.elbow[1];
        wrist[0].sprite = playerClothesContainer.wrist[0];
        wrist[1].sprite = playerClothesContainer.wrist[1];
        torso.sprite = playerClothesContainer.torso;
        leg[0].sprite = playerClothesContainer.leg[0];
        leg[1].sprite = playerClothesContainer.leg[1];
        boots[0].sprite = playerClothesContainer.boots[0];
        boots[1].sprite = playerClothesContainer.boots[1];
    }
}

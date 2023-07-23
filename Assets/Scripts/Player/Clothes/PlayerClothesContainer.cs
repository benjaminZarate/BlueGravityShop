using Store.Items;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Clothes Container", menuName = "Player/PlayerClothes")]
public class PlayerClothesContainer : ScriptableObject
{
    public Sprite hood;
    public Sprite[] shoulder;
    public Sprite[] elbow;
    public Sprite[] wrist;
    public Sprite torso;
    public Sprite[] leg;
    public Sprite[] boots;

    public event Action onClotheBought;

    public void ChangeClothe(ItemType itemType, Sprite clothe, Sprite clotheR = null)
    {
        switch (itemType)
        {
            case ItemType.HOOD:
                hood = clothe;
                break;
            case ItemType.SHOULDER:
                shoulder[0] = clothe;
                shoulder[1] = clotheR;
                break;
            case ItemType.ELBOW:
                elbow[0] = clothe;
                elbow[1] = clotheR;
                break;
            case ItemType.WRIST:
                wrist[0] = clothe;
                wrist[1] = clotheR;
                break;
            case ItemType.TORSO:
                torso = clothe;
                break;
            case ItemType.LEG:
                leg[0] = clothe;
                leg[1] = clotheR;
                break;
            case ItemType.BOOT:
                boots[0] = clothe;
                boots[1] = clotheR;
                break;
        }
    }

    public void UpdateCurrentClothe() 
    {
        onClotheBought?.Invoke();
    }
}

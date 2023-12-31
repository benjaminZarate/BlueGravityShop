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
    public Sprite pelvis;
    public Sprite[] leg;
    public Sprite[] boots;

    public Sprite hoodDefault;
    public Sprite[] shoulderDefault;
    public Sprite[] elbowDefault;
    public Sprite[] wristDefault;
    public Sprite torsoDefault;
    public Sprite pelvisDefault;
    public Sprite[] legDefault;
    public Sprite[] bootsDefault;

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
            case ItemType.PELVIS:
                pelvis = clothe;
                break;

        }
    }

    public void UpdateCurrentClothe() 
    {
        onClotheBought?.Invoke();
    }

    public void ApplyDefaultClothe(ItemType itemType) 
    {
        switch (itemType)
        {
            case ItemType.HOOD:
                hood = hoodDefault;
                break;
            case ItemType.TORSO:
                torso = torsoDefault;
                break;
            case ItemType.SHOULDER:
                shoulder = shoulderDefault;
                break;
            case ItemType.ELBOW:
                elbow = elbowDefault;
                break;
            case ItemType.WRIST:
                wrist = wristDefault;
                break;
            case ItemType.LEG:
                leg = legDefault;
                break;
            case ItemType.BOOT:
                boots = bootsDefault;
                break;
            case ItemType.PELVIS:
                pelvis = pelvisDefault;
                break;
        }
    }
}

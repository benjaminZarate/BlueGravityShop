using Store;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentMoney : MonoBehaviour
{
    [SerializeField] private TMP_Text moneyText;
    [SerializeField] private Money money;

    private void OnEnable()
    {
        UpdateMoneyText();
    }

    public void UpdateMoneyText() 
    {
        moneyText.text = money.currentMoney.ToString();
    }
}

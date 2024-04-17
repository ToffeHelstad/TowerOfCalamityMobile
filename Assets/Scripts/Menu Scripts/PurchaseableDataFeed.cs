using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PurchaseableDataFeed : MonoBehaviour
{
    public SO_Purchaseable purchaseableData;
    public ShopDisplayFeed shopDisplay;

    public Image art;
    public TMP_Text itemName;
    public TMP_Text price;
    public GameObject softCurrency;
    public GameObject hardCurrency;
    public GameObject realMoney;

    private void Awake()
    {
        art.sprite = purchaseableData.sprite;
        itemName.SetText(purchaseableData.itemName);
        price.SetText(purchaseableData.price.ToString());

        if (purchaseableData.Currency && purchaseableData.HardCurrency)
        {
            softCurrency.SetActive(false);
            realMoney.SetActive(false);
            hardCurrency.SetActive(true);
        }

        if(purchaseableData.Currency && purchaseableData.Money)
        {
            softCurrency.SetActive(false);
            realMoney.SetActive(true);
            hardCurrency.SetActive(false);
        }

        if (purchaseableData.Currency && purchaseableData.SoftCurrency)
        {
            softCurrency.SetActive(true);
            realMoney.SetActive(false);
            hardCurrency.SetActive(false);
        }
    }
    public void SendToDisplay()
    {
        shopDisplay.SelectObject(purchaseableData);
    }
}

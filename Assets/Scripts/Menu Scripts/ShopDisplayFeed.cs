using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopDisplayFeed : MonoBehaviour
{
    public SO_Purchaseable purchaseable;

    public Image art;
    public TMP_Text itemName;
    public TMP_Text itemDescription;
    public TMP_Text price;

    public GameObject softCurrency;
    public GameObject hardCurrency;
    public GameObject realMoney;

    private void Awake()
    {
        SelectObject(purchaseable);
    }

    public void SelectObject(SO_Purchaseable data)
    {
        art.sprite = data.sprite;
        itemName.SetText(data.itemName);
        itemDescription.SetText(data.itemDescription);
        price.SetText(data.price.ToString());

        if (data.HardCurrency)
        {
            softCurrency.SetActive(false);
            realMoney.SetActive(false);
            hardCurrency.SetActive(true);
        }

        if (data.Money)
        {
            softCurrency.SetActive(false);
            realMoney.SetActive(true);
            hardCurrency.SetActive(false);
        }

        if (data.SoftCurrency)
        {
            softCurrency.SetActive(true);
            realMoney.SetActive(false);
            hardCurrency.SetActive(false);
        }
    }
}

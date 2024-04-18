using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopDisplayFeed : MonoBehaviour
{
    public SO_Purchaseable purchaseable;
    public LoadsaMoney moneyManager;
    public FakeUnlockScript unlockScript;

    public Image art;
    public TMP_Text itemName;
    public TMP_Text itemDescription;
    public TMP_Text price;

    public GameObject softCurrency;
    public GameObject hardCurrency;
    public GameObject realMoney;

    public GameObject cantAffordPopup;
    public GameObject purchaseSoftConfirm;
    public GameObject purchaseHardConfirm;
    public GameObject purchaseRealConfirm;

    private int moneyAmount;
    public int hardAmount;

    private void Awake()
    {
        SelectObject(purchaseable);
    }

    public void SelectObject(SO_Purchaseable data)
    {
        purchaseable = data;
        hardAmount = data.HardCurrencyAmount;
        moneyAmount = data.price;
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

    public void PurchaseSelected()
    {
        if (purchaseable.SoftCurrency)
        {
            if (moneyManager.hellaSoft < purchaseable.price)
            {
                cantAffordPopup.SetActive(true);
            }
            else
            {
                purchaseSoftConfirm.SetActive(true);
            }
        }

        if (purchaseable.HardCurrency)
        {
            if (moneyManager.hellaHard < purchaseable.price)
            {
                cantAffordPopup.SetActive(true);
            }
            else
            {
                purchaseHardConfirm.SetActive(true);
            }
        }

        if (purchaseable.Money)
        {
            purchaseRealConfirm.SetActive(true);
        }
    }

    public void ConfirmSoft()
    {
        if (purchaseable.UnlockChar1)
        {
            unlockScript.UnlockCharacter1();
        }

        if (purchaseable.UnlockChar2)
        {
            unlockScript.UnlockCharacter2();
        }
        moneyManager.RemoveCalamityCoins(purchaseable.price);
        purchaseSoftConfirm.SetActive(false);
    }

    public void ConfirmHard()
    {
        moneyManager.RemoveTowerTalents(hardAmount);
        purchaseHardConfirm.SetActive(false);
    }

    public void ConfirmReal()
    {
        moneyManager.AddTowerTalents(hardAmount);
        purchaseRealConfirm.SetActive(false);
    }
}

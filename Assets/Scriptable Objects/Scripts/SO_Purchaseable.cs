using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
[CreateAssetMenu(fileName = "New Purchaseable", menuName = "ScriptableObjects/Store Item", order = 1)]
public class SO_Purchaseable : ScriptableObject
{
    [Header("Data")]
    public Sprite sprite;
    public string itemName;
    public string itemDescription;
    public float price;

    [Header("What kind of currency does it take?")]
    public bool SoftCurrency;
    public bool HardCurrency;
    public bool Money;

    [Header("What kind of purchaseable is it?")]
    public bool Object;
    public bool Currency;

    [Header("How much currency does it give you?")]
    public int HardCurrencyAmount;
}

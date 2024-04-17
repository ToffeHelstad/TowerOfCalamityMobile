using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadsaMoney : MonoBehaviour
{
    public TMP_Text softWallet;
    public TMP_Text hardWallet;
    [SerializeField] private int softGains;
    [SerializeField] private int hardGains;

    public int hellaSoft; //mengden soft currency spilleren har, lagret i player preferences
    public int hellaHard; //ditto, men hard currency
    void Start()
    {
        hellaSoft = PlayerPrefs.GetInt("amount"); //henter spillerens myke dosh fra int lagret i PlayerPrefs
        hellaHard = PlayerPrefs.GetInt("amount"); //henter spillerens harde dosh fra int lagret i PlayerPrefs
    }

    void Update()
    {
        CalamityCoins();
        TowerTalents();

        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
    }

    void CalamityCoins()
    {
        softWallet.text = "" + hellaSoft;
        if (Input.GetKeyDown(KeyCode.Space)) //m� erstattes med logikken som gir currency fra in-game saker
        {
            hellaSoft += softGains; //legger til 1 basert p� hva som skjer i if statement
            PlayerPrefs.SetInt("amount", hellaSoft); //lagrer mengden i hellaCash som int i PlayerPrefs
        }  
    }

    void TowerTalents()
    {
        hardWallet.text = "" + hellaHard;
        if (Input.GetKeyDown(KeyCode.Backspace)) //m� erstattes med logikken som gir currency fra in-game saker
        {
            hellaHard += hardGains; //legger til 1 basert p� hva som skjer i if statement
            PlayerPrefs.SetInt("amount", hellaHard); //lagrer mengden i hellaCash som int i PlayerPrefs
        }
    }

    public void AddTowerTalents(int amount)
    {
        hellaHard += amount;
        PlayerPrefs.SetInt("amount", hellaHard); //lagrer mengden i hellaCash som int i PlayerPrefs
    }

    public void RemoveCalamityCoins(int amount)
    {
        hellaSoft -= amount;
        PlayerPrefs.SetInt("amount", hellaSoft); //lagrer mengden i hellaCash som int i PlayerPrefs
    }

    public void AddCalamityCoins(int amount)
    {
        hellaSoft += amount;
        PlayerPrefs.SetInt("amount", hellaSoft); //lagrer mengden i hellaCash som int i PlayerPrefs
    }

    public void RemoveTowerTalents (int amount)
    {
        hellaSoft -= amount;
        PlayerPrefs.SetInt("amount", hellaHard); //lagrer mengden i hellaCash som int i PlayerPrefs
    }

    public void ClearAllCurrency()
    {
        hellaHard = 0;
        hellaSoft = 0;
        PlayerPrefs.SetInt("amount", hellaHard); //lagrer mengden i hellaCash som int i PlayerPrefs
        PlayerPrefs.SetInt("amount", hellaSoft); //lagrer mengden i hellaCash som int i PlayerPrefs
    }

    public void DebugAddSoftCurrency()
    {
        hellaSoft += 500;
        PlayerPrefs.SetInt("amount", hellaSoft); //lagrer mengden i hellaCash som int i PlayerPrefs
    }


    public void AddSoftCurrencyEnemyDeath(int amount)
    {
        hellaSoft += amount;
        PlayerPrefs.SetInt("amount", hellaSoft); //lagrer mengden i hellaCash som int i PlayerPrefs
    }


}


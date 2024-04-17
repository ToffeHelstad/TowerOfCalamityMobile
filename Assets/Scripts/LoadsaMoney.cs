using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadsaMoney : MonoBehaviour
{
    public TextMeshProUGUI softWallet;
    public TextMeshProUGUI hardWallet;
    [SerializeField] public int softGains;
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
        if (Input.GetKeyDown(KeyCode.Space)) //må erstattes med logikken som gir currency fra in-game saker
        {
            hellaSoft += softGains; //legger til 1 basert på hva som skjer i if statement
            PlayerPrefs.SetInt("amount", hellaSoft); //lagrer mengden i hellaCash som int i PlayerPrefs
        }  
    }

    void TowerTalents()
    {
        hardWallet.text = "" + hellaHard;
        if (Input.GetKeyDown(KeyCode.Backspace)) //må erstattes med logikken som gir currency fra in-game saker
        {
            hellaHard += hardGains; //legger til 1 basert på hva som skjer i if statement
            PlayerPrefs.SetInt("amount", hellaHard); //lagrer mengden i hellaCash som int i PlayerPrefs
        }
    }


}


using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class LoadsaMoney : MonoBehaviour
{
    public int hellaCash;
    //public TextMeshPro wallet;
    public TextMeshProUGUI wallet;
 
    void Start()
    {
        hellaCash = PlayerPrefs.GetInt("amount"); //henter spillerens dosh fra int lagret i PlayerPrefs
    }

    void Update()
    {
        wallet.text = "" + hellaCash;
        if (Input.GetKeyDown(KeyCode.Space)) //må erstattes med logikken som gir currency fra in-game saker
        {
            hellaCash += 1; //legger til 1 basert på hva som skjer i if statement
            PlayerPrefs.SetInt("amount", hellaCash); //lagrer mengden i hellaCash som int i PlayerPrefs
        }
        
        if(Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}

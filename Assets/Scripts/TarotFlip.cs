using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TarotFlip : MonoBehaviour
{

    public GameObject card;

    Vector3 accelerationDir;

    void Update()
    {
        accelerationDir = Input.acceleration;

        if(accelerationDir.sqrMagnitude > 5f ) 
        {
            card.SetActive( false );
        }
    }
}

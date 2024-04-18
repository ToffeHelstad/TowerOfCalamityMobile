using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UXManager : MonoBehaviour
{
    public AudioClip buttonClickSound;
    public AudioSource audioSource;
    public float Volume = 0.7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonUXFire()
    {
        audioSource.PlayOneShot(buttonClickSound,Volume);
        Handheld.Vibrate();
    }
}

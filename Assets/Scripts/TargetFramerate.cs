using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFramerate : MonoBehaviour
{
    public int framerate;
    void Start()
    {
        Application.targetFrameRate = framerate;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

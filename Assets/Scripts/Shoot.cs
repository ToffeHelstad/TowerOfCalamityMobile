using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 cursorPos;
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        cursorPos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = cursorPos - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg ;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);


    }
}
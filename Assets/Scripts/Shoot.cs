using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 cursorPos;

    public GameObject bullet;
    public Transform bulletTransform;

    public bool canFire;
    public float timer;
    public float timeBetweenFiring;
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        cursorPos = mainCam.ScreenToWorldPoint(Input.mousePosition/*Input.touches[1].position*/);

        Vector3 rotation = cursorPos - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg ;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        if (!canFire)
        {
            timer += Time.deltaTime;
            if(timer > timeBetweenFiring)
            {
                canFire = true;
                timer = 0;
            }
        }

        /*if(Input.touchCount > 0 && canFire)
        {
            Touch touch = Input.GetTouch(0);
            canFire = false;
            Instantiate(bullet, bulletTransform.position, Quaternion.identity);
        }*/

        if (Input.GetMouseButton(0) && canFire)
        {
            canFire = false;
            Instantiate(bullet, bulletTransform.position, Quaternion.identity);
        }
    }
}

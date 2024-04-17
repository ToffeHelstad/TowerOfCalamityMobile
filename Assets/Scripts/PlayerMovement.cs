using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    Vector3 accelerationDir;

    public GameObject weapon1;
    public GameObject weapon2;

    public int activeWeapon;

    //[SerializeField] private InputActionReference moveInput;
    public FloatingJoystick joystick;

    private void Start()
    {
        activeWeapon = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //movement.x = Input.GetAxisRaw("Horizontal");
        //movement.y = Input.GetAxisRaw("Vertical");

        movement.x = joystick.Horizontal;
        movement.y = joystick.Vertical;

        accelerationDir = Input.acceleration;

        if (accelerationDir.sqrMagnitude > 5f || Input.GetKeyDown(KeyCode.G))
        {
            if(activeWeapon == 1)
            {
                activeWeapon = 2;
                weapon2.SetActive(true);
                weapon1.SetActive(false);
            }
            else if (activeWeapon == 2)
            {
                activeWeapon = 1;
                weapon2.SetActive(false);
                weapon1.SetActive(true);
            }
        }

        //movement = moveInput.action.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D Controller;

    float HorizontalMove = 0f;
    public float RunSpeed = 40f;
    bool Jump = false;
    bool crouch = false;

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {

        HorizontalMove = Input.GetAxisRaw("Horizontal") * RunSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            Jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

	}

    private void FixedUpdate()
    {
        //Move char
        Controller.Move(HorizontalMove * Time.fixedDeltaTime, crouch, Jump);
        Jump = false;
    }
}

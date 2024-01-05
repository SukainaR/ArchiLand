using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterMovement : MonoBehaviour
{
    private Animator animator;
    float horizontalInputCurrent;
    float verticalInputCurrent;
    

    void Start()
    {
        // Get the Animator component attached to the character
        animator = GetComponent<Animator>();
        

    }

    async void Update()
    {
            // Check for player input to move the character
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
      


        if(horizontalInput == 0)
        {
            // Player is providing input, trigger movement animation
            animator.SetBool("IsMoving", false);
        }
        else
        {
            animator.SetBool("IsMoving", true);
        }
     
    }
}


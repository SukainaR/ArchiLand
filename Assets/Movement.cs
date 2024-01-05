using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movement : MonoBehaviour
{
    private Animator animator;
    private bool IsMoving;
    float horizontalInputCurrent;
    float verticalInputCurrent;

    void Start()
    {
        // Get the Animator component attached to the character
        animator = GetComponent<Animator>();
        float horizontalInputCurrent = Input.GetAxis("Horizontal");
        float verticalInputCurrent = Input.GetAxis("Vertical");

    }

    void Update()
    {
        // Check for player input to move the character
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Console.WriteLine(verticalInput);
        Console.WriteLine("oi");


        if (horizontalInput != horizontalInputCurrent || verticalInput != verticalInputCurrent)
        {
            // Player is providing input, trigger movement animation
            animator.SetBool("IsMoving", true);
            animator.SetTrigger("Pigeon_Animation");


            // Add your movement code here
            horizontalInputCurrent = horizontalInput;
            horizontalInputCurrent = verticalInput;
        }
        else
        {
            Console.WriteLine(verticalInput);

            // No player input, trigger idle animation
            animator.SetBool("IsMoving", false);
            //animator.SetTrigger("idle_pigeon");
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Animator animator;
    private bool isMoving;

    void Start()
    {
        // Get the Animator component attached to the character
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check for input or movement conditions (you may need to adjust this based on your input setup)
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Check if the character is moving
        isMoving = (horizontalInput != 0f || verticalInput != 0f);

        // Update the Animator parameters
        animator.SetBool("IsMoving", isMoving);
    }
}

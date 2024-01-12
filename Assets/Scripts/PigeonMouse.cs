using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PigeonMouse : MonoBehaviour
{
    // Adjust this value to control the speed of the pigeon movement
    public float movementSpeed = 5f;
    public Vector3 targetPosition;

    private Animator animator;
    float horizontalInput;
    float verticalInput;



    void Start()
    {
        targetPosition = transform.position;
        // Get the Animator component attached to the character
        animator = GetComponent<Animator>();

    }
    void Update()
    {
        // Rotate the pigeon to face the mouse direction only in the horizontal plane
        RotateTowardsMouse();

        // Move the pigeon when the mouse is clicked
        MoveWithMouseClick();

        Animation();
    }

    void RotateTowardsMouse()
    {
        // Get the mouse position in screen coordinates
        Vector3 mousePosition = Input.mousePosition;

        // Convert the mouse position to world coordinates
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z));

        // Calculate the direction from the pigeon to the mouse in the horizontal plane
        Vector3 direction = new Vector3(mouseWorldPosition.x - transform.position.x, 0, 0);

        // Rotate the pigeon to face the mouse direction
        transform.right = direction.normalized;
    }

     void MoveWithMouseClick()
     {

        if (Input.GetMouseButtonDown(0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            targetPosition.z = transform.position.z;
            Debug.Log("Origin " + transform.position);
            Debug.Log("Target " + targetPosition);

        }

             //targetPosition.x += 100;
             transform.position = Vector3.MoveTowards(transform.position, targetPosition, movementSpeed*Time.deltaTime);
         

     }
    
    

    void Animation()
    {
        Debug.Log("heloo");
        // Check for player input to move the character
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput != 0 && verticalInput != 0)
        {
            // Player is providing input, trigger movement animation
            animator.SetBool("IsMoving", true);
            animator.SetTrigger("Pigeon_Animation");
        }
        else
        {
            animator.SetBool("IsMoving", false);
        }

    }
}

   


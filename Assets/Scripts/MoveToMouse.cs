using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveToMouse : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 target;

    float horizontalInput = 0f;
    float verticalInput = 0f;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal") * speed;
        verticalInput = Input.GetAxis("Vertical") * speed;
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

    }
}

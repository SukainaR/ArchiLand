using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMouse : MonoBehaviour
{

    public float movementSpeed = 5f;
    public Vector3 targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            targetPosition.z = transform.position.z;
            Debug.Log("Origin " + transform.position);
            Debug.Log("Target " + targetPosition);

        }

        //targetPosition.x += 100;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, movementSpeed * Time.deltaTime);
    }
}

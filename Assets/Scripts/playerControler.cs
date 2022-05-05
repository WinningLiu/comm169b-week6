using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerControler : MonoBehaviour
{
    // reference to the rigidbody to access. It is private, and hence the viewable from inspector
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 1;



    // Start is called before the first frame update
    void Start()
    {
        // Sets the value of rb by getting a reference of the Rigidbody component attached to the player sphere
        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        // you are not naming this Vector2 because this would be a Vector3 variable, which stores data across 3 axes
        //this is why you need to create 2 new variables to represent the additional directions
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement*speed);
    }


    void OnMove(InputValue movementValue)
    {
        // gets vector2 value from the movement data and stores it in a vector2 variable called "movementVector"
        Vector2 movementVector = movementValue.Get<Vector2>();

        //Reference these values inside onMove and assign these values vectors x and y
        movementX = movementVector.x;
        movementY = movementVector.y;
    }
}

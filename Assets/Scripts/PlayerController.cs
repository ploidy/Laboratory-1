using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour // player controller inherits from MonoBehaviour
{
    //Private Variables
    //[SerializeField] float speed = 20.0f;
    [SerializeField] private float horsePower = 0;
    [SerializeField] float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRb;
    [SerializeField] GameObject centerOfMass;
    
    //Public Variables
    public string inputID;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.localPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //This is where we get plater input
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis ("Vertical" + inputID);
        // Move the vehicle forward based on vertical input
        // transform.Translate (Vector3.forward * Time.deltaTime * speed * forwardInput);
        playerRb.AddRelativeForce(Vector3.forward * horsePower * forwardInput);
        // Rotates the car based on horizontal input
        transform.Rotate (Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}

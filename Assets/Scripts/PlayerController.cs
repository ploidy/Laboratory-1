using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour // player controller inherits from MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] private float horsePower = 0;
    [SerializeField] float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRb;
    [SerializeField] GameObject centerOfMass;
    [SerializeField] TextMeshProUGUI speedometerText;
    

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

        speed = Mathf.Round(playerRb.velocity.magnitude *2.237f);
        speedometerText.SetText("Speed: " + speed + "mph");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2DController : MonoBehaviour
{
    [Header ("Car settings")]
    public float accelerationFactor = 2f;
    public float turnFactor = -0.05f;

    //Local variables
    float accelerationInput = 0;
    float steeringInput = 0;

    float rotationAngle = 0;

    //Components
    Rigidbody2D carRigidbody2D;

    private void Awake()
    {
        carRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    void FixedUpdate()
    {


        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (Input.GetButton("Accelerate"))
        {
            rb.AddForce(transform.up * speedForce);
        }

        rb.AddTorque(Input.GetAxis("Horizontal") * torqueForce);
                
    }
}

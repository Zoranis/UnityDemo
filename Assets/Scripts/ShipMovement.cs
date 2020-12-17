using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float accelerationModifier = 10.0f;
    [SerializeField]
    private float rotationSpeed = 100.0f;
    [SerializeField]
    private float maxSpeed = 4.0f;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {

        // Respond to "W" and "S" for acceleration / deceleration
        float acceleration = Input.GetAxis("Vertical") * accelerationModifier * Time.deltaTime;
        rb.AddForce(transform.up * acceleration);

        // Limit ship speed
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }

        // Respond to "A" and "D" for rotation
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * (-1);
        transform.Rotate(0, 0, rotation);

        //Stop Motion
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            rb.velocity = Vector3.zero;
        }

        //Reset location
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            transform.position = new Vector3(0, 0, 0);
        }


        
    }

   
}

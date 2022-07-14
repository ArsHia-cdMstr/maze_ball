using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push_forward : MonoBehaviour
{
    public Rigidbody rb;
    public float jump;

    private void FixedUpdate()
    {
        // go forward
        if (Input.GetKey("w"))
            rb.AddForce(0, 0, 500 * Time.deltaTime);

        // go right
        if (Input.GetKey("d"))
            rb.AddForce(500 * Time.deltaTime, 0, 0);

        // go left
        if (Input.GetKey("a"))
            rb.AddForce(-500 * Time.deltaTime, 0, 0);

        // go back
        if (Input.GetKey("s"))
            rb.AddForce(0, 0, -500 * Time.deltaTime);

        // jump
        if (Input.GetKey("j"))
        {
            rb.AddForce(0, jump * Time.deltaTime, 0);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollPrism : MonoBehaviour
{
        public float moveSpeed = 5f;
        public float torque = 3f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
       float moveHorizontal = Input.GetAxis("Horizontal");
       float moveVertical = Input.GetAxis("Vertical");

       Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

       rb.AddForce(movement * moveSpeed);

       rb.AddTorque(Vector3.up * torque * moveHorizontal);
    }
}

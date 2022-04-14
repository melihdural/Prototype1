using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Set vehicle speed")]
    private float speed = 20;

    [SerializeField]
    [Tooltip("Set vehicle turn speed")]
    private float turnSpeed;

    private float horizontalInput;
    private float verticalInput;
    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        
        verticalInput = Input.GetAxis("Vertical");
        
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        
        //Move the vehicle left or right
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput * verticalInput);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Car damaged");
        }

        if (collision.gameObject.CompareTag("Cars"))
        {
            Debug.Log("Car crashed");
        }
    }
}

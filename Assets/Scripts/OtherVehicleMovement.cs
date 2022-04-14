using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherVehicleMovement : MonoBehaviour
{
    [SerializeField]
    private float otherVehicleSpeed;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * otherVehicleSpeed);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            transform.Rotate(0, 180, 0);
        }

        
    }

    


}

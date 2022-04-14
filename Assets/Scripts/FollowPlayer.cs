using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject vehicle;

    private Vector3 camOffset;

    private void Awake()
    {
        camOffset = Camera.main.transform.position;
    }

    void LateUpdate()
    {
        transform.position = vehicle.transform.position + camOffset;

    }
}

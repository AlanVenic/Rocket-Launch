using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopEjector : MonoBehaviour
{
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.up * 2100);
        }
    }
}

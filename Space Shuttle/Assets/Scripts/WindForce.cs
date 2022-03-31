using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class WindForce : MonoBehaviour
{
    public float Speed;
    public float AngularSpeed;
    protected Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Speed = rb.velocity.magnitude;
        AngularSpeed = rb.angularVelocity.magnitude;

        rb.AddForce(Vector3.right);
    }
}

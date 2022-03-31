using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleController : MonoBehaviour
{
    Rigidbody rb;

    public Animator ParachuteOff;
 
    void Start()
    {
        ParachuteOff = GetComponent<Animator>();
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * 1100);
            rb.AddRelativeForce(Vector3.right * 1000);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "ground")
        {
            ParachuteOff.Play("ParachuteOff");
        }
        
    }
}

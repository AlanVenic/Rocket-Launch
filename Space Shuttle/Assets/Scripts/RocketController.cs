using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    [SerializeField] public float thrusterForce = 10f;
    public static float fuel = 10000f;

    public ParticleSystem rocketFire, rocketSmoke;

    Rigidbody rb;

    float distance;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        distance = rb.transform.position.y;
        fuel -= distance;
        if (fuel <= 0f)
        {
            fuel = 0;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (fuel > 0f)
            {
                rb.AddRelativeForce(Vector3.up * thrusterForce * Time.deltaTime);
                rocketFire.Play();
                rocketSmoke.Play();
            }
            else
            {
                rocketFire.Stop();
                rocketSmoke.Stop();
            }
        }
    }
}

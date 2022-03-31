using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParachuteActivator : MonoBehaviour
{
    public Animator ParachuteOpen;

    void Start()
    {
        ParachuteOpen = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ParachuteOpen.Play("ParachuteOpen");
        }
    }
}

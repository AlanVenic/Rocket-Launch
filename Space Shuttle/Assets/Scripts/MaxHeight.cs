using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxHeight : MonoBehaviour
{
    public GameObject Capsule;
    public static float heightValue = 0f;
    Text height;

    void Start()
    {
        height = GetComponent<Text>();
    }

    public void Update()
    {
        heightValue = Capsule.transform.position.y;
        height.text = "Max Height: " + heightValue.ToString("F2") + "m";
    }
}

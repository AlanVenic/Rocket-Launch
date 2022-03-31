using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelInfo : MonoBehaviour
{
    public Text fuelText;
    public Image fuelBar;
    public Image[] fuelPoints;
    private static float currentFuel;
    float runFuel, maxFuel = 10000;
    float lerpSpeed;

    // Start is called before the first frame update
    public void Start()
    {
        currentFuel = maxFuel;
    }

    // Update is called once per frame
    void Update()
    {
        currentFuel = RocketController.fuel;
        fuelText.text = "Fuel: " + (currentFuel/ 100).ToString("F2") + "%";

        if (currentFuel > maxFuel)
        {
            currentFuel = maxFuel;
        }
        lerpSpeed = 3f * Time.deltaTime;
        FuelBarFiller();
    }

    void FuelBarFiller()
    {
        fuelBar.fillAmount = Mathf.Lerp(fuelBar.fillAmount, currentFuel/ maxFuel, lerpSpeed);
        for (int i = 0; i < fuelPoints.Length; i++)
        {
            fuelPoints[i].enabled = !DisplayFuelPoints((currentFuel/100), i);
        }
    }
    bool DisplayFuelPoints(float _fuel, int pointNumber)
    {
        return ((pointNumber * 10) >= _fuel);
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelBar : MonoBehaviour
{
    private static Image fuelImage;

    // Start is called before the first frame update
    void Start()
    {
        fuelImage = GetComponent<Image>();
    }

    public static void SetFuelBar(float value)
    {
        fuelImage.fillAmount = value;
    }
}

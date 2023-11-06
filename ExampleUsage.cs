using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleUsage : MonoBehaviour
{
    public MoonCoordinateConverter moonCoordinateConverter;

    void Start()
    {
        float moonLatitude = -85.0f;  // replace with ur desired moon longitude
        float moonLongitude = 27.0f; // replace with ur desired moon latitude

        Vector2 moonXY = moonCoordinateConverter.ConvertLatLonToXY(moonLatitude, moonLongitude);

        Debug.Log("Moon X: " + moonXY.x + " km");
        Debug.Log("Moon Y: " + moonXY.y + " km");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonCoordinateConverter : MonoBehaviour
{
    public float referenceLatitude = -85.3270888084309f;  // reference latitude
    public float referenceLongitude = 27.2893490192071f;  // reference longitude
    public float scaleFactor = 1.0f;  // Kilometers (your scale factor)

    public Vector2 ConvertLatLonToXY(float latitude, float longitude)
    {
        float deltaLat = latitude - referenceLatitude;
        float deltaLon = longitude - referenceLongitude;

        float X = deltaLon * scaleFactor;
        float Y = deltaLat * scaleFactor;

        return new Vector2(X, Y);
    }
}

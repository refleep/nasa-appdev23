using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

// the csv file is already in google drive, here is the code for you to experiment
// make sure the code is attached to a game object, then you should be able to run it

public class LatLongToCartesianConverter : MonoBehaviour
{
    public string latitudeFilePath = "path"; // replace "path" with the path of the latitude .csv
    public string longitudeFilePath = "path"; // replace "path" with the path of the longitude .csv
    public string outputFilePath = "path"; // replace "path" with the path of the .csv that you will save these coordinates in. to make a new csv file, you need to make an excel file first and then save as a .csv file.

// make sure the paths have double backslashes or the code won't work

    public float referenceLatitude = -85.3270888084309f; 
    public float referenceLongitude = 27.2893490192071f;
    public float scaleFactor = 1.0f;

    void Start()
    {
        ConvertLatLongToCartesian();
    }

    void ConvertLatLongToCartesian()
    {
        string[] latitudeLines = File.ReadAllLines(latitudeFilePath);
        string[] longitudeLines = File.ReadAllLines(longitudeFilePath);

        int numRows = latitudeLines.Length;
        int numCols = latitudeLines[0].Split(',').Length;

        float[,] cartesianCoordinates = new float[numRows, numCols];

        for (int i = 0; i < numRows; i++)
        {
            string[] latitudeValues = latitudeLines[i].Split(',');
            string[] longitudeValues = longitudeLines[i].Split(',');

            for (int j = 0; j < numCols; j++)
            {
                float latitude = float.Parse(latitudeValues[j]);
                float longitude = float.Parse(longitudeValues[j]);

                float x = (longitude - referenceLongitude) * scaleFactor;
                float y = (latitude - referenceLatitude) * scaleFactor;

                cartesianCoordinates[i, j] = x;
            }
        }

        SaveCartesianCoordinatesToFile(cartesianCoordinates);
    }

    void SaveCartesianCoordinatesToFile(float[,] cartesianCoordinates)
    {
        int numRows = cartesianCoordinates.GetLength(0);
        int numCols = cartesianCoordinates.GetLength(1);

        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            for (int i = 0; i < numRows; i++)
            {
                string line = "";

                for (int j = 0; j < numCols; j++)
                {
                    line += cartesianCoordinates[i, j].ToString() + ",";
                }

                writer.WriteLine(line.TrimEnd(','));
            }
        }

        Debug.Log("conversion complete, check cartesian coordinates saved to: " + outputFilePath);
    }
}

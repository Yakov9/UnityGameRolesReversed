using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera : MonoBehaviour
{
    public int zoomSize = 8;
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
            zoomSize--;
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
            zoomSize++;

        if (zoomSize == 1)
            zoomSize = 2;
        else if (zoomSize == 30)
            zoomSize = 29;
        GetComponent<Camera>().orthographicSize = zoomSize;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchCameraParameters : MonoBehaviour
{
    public Camera cameraToMatch;

    private Camera cam;
    void Awake()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        cam.fieldOfView = cameraToMatch.fieldOfView;
        cam.nearClipPlane = cameraToMatch.nearClipPlane;
        cam.farClipPlane = cameraToMatch.farClipPlane;
    }
}

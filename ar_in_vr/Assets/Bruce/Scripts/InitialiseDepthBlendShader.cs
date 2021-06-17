using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialiseDepthBlendShader : MonoBehaviour
{
    // Start is called before the first frame update
    public Material depthBlendMaterial;
    public Camera ARCamera;
    public Camera ARDepthCamera;

    RenderTexture ARRenderTexture;
    RenderTexture ARDepthRenderTexture;
    void Awake()
    {
        ARRenderTexture = new RenderTexture(Screen.width, Screen.height, 24, RenderTextureFormat.Default);
        ARDepthRenderTexture = new RenderTexture(Screen.width, Screen.height, 24, RenderTextureFormat.Depth);

        ARCamera.targetTexture = ARRenderTexture;
        ARDepthCamera.targetTexture = ARDepthRenderTexture;

        depthBlendMaterial.SetTexture("_SecondCameraTexture", ARRenderTexture);
        depthBlendMaterial.SetTexture("_SecondCameraDepthTexture", ARDepthRenderTexture);
    }

    // // Update is called once per frame
    // void Update()
    // {
    //
    //  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialiseDepthBlendShader : MonoBehaviour
{
    // Start is called before the first frame update
    public Material depthBlendMaterial;
    public Camera ARCamera;
    public Camera ARDepthCamera;

    public float ARFov = 45;
    public float alpha = .8f;

    private Camera activeCamera;

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

        activeCamera = Camera.main;
    }

    void Update()
    {
        float fovProportion = Mathf.Tan(ARFov * Mathf.Deg2Rad / 2f) / Mathf.Tan(activeCamera.fieldOfView * Mathf.Deg2Rad / 2);

        float edgePosition = 0.5f - (0.5f * fovProportion);

        depthBlendMaterial.SetFloat("_EdgeBoundary", edgePosition);
        depthBlendMaterial.SetFloat("_Alpha", alpha);
    }
}

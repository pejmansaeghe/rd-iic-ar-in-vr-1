using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARShaderControl : MonoBehaviour
{

    public Shader ARShader;

    public float ARFov = 45;
    public float ARAlpha = 0.8f;
    SkinnedMeshRenderer meshRenderer;
    Material arMaterial;
    Camera activeCamera;
    void Awake()
    {
        meshRenderer = GetComponent<SkinnedMeshRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        // arMaterial = new Material(ARShader);

        // meshRenderer.sharedMaterial = arMaterial;

        activeCamera = Camera.main;
        arMaterial = meshRenderer.material;
    }

    // Update is called once per frame
    void Update()
    {

        float fovProportion = Mathf.Tan(ARFov * Mathf.Deg2Rad / 2f) / Mathf.Tan(activeCamera.fieldOfView * Mathf.Deg2Rad / 2);

        float edgePosition = 0.5f - (0.5f * fovProportion);

        arMaterial.SetFloat("HorizontalEdge", edgePosition);
        arMaterial.SetFloat("VerticalEdge", edgePosition);
        arMaterial.SetFloat("Alpha", ARAlpha);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UserSetup : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cameraOffset;
    public float step = 0.05f;

    Transform mainCameraTransform;

    void Start()
    {
        mainCameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Recentre(InputAction.CallbackContext ctx)
    {
        Debug.Log("Recentering");

        if (ctx.started)
        {
            cameraOffset.transform.localPosition = new Vector3(-mainCameraTransform.localPosition.x, -mainCameraTransform.localPosition.y, -mainCameraTransform.localPosition.z);
        }
    }

    public void MoveForward(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            cameraOffset.transform.localPosition += new Vector3(0, 0, step);
        }
    }

    public void MoveBack(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            cameraOffset.transform.localPosition -= new Vector3(0, 0, step);
        }
    }

    public void MoveLeft(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            cameraOffset.transform.localPosition -= new Vector3(step, 0, 0);
        }
    }

    public void MoveRight(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            cameraOffset.transform.localPosition += new Vector3(step, 0, 0);
        }
    }

    public void MoveUp(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            cameraOffset.transform.localPosition += new Vector3(0, step, 0);
        }
    }

    public void MoveDown(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            cameraOffset.transform.localPosition -= new Vector3(0, step, 0);
        }
    }
}

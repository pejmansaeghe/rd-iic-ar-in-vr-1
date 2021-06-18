using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AdjustXRRigPosition : MonoBehaviour
{
    public float stepSize = 0.05f;
    private UserControls userControls;

    Vector3 initialRigPosition;
    void Awake()
    {
        initialRigPosition = transform.position;

        userControls = new UserControls();

        userControls.SetUp.Enable();

        DefineControlFunctionality(userControls);
    }

    private void DefineControlFunctionality(UserControls userControls)
    {
        userControls.SetUp.MoveLeft.performed += _ =>
        {
            Vector3 currentPosition = gameObject.transform.position;
            currentPosition.x -= stepSize;
            gameObject.transform.position = currentPosition;
        };

        userControls.SetUp.MoveRight.performed += _ =>
        {
            Vector3 currentPosition = gameObject.transform.position;
            currentPosition.x += stepSize;
            gameObject.transform.position = currentPosition;
        };

        userControls.SetUp.MoveForward.performed += _ =>
        {
            Vector3 currentPosition = gameObject.transform.position;
            currentPosition.z += stepSize;
            gameObject.transform.position = currentPosition;
        };

        userControls.SetUp.MoveBack.performed += _ =>
        {
            Vector3 currentPosition = gameObject.transform.position;
            currentPosition.z -= stepSize;
            gameObject.transform.position = currentPosition;
        };

        userControls.SetUp.MoveUp.performed += _ =>
        {
            Vector3 currentPosition = gameObject.transform.position;
            currentPosition.y += stepSize;
            gameObject.transform.position = currentPosition;
        };
        userControls.SetUp.MoveDown.performed += _ =>
        {
            Vector3 currentPosition = gameObject.transform.position;
            currentPosition.y -= stepSize;
            gameObject.transform.position = currentPosition;
        };

        userControls.SetUp.RecentreView.performed += _ =>
        {
            gameObject.transform.position = initialRigPosition;
        };
    }

    void OnEnable()
    {
        userControls.SetUp.Enable();
    }

    void OnDisable()
    {
        userControls.SetUp.Disable();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

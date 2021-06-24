using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using PathCreation.Examples;
using System;

[RequireComponent(typeof(PathFollower))]
[RequireComponent(typeof(Animator))]
public class TurtleController : MonoBehaviour
{
    public PathCreator[] paths;

    PathFollower pathFollower;

    Animator animator;

    UserControls userControls;

    Vector3 previousPosition;

    bool nearCoffeeTable = false;

    void Awake()
    {
        pathFollower = GetComponent<PathFollower>();
        pathFollower.enabled = false;

        animator = GetComponent<Animator>();

        userControls = new UserControls();
        userControls.Debug.TriggerPath.performed += _ =>
        {
            Debug.Log("Trigger path");
            StartPathIndex(0);
        };

    }

    private void TurtleAtEndOfPath()
    {
        Debug.Log("Turtle at end of path");
    }

    void OnEnable()
    {
        userControls.Debug.Enable();
    }

    void OnDisable()
    {
        userControls.Debug.Disable();
    }

    public void StartPathIndex(int idx)
    {
        if (idx < 0 || idx >= paths.Length)
        {
            return;
        }

        pathFollower.enabled = true;
        pathFollower.Reset();
        pathFollower.pathCreator = paths[idx];

        previousPosition = transform.position;
    }

    void LateUpdate()
    {
        animator.SetBool("TurtleIdle", TurtleStationary() || nearCoffeeTable);

        previousPosition = transform.position;
    }

    private bool TurtleStationary()
    {
        return Vector3.Distance(previousPosition, transform.position) <= 0.001f;
    }

    void OnTriggerEnter(Collider other)
    {
        nearCoffeeTable = true;

    }

    void OnTriggerExit(Collider other)
    {
        nearCoffeeTable = false;

    }
}

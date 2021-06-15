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

    bool followingPath = false;

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
        Debug.Log("TurtleController.StartPathIndex: " + idx);
        if (idx < 0 || idx >= paths.Length)
        {
            return;
        }

        pathFollower.enabled = true;
        pathFollower.Reset();
        pathFollower.pathCreator = paths[idx];

        previousPosition = transform.position;
        followingPath = true;
    }

    void LateUpdate()
    {
        if (followingPath && Vector3.Distance(previousPosition, transform.position) < 1e-6)
        {
            Debug.Log("End of path reached");
            followingPath = false;
            animator.SetBool("TurtleIdle", true);
        }

        previousPosition = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        animator.SetBool("TurtleIdle", true);
    }

    void OnTriggerExist(Collider other)
    {
        animator.SetBool("TurtleIdle", false);
    }
}

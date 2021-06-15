using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using PathCreation.Examples;

[RequireComponent(typeof(PathFollower))]
[RequireComponent(typeof(Animator))]
public class TurtleController : MonoBehaviour
{
    public PathCreator[] paths;

    PathFollower pathFollower;

    Animator animator;

    UserControls userControls;

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

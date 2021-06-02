using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GameController : MonoBehaviour
{
    /// <summary>
    /// control turtle's animation based on the video
    /// </summary>
    [SerializeField]
    private VideoPlayer videoPlayer;

    [SerializeField]
    private GameObject turtle;

    [SerializeField]
    private int startAnimFrame = 50;

    private Animator animator;

    private void Awake()
    {
        animator = turtle.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(videoPlayer.frame);
        if(videoPlayer.frame > startAnimFrame)
        {
            animator.SetBool("IsSwimming", true);
            animator.SetBool("IsMovingForward", true);
        }
        if(turtle.transform.position.y < 0.7f)
        {
            animator.SetBool("Land", true);
        }
        if (turtle.transform.position.y < 0.49f) 
        {
            animator.SetBool("Landed", true);
        }
        if (turtle.transform.localRotation.eulerAngles.y < 100f)
        {
            animator.SetBool("StopMoving", true);
        }

    }

}

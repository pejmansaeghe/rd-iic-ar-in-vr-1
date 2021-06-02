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
    private bool perpetual = false;

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
            if (perpetual)
            {
                animator.SetBool("Perpetual", true);
            }
            else
            {
                animator.SetBool("TowardsTable", true);
            }
        }
        if(turtle.transform.position.y < 0.55f)
        {
            animator.SetBool("Land", true);
        }
        //if (turtle.transform.position.y < 0.49f) 
        //{
        //    animator.SetBool("Landed", true);
        //}
        if (turtle.transform.position.y < 0.412f)
        {
            animator.SetBool("StopMoving", true);
        }
        if (videoPlayer.frame > 912)
        {
            animator.enabled = false;
        }

    }

}

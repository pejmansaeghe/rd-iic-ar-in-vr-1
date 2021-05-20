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
    private Animator animator;

    private void Awake()
    {
        animator = turtle.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(videoPlayer.frame);
        if(videoPlayer.frame > 50)
        {
            animator.SetBool("IsSwimming", true);
            animator.SetBool("IsMovingForward", true);
        }
    }

}

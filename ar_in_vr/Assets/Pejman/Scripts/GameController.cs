using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;
using System;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject canvas;
    [SerializeField]
    private TextMeshProUGUI canvasText;
    [SerializeField]
    private GameObject canvasButton;
    [SerializeField]
    private VideoPlayer videoPlayer;

    public TurtleController turtleController;
    private GameObject turtle;

    [Range(1, 6)]
    [SerializeField]
    private int LatinRow; // don't change while in Play mode
    [SerializeField]
    private VideoClip[] clips;
    [SerializeField]
    private int startAnimFrame = 50;

    // decides which video and animation will be played next; starts from 0 and goes up to 5
    private int index = 0;

    delegate void Condition();
    List<Condition> conditions = new List<Condition>();

    // oder of conditions (columns) in each Latin square row 
    private int[] playOrder = new int[6];

    UserControls userControls;
    private void Awake()
    {

        turtle = turtleController.gameObject;

        //turtle.SetActive(false);
        canvas.SetActive(true);

        userControls = new UserControls();

        userControls.Debug.PlayNextVideoSequence.performed += _ =>
        {
            Debug.Log("PlayNextVideoSequence");
            PlayNextCondition();
        };
    }
    private void Start()
    {
        //index = 0;
        videoPlayer.loopPointReached += EndReached;

        CreateAnimationOrder();

        Debug.Log("Sequence order: ");
        foreach (int s in playOrder)
        {
            Debug.Log(s);
        }
    }

    void OnEnable()
    {
        userControls.Debug.Enable();
    }

    void OnDisable()
    {
        userControls.Debug.Disable();
    }
    void EndReached(VideoPlayer vp)
    {
        turtle.SetActive(false);
        DisplayUI();
  
        if (index >= clips.Length) //at end of the experiment
        {
            videoPlayer.Stop();
        }
    }
    /// <summary>
    /// display UI immediately after the clip is finished, to ask participants to remove HMD
    /// </summary>
    private void DisplayUI()
    {
        canvas.SetActive(true);
        canvasButton.SetActive(false);
        canvasText.text = "Please remove HMD and speak to the moderator";
        if(index < clips.Length)
        {
            StartCoroutine(ChangeUI());
        }
    }
    /// <summary>
    /// while HMD is not worn, update UI. When the participant wears HMD they see new message with button to click
    /// </summary>
    /// <returns></returns>
    IEnumerator ChangeUI()
    {
        yield return new WaitForSeconds(20);
        canvasButton.SetActive(true);
        canvasText.text = "Click Next to view clip";
    }

    /// <summary>
    /// UI button triggers this function
    /// </summary>
    public void PlayNextCondition()
    {
        canvas.SetActive(false);

        Debug.Log("Playing Latin sequence: " + playOrder[index]);

        int currentSequence = playOrder[index] - 1; // -1 because the Latin square values are not zero-referenced.

        videoPlayer.clip = clips[index];
        videoPlayer.Play();

        turtle.SetActive(true);
        turtleController.StartPathIndex(currentSequence);

        index += 1;
    }
    /// <summary>
    /// Set animation based on participant number; only 6 unique rows in the Latin square; participant 7 in the study will see what participant 1 saw.
    /// If we decide to let participants input their number then we need function to map >6 numbers to a 1-6 range.
    /// Selects the correct animation sequence based on a Latin square (see study protocol)
    /// </summary>
    void CreateAnimationOrder()
    {
        switch (LatinRow)
        {
            case 1:
                // set the columns in the first row 
                playOrder[0] = 1;
                playOrder[1] = 2;
                playOrder[2] = 6;
                playOrder[3] = 3;
                playOrder[4] = 5;
                playOrder[5] = 4;
                break;
            case 2:
                // set the columns in the second row
                playOrder[0] = 2;
                playOrder[1] = 3;
                playOrder[2] = 1;
                playOrder[3] = 4;
                playOrder[4] = 6;
                playOrder[5] = 5;
                break;
            case 3:
                // set the columns in the third row
                playOrder[0] = 3;
                playOrder[1] = 4;
                playOrder[2] = 2;
                playOrder[3] = 5;
                playOrder[4] = 1;
                playOrder[5] = 6;
                break;
            case 4:
                // set the columns in the fourth row
                playOrder[0] = 4;
                playOrder[1] = 5;
                playOrder[2] = 3;
                playOrder[3] = 6;
                playOrder[4] = 2;
                playOrder[5] = 1;
                break;
            case 5:
                // set the columns in the fifth row
                playOrder[0] = 5;
                playOrder[1] = 6;
                playOrder[2] = 4;
                playOrder[3] = 1;
                playOrder[4] = 3;
                playOrder[5] = 2;
                break;
            case 6:
                // set the columns in the sixsth row
                playOrder[0] = 6;
                playOrder[1] = 1;
                playOrder[2] = 5;
                playOrder[3] = 2;
                playOrder[4] = 4;
                playOrder[5] = 3;
                break;
        }
    }

    //todo: canvas taxt should change for each condition, e.g. before a clip it should say "please press Next to watch", after clip
    // it should say "please remove HMD and speak to the moderator" this may change into the former message using a time (e.g. after 
    // 30 seconds).
    //todo: videoplayer should render a black screen when not playing (between clips)
    //todo: turtle too shiny
    //todo: end of final video turtle doesn't disappear. why?
}

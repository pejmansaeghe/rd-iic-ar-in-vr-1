using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject canvas;
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
    enum Movement { Perpetual, TowardsTable };
    private Movement movement;
    enum StartingPoint { WithinTV, AdjacentTV, OutsideFoV };
    private StartingPoint startingPoint;

    private Vector3 withinTVStartPos;
    private Vector3 adjacentTVStartPos;
    private Vector3 outsideFoVStartPos;

    delegate void Condition();
    List<Condition> conditions = new List<Condition>();

    // oder of conditions (columns) in each Latin square row 
    private int[] conditionOrder = new int[6];

    UserControls userControls;
    private void Awake()
    {
        // add all 6 conditions to a list called conditions 
        conditions.Add(Condition_1);
        conditions.Add(Condition_2);
        conditions.Add(Condition_3);
        conditions.Add(Condition_4);
        conditions.Add(Condition_5);
        conditions.Add(Condition_6);

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
        withinTVStartPos = new Vector3(9.392f, 1.2f, 0);
        adjacentTVStartPos = new Vector3(8f, 1.2f, 0);
        outsideFoVStartPos = new Vector3(9.392f, 3.2f, 0);

        videoPlayer.clip = clips[index];
        videoPlayer.loopPointReached += EndReached;
        SetAnimation(index);
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
        // after each videos 1 to 5 do the following
        turtle.SetActive(false);
        canvas.SetActive(true);
        if (index < clips.Length)
        {
            index++;
            vp.clip = clips[index];
            //vp.Play();
            SetAnimation(index);
        }
        // at the end of video 6 (the last video) execute the code below
        else
        {
            turtle.SetActive(false);
            vp.Stop();
        }
    }
    /// <summary>
    /// UI button triggers this function
    /// </summary>
    public void PlayNextCondition()
    {
        canvas.SetActive(false);
        videoPlayer.Play();

        turtle.SetActive(true);
        turtleController.StartPathIndex(index);
    }
    /// <summary>
    /// Set animation based on participant number; only 6 unique rows in the Latin square; participant 7 in the study will see what participant 1 saw.
    /// If we decide to let participants input their number then we need function to map >6 numbers to a 1-6 range.
    /// Selects the correct animation sequence based on a Latin square (see study protocol)
    /// </summary>
    void SetAnimation(int index)
    {
        int condition_ind;
        switch (LatinRow)
        {
            case 1:
                // set the columns in the first row 
                conditionOrder[0] = 1;
                conditionOrder[1] = 2;
                conditionOrder[2] = 6;
                conditionOrder[3] = 3;
                conditionOrder[4] = 5;
                conditionOrder[5] = 4;
                // select the next animation sequence everytime SetAnimation is called, since the index gets added by one after each video
                condition_ind = conditionOrder[index] - 1;
                conditions[condition_ind]();
                break;
            case 2:
                // set the columns in the second row
                conditionOrder[0] = 2;
                conditionOrder[1] = 3;
                conditionOrder[2] = 1;
                conditionOrder[3] = 4;
                conditionOrder[4] = 6;
                conditionOrder[5] = 5;

                condition_ind = conditionOrder[index] - 1;
                conditions[condition_ind]();
                break;
            case 3:
                // set the columns in the third row
                conditionOrder[0] = 3;
                conditionOrder[1] = 4;
                conditionOrder[2] = 2;
                conditionOrder[3] = 5;
                conditionOrder[4] = 1;
                conditionOrder[5] = 6;

                condition_ind = conditionOrder[index] - 1;
                conditions[condition_ind]();
                break;
            case 4:
                // set the columns in the fourth row
                conditionOrder[0] = 4;
                conditionOrder[1] = 5;
                conditionOrder[2] = 3;
                conditionOrder[3] = 6;
                conditionOrder[4] = 2;
                conditionOrder[5] = 1;

                condition_ind = conditionOrder[index] - 1;
                conditions[condition_ind]();
                break;
            case 5:
                // set the columns in the fifth row
                conditionOrder[0] = 5;
                conditionOrder[1] = 6;
                conditionOrder[2] = 4;
                conditionOrder[3] = 1;
                conditionOrder[4] = 3;
                conditionOrder[5] = 2;

                condition_ind = conditionOrder[index] - 1;
                conditions[condition_ind]();
                break;
            case 6:
                // set the columns in the sixsth row
                conditionOrder[0] = 6;
                conditionOrder[1] = 1;
                conditionOrder[2] = 5;
                conditionOrder[3] = 2;
                conditionOrder[4] = 4;
                conditionOrder[5] = 3;

                condition_ind = conditionOrder[index] - 1;
                conditions[condition_ind]();
                break;
        }
    }
    void Update()
    {
        /*
        if (videoPlayer.frame > startAnimFrame)
        {
            turtle.SetActive(true);
            animator.SetBool("IsSwimming", true);
            switch (movement)
            {
                case Movement.Perpetual:
                    animator.SetBool("Perpetual", true);
                    switch (startingPoint)
                    {
                        case StartingPoint.WithinTV:
                            animator.SetBool("WithinTV", true);
                            break;
                        case StartingPoint.AdjacentTV:
                            animator.SetBool("AdjacentTV", true);
                            break;
                        case StartingPoint.OutsideFoV:
                            animator.SetBool("OutsideFoV", true);
                            break;
                    }
                    break;
                case Movement.TowardsTable:
                    animator.SetBool("TowardsTable", true);
                    switch (startingPoint)
                    {
                        case StartingPoint.WithinTV:
                            animator.SetBool("WithinTV", true);
                            break;
                        case StartingPoint.AdjacentTV:
                            animator.SetBool("AdjacentTV", true);
                            break;
                        case StartingPoint.OutsideFoV:
                            animator.SetBool("OutsideFoV", true);
                            break;
                    }

                    if (turtle.transform.position.y < 0.55f)
                    {
                        animator.SetBool("Land", true);
                    }
                    if (turtle.transform.position.y < 0.412f)
                    {
                        animator.SetBool("StopMoving", true);
                    }
                    break;
            }

        }
        */
    }
    /// <summary>
    /// Starting point: Within TV screen, movement: towards the viewer and resting in front of them
    /// </summary>
    void Condition_1()
    {
        Quaternion rotation = Quaternion.Euler(0, 180, 0);
        turtle.transform.SetPositionAndRotation(withinTVStartPos, rotation);
        startingPoint = StartingPoint.WithinTV;
        movement = Movement.TowardsTable;
    }
    /// <summary>
    /// Starting point: Within TV screen, movement: perpetual movement across field of view
    /// </summary>
    void Condition_2()
    {
        Quaternion rotation = Quaternion.Euler(0, 165, 0);
        turtle.transform.SetPositionAndRotation(withinTVStartPos, rotation);
        startingPoint = StartingPoint.WithinTV;
        movement = Movement.Perpetual;
    }
    /// <summary>
    /// Starting point: Adjacent to TV, movement: towards the viewer and resting in front of them
    /// </summary>
    void Condition_3()
    {
        Quaternion rotation = Quaternion.Euler(0, 140, 0);
        turtle.transform.SetPositionAndRotation(adjacentTVStartPos, rotation);
        startingPoint = StartingPoint.AdjacentTV;
        movement = Movement.TowardsTable;
    }
    /// <summary>
    /// Starting point: Adjacent to TV, movement: perpetual movement
    /// </summary>
    void Condition_4()
    {
        Quaternion rotation = Quaternion.Euler(0, 140, 0);
        turtle.transform.SetPositionAndRotation(adjacentTVStartPos, rotation);
        startingPoint = StartingPoint.AdjacentTV;
        movement = Movement.Perpetual;
    }
    /// <summary>
    /// Starting point: Outside fov, movement: towards the viewer and resting in front of them
    /// </summary>
    void Condition_5()
    {
        Quaternion rotation = Quaternion.Euler(50, 180, 0);
        turtle.transform.SetPositionAndRotation(outsideFoVStartPos, rotation);
        startingPoint = StartingPoint.OutsideFoV;
        movement = Movement.TowardsTable;
    }
    /// <summary>
    /// Starting point: Outside fov, movement: perpetual movement across field of view
    /// </summary>
    void Condition_6()
    {
        Quaternion rotation = Quaternion.Euler(50, 165, 0);
        turtle.transform.SetPositionAndRotation(outsideFoVStartPos, rotation);
        startingPoint = StartingPoint.OutsideFoV;
        movement = Movement.Perpetual;
    }
    //todo: canvas taxt should change for each condition, e.g. before a clip it should say "please press Next to watch", after clip
    // it should say "please remove HMD and speak to the moderator" this may change into the former message using a time (e.g. after 
    // 30 seconds).
    //todo: videoplayer should render a black screen when not playing (between clips)
    //todo: turtle too shiny
    //todo: end of final video turtle doesn't disappear. why?
}

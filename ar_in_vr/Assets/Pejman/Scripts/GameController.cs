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

    //// if true then movement is perpetual, otherwise, the turtle lands on the table
    //private bool perpetual;

    [Range(1, 6)]
    [SerializeField]
    private int participantNumber;

    [SerializeField]
    private VideoClip[] clips;

    [SerializeField]
    private int startAnimFrame = 50;

    private Animator animator;

    // decides which video and animation will be played next; starts from 0 and goes up to 5
    private int index = 0;

    enum Movement { Perpetual, Towards_Table};
    private Movement movement;
    enum StartingPoint { Within_TV, TV_Adjacent, Outside_FoV};
    private StartingPoint startingPoint;

    private Vector3 withinTVPosition;
    private Vector3 adjacentTVPosition;
    private Vector3 outsideFoVPosition;

    delegate void Condition();
    List<Condition> conditions = new List<Condition>();

    // oder of conditions (columns) in each Latin square row 
    private int[] conditionSequence = new int[6];

    private void Awake()
    {
        animator = turtle.GetComponent<Animator>();
        // add all 6 conditions to a list called conditions 
        conditions.Add(Condition_1);
        conditions.Add(Condition_2);
        conditions.Add(Condition_3);
        conditions.Add(Condition_4);
        conditions.Add(Condition_5);
        conditions.Add(Condition_6);

    }

    private void Start()
    {
        // set the starting position for the turtle
        withinTVPosition = new Vector3(9.392f, 1.2f, 0);
        adjacentTVPosition = new Vector3(8f, 1.2f, 0);
        outsideFoVPosition = new Vector3(9.392f, 3.2f, 0);

        videoPlayer.clip = clips[index];
        videoPlayer.loopPointReached += EndReached;

        LatinSquareRow();

    }

    void EndReached(VideoPlayer vp)
    {
        animator.enabled = false;
        turtle.SetActive(false);
        if (index < clips.Length)
        {
            index++;
            vp.clip = clips[index];
            vp.Play();


            LatinSquareRow();
        }
    }
    /// <summary>
    /// there are only 6 unique rows in our latin square, based on 6 condition
    /// </summary>
    /// <param name="participantNumber"></param>
    /// <returns></returns>
    int LatinRow(int participantNumber)
    {
        int latinRow = participantNumber % 6;
        if(latinRow == 0)
        {
            return 6;
        }
        return latinRow;
    }
    /// <summary>
    /// Cases correspond to rows in the latin square
    /// </summary>
    void LatinSquareRow()
    {
        //reset the animation
        //animator.Rebind();
        //animator.Update(0f);
        //animator.Play("Idle", -1, 0f);
        //animator.Play("New State", -1, 0f);
        animator.enabled = true;
        switch (LatinRow(participantNumber))
        {
            case 1:
                // set the columns in the row in the correct order
                conditionSequence[0] = 1;
                conditionSequence[1] = 2;
                conditionSequence[2] = 6;
                conditionSequence[3] = 3;
                conditionSequence[4] = 5;
                conditionSequence[5] = 4;

                int condition_ind = conditionSequence[index] - 1;
                conditions[condition_ind]();
                break;
            case 2:
                break;
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(LatinRow(participantNumber));
        //Debug.Log(videoPlayer.frame);

        if (videoPlayer.frame > startAnimFrame)
        {
            animator.SetBool("IsSwimming", true);
            switch (movement)
            {
                case Movement.Perpetual:
                    animator.SetBool("Perpetual", true);
                    break;
                case Movement.Towards_Table:
                    animator.SetBool("TowardsTable", true);
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




        //if (videoPlayer.frame > 912)
        //{
        //    animator.enabled = false;
        //}

    }



    /// <summary>
    /// Starting point: Within TV screen, movement: towards the viewer and resting in front of them
    /// </summary>
    void Condition_1()
    {
        Quaternion rotation = Quaternion.Euler(0, 180, 0);
        turtle.transform.SetPositionAndRotation(withinTVPosition, rotation);
        turtle.SetActive(true);

        startingPoint = StartingPoint.Within_TV;
        movement = Movement.Towards_Table;
    }

    /// <summary>
    /// Starting point: Within TV screen, movement: perpetual movement across field of view
    /// </summary>
    void Condition_2()
    {
        Quaternion rotation = Quaternion.Euler(0, 165, 0);
        turtle.transform.SetPositionAndRotation(withinTVPosition, rotation);
        turtle.SetActive(true);

        startingPoint = StartingPoint.Within_TV;
        movement = Movement.Perpetual;
    }
    /// <summary>
    /// Starting point: Adjacent to TV, movement: towards the viewer and resting in front of them
    /// </summary>
    void Condition_3()
    {
        Quaternion rotation = Quaternion.Euler(0, 180, 0);
        turtle.transform.SetPositionAndRotation(adjacentTVPosition, rotation);
        turtle.SetActive(true);

        startingPoint = StartingPoint.TV_Adjacent;
        movement = Movement.Towards_Table;
    }

    /// <summary>
    /// Starting point: Adjacent to TV, movement: perpetual movement
    /// </summary>
    void Condition_4()
    {
        Quaternion rotation = Quaternion.Euler(0, 165, 0);
        turtle.transform.SetPositionAndRotation(adjacentTVPosition, rotation);
        turtle.SetActive(true);

        startingPoint = StartingPoint.TV_Adjacent;
        movement = Movement.Perpetual;
    }
    /// <summary>
    /// Starting point: Outside fov, movement: towards the viewer and resting in front of them
    /// </summary>
    void Condition_5()
    {
        Quaternion rotation = Quaternion.Euler(0, 180, 0);
        turtle.transform.SetPositionAndRotation(outsideFoVPosition, rotation);
        turtle.SetActive(true);

        startingPoint = StartingPoint.Outside_FoV;
        movement = Movement.Towards_Table;
    }

    /// <summary>
    /// Starting point: Outside fov, movement: perpetual movement across field of view
    /// </summary>
    void Condition_6()
    {
        Quaternion rotation = Quaternion.Euler(0, 165, 0);
        turtle.transform.SetPositionAndRotation(outsideFoVPosition, rotation);
        turtle.SetActive(true);

        startingPoint = StartingPoint.Outside_FoV;
        movement = Movement.Perpetual;
    }
    

    //todo: follow the example of case 1 and create a sequence per Latin square row.
    //todo: create new animations for TV_adjacent and outside_FoV starting points; probably copy and past of existing ones with the first column inside animation clip modified to reflect starting position.
    //todo: add UI to the scene; load UI after each video ends, and play next video/animation when UI button clicked.
}

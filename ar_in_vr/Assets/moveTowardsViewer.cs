using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowardsViewer : MonoBehaviour
{
    SeaTurtleCharacter turtle;

    private void Awake()
    {
        turtle = GetComponent<SeaTurtleCharacter>();
    }

    private void Start()
    {
        turtle.forwardSpeed = 2;
        turtle.Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

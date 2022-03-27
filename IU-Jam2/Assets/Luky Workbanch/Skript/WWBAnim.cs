using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WWBAnim : MonoBehaviour
{
    //animator variables
    private Animator anim;

    //animation numerator
    public string[] idleDirections = { "BIdle N", "BIdle NW", "BIdle W", "BIdle SW", "BIdle S", "BIdle SO", "BIdle O", "BIdle NO" };
    public string[] runDirections = { "BRun N", "BRun NW", "BRun W", "BRun SW", "BRun S", "Brun SO", "BrunO", "BRun NO" };

    int lastDirection;

    private void Awake()
    {
        anim = GetComponent<Animator>();

        

    }

    public void SetDirection(Vector2 _direction)
    {


        string[] directionArray = null;

        // if player is not moving
        if (_direction.magnitude < 0.01)
        {
            directionArray = idleDirections;
        }

        else
        {
            directionArray = runDirections;

            //get the index of the slice from the direction vector
            lastDirection = DirectionToIndex(_direction);
        }

        anim.Play(directionArray[lastDirection]);
    }

    //converts a Vector2  direction to an index to a slice around a circle
    //this goes in a counter-clock direction
    private int DirectionToIndex(Vector2 _direction)
    {
        //return this vector with a magnitude of 1 and get the normalized to an .......
        Vector2 norDir = _direction.normalized;

        // 45 on circle and 8 slices (calculate how many degrees one slice is)
        float step = 360 / 8;

        //22.5 (OFFSET helps us easy to calculate  and get the correct index of the string array
        float offset = step / 2;

        // returns to the signet angle in degrees between A and B
        float angle = Vector2.SignedAngle(Vector2.up, norDir);

        angle += offset;
        if (angle < 0)
        {
            angle += 360;
        }

        float stepCount = angle / step;
        return Mathf.FloorToInt(stepCount);

    }
}

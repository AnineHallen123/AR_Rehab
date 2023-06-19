using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeExcercise : MonoBehaviour
{
    public float excerciseTime = 90;
    void Update()
    {

        if (excerciseTime > 0)
        {
            excerciseTime -= Time.deltaTime;
        }

        else
        {
            excerciseTime = 0;

        }
       
    }

    void DisplayTime(float timeToDisplay)
    {

    }
}

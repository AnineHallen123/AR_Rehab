using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;


public class TimeExcercise : MonoBehaviour
{
    public float excerciseTime;
    public TextMeshPro timeText;
    public UnityEvent TimerOver;
    int _counter;
    void Update()
    {

        if (excerciseTime > 0)
        {
            excerciseTime -= Time.deltaTime;
        }

        else
        {
            excerciseTime = 0;
            TimerOver.Invoke();

        }
        DisplayTime(excerciseTime);

    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void resetTimer()
    {
        excerciseTime = 60;

    }


    }




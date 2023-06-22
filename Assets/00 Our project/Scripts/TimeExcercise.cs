using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TimeExcercise : MonoBehaviour
{
    public float excerciseTime = 90;
    public TextMeshProUGUI timeText;

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

        }

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

    }




using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeMinutes : MonoBehaviour
{
    float seconds, minutes;
    public Text timeText;
    void Update()
    {
        seconds = seconds + Time.deltaTime;
        
        timeText.text = "Time " + Math.Ceiling(minutes) + ":" + Math.Ceiling(seconds); ; ;

        if (seconds >= 60.0f)
        {
            minutes = minutes + 1.0f;
            seconds = 0.0f;
        }

        if (minutes >= 60.0f)
        {
            minutes = 0.0f;
        }
    }
}

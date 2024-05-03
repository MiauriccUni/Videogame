using System;
using UnityEngine;

[Serializable]
public class Countdown : MonoBehaviour
{
    public int TimeInSeconds { get { return (int)timeInSecondsFloat; } private set { TimeInSeconds = value; } }

    private float timeInSecondsFloat;

    public int TimeInMinutes { get; private set; }

    public Countdown(int timeInSeconds)
    {
        this.TimeInSeconds = timeInSeconds;
        this.timeInSecondsFloat = timeInSeconds;
        this.TimeInMinutes = timeInSeconds / 60;
    }

    public void DecreaseTime()
    {
        timeInSecondsFloat -= Time.deltaTime;
        TimeInMinutes = TimeInSeconds / 60;
    }

    public void ResetTime()
    {
        TimeInSeconds = 0;
        TimeInMinutes = 0;
    }

    public void SetTime(int timeInSeconds)
    {
        this.TimeInSeconds = timeInSeconds;
        this.TimeInMinutes = timeInSeconds / 60;
    }

    public void SetTime(int timeInMinutes, int timeInSeconds)
    {
        this.TimeInSeconds = timeInSeconds + (timeInMinutes * 60);
        this.TimeInMinutes = timeInMinutes;
    }

    public string GetTime()
    {
        return TimeInMinutes.ToString("00") + ":" + (TimeInSeconds % 60).ToString("00");
    }



    public bool IsTimeOver()
    {
        return TimeInSeconds <= 0;
    }

    public static string FormatFromSeconds(int seconds)
    {
        return (seconds / 60).ToString("00") + ":" + (seconds % 60).ToString("00");
    }
}
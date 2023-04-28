using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float totalTime = 60f; // Total time in seconds
    private float currentTime; // Current time in seconds

    public TextMeshProUGUI timerText; // Reference to the Text component

    private bool isTimerRunning = false;

    private void Start()
    {
        timerText.text = FormatTime(totalTime);
        StartTimer();
    }

    private void Update()
    {
        if (isTimerRunning)
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0)
            {
                // Timer has reached zero
                TimerComplete();
            }

            timerText.text = FormatTime(currentTime);
        }
    }

    public void StartTimer()
    {
        currentTime = totalTime;
        isTimerRunning = true;
    }

    public void StopTimer()
    {
        isTimerRunning = false;
    }

    private void TimerComplete()
    {
        Debug.Log("Timer Complete!");
        isTimerRunning = false;
        // Perform any desired actions when the timer completes
    }

    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
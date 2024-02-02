using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float totalTimeSeconds = 0f;

    float elapsedTimeSeconds = 0f;
    bool running = false;

    bool started = false;

    public float Duration
    {
        set
        {
            if (!running)
            {
                totalTimeSeconds = value;
            }
        }
    }

    public bool Finished
    {
        get { return started && !running; }
    }

    void Update()
    {
        if (running)
        {
            elapsedTimeSeconds += Time.deltaTime;
            if (elapsedTimeSeconds >= totalTimeSeconds)
            {
                running = false;
            }
        }
    }

    public void Run()
    {
        if (totalTimeSeconds > 0)
        {
            started = true;
            running = true;
            elapsedTimeSeconds = 0f;
        }
    }
}

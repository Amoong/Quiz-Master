using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;

    float timerValue;
    public bool isAnsweringQuestion = false;

    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;
        Debug.Log(timerValue);

        if (timerValue > 0)
        {
            return;
        }

        if (isAnsweringQuestion)
        {
            timerValue = timeToShowCorrectAnswer;
        }
        else
        {
            timerValue = timeToCompleteQuestion;
        }

        isAnsweringQuestion = !isAnsweringQuestion;

    }
}

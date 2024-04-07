using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionSO question;
    [SerializeField] GameObject[] answerButtons;

    void Start()
    {
        questionText.text = question.GetQuestion();


        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonsText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonsText.text = question.GetAnswer(i);
        }

    }
}

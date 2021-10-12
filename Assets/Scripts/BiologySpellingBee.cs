using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BiologySpellingBee : MonoBehaviour
{
    public Text evaluationText;
    public InputField inputField;
    private int questionArrayNumber = 0;
    void Start()
    {
        PlayQuestion();
    }

    public void PlayQuestion()
    {
        GameObject soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();

        soundManagerScript.playQuestionSound(Biology_2_1_QuestionBank.questions[questionArrayNumber].questionAudio);
    }

    public void CheckButton()
    {
        if (inputField.text == Biology_2_1_QuestionBank.questions[questionArrayNumber].answer)
        {
            evaluationText.text = "correct";
        }
        else
        {
            evaluationText.text = "incorrect";
        }
    }

    public void NextButton()
    {
        inputField.text = "";
        questionArrayNumber++;
        PlayQuestion();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BiologySpellingBee : MonoBehaviour
{
    public Text evaluationText;
    public InputField inputField;
    private int questionArrayNumber = 0;
    public Canvas questionCanvas, answerCanvas;
    public GameObject char1;
    void Start()
    {
        PlayQuestion();
    }

    public void PlayQuestion()
    {
        questionCanvas.GetComponent<CanvasGroup>().alpha = 1.0f;


        GameObject soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();
        soundManagerScript.playQuestionSound(Biology_2_1_QuestionBank.questions[questionArrayNumber].questionAudio);

        StartCoroutine(ChangeStageCoroutine());
    }

    IEnumerator ChangeStageCoroutine()
    {
        yield return new WaitForSeconds(2);

        questionCanvas.GetComponent<CanvasGroup>().alpha = 0.0f;
        answerCanvas.GetComponent<CanvasGroup>().alpha = 1.0f;
        char1.GetComponent<Renderer>().enabled = true;
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

        answerCanvas.GetComponent<CanvasGroup>().alpha = 0.0f;
        char1.GetComponent<Renderer>().enabled = false;
    }
}

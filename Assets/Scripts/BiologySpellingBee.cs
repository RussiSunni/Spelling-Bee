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
    public GameObject beeGirlChar, fortuneTellerChar;
    public BeeGirlChar beeGirlChar;
    void Start()
    {
        PlayQuestion();
    }

    public void PlayQuestion()
    {
        questionCanvas.GetComponent<CanvasGroup>().blocksRaycasts = true;
        questionCanvas.GetComponent<CanvasGroup>().alpha = 1.0f;

        // play question audio
        GameObject soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();
        soundManagerScript.playQuestionSound(Biology_2_1_QuestionBank.questions[questionArrayNumber].questionAudio);

        // change to answer view
        StartCoroutine(ChangeStageCoroutine());

        GameObject beeGirlChar = GameObject.Find("BeeGirlChar");
    }

    IEnumerator ChangeStageCoroutine()
    {
        // change to answer view
        yield return new WaitForSeconds(2);

        questionCanvas.GetComponent<CanvasGroup>().alpha = 0.0f;
        questionCanvas.GetComponent<CanvasGroup>().blocksRaycasts = false;
        answerCanvas.GetComponent<CanvasGroup>().alpha = 1.0f;
        fortuneTellerChar.SetActive(false);
        beeGirlChar.GetComponent<Renderer>().enabled = true;
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

        Next();
    }

    public void Next()
    {
        // clear input field
        inputField.text = "";

        // change to next question
        questionArrayNumber++;
        PlayQuestion();

        // change to question view
        answerCanvas.GetComponent<CanvasGroup>().alpha = 0.0f;
        fortuneTellerChar.SetActive(true);
        beeGirlChar.GetComponent<Renderer>().enabled = false;
    }

    public void RepeatButton()
    {
        // play question audio
        GameObject soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();
        soundManagerScript.playQuestionSound(Biology_2_1_QuestionBank.questions[questionArrayNumber].questionAudio);
    }
}

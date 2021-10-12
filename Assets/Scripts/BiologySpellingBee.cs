using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BiologySpellingBee : MonoBehaviour
{
    public Text evaluationText;
    public InputField inputField;
    void Start()
    {
        GameObject soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();


        soundManagerScript.playQuestionSound(BiologyQuestionBank.questions[0].questionAudio);
    }

    public void CheckButton()
    {
        if (inputField.text == "atom")
        {
            evaluationText.text = "correct";
        }
        else
        {
            evaluationText.text = "incorrect";
        }
    }
}

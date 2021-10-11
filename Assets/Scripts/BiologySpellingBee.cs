using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiologySpellingBee : MonoBehaviour
{
    void Start()
    {
        GameObject soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();
        soundManagerScript.playQuestionSound(BiologyQuestionBank.questions[0].questionAudio);
    }
}

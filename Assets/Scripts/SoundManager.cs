using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSrc;
    public AudioClip questionAudio;


    void Start()
    {
        questionAudio = Resources.Load<AudioClip>("Audio/atom");
        //  audioSrc.PlayOneShot(questionAudio);
    }


    public void playQuestionSound(string questionText)
    {
        Debug.Log(questionText);
        questionAudio = Resources.Load<AudioClip>("Audio/" + questionText);
        audioSrc.PlayOneShot(questionAudio);
    }
}

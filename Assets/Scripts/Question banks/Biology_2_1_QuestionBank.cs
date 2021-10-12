using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MOLECULAR BASIS OF LIFE
public class Biology_2_1_QuestionBank : MonoBehaviour
{
    public static List<Question> questions = new List<Question>();
    public static Question biology001;
    public static Question biology002;

    public string test = "atom";

    void Start()
    {
        biology001 = new Question()
        {
            number = 1,
            questionAudio = "atom",
            answer = "atom",
            answered = false,
            level = 1
        };

        biology002 = new Question()
        {
            number = 2,
            questionAudio = "neutron",
            answer = "neutron",
            answered = false,
            level = 1
        };

        LoadQuestionList();
    }

    public static void LoadQuestionList()
    {
        questions.Add(biology001);
        questions.Add(biology002);

        // questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();

        // Debug.Log(questions.Count);
    }
}

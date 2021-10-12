using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MOLECULAR BASIS OF LIFE
public class Biology_2_1_QuestionBank : MonoBehaviour
{
    public static List<Question> questions = new List<Question>();
    public static Question Biology_2_1_001, Biology_2_1_002, Biology_2_1_003, Biology_2_1_004, Biology_2_1_005, Biology_2_1_006, Biology_2_1_007, Biology_2_1_008, Biology_2_1_009, Biology_2_1_010, Biology_2_1_011, Biology_2_1_012;

    public string test = "atom";

    void Start()
    {
        Biology_2_1_001 = new Question()
        {
            number = 1,
            questionAudio = "atom",
            answer = "atom",
            answered = false,
            level = 1
        };

        Biology_2_1_002 = new Question()
        {
            number = 2,
            questionAudio = "atomic mass",
            answer = "atomic mass",
            answered = false,
            level = 1
        };

        Biology_2_1_003 = new Question()
        {
            number = 3,
            questionAudio = "atomic number",
            answer = "atomic number",
            answered = false,
            level = 1
        };

        Biology_2_1_004 = new Question()
        {
            number = 4,
            questionAudio = "compound",
            answer = "compound",
            answered = false,
            level = 1
        };

        Biology_2_1_005 = new Question()
        {
            number = 5,
            questionAudio = "diatomic",
            answer = "diatomic",
            answered = false,
            level = 1
        };

        Biology_2_1_006 = new Question()
        {
            number = 6,
            questionAudio = "electron",
            answer = "electron",
            answered = false,
            level = 1
        };

        Biology_2_1_007 = new Question()
        {
            number = 7,
            questionAudio = "matter",
            answer = "matter",
            answered = false,
            level = 1
        };

        Biology_2_1_008 = new Question()
        {
            number = 8,
            questionAudio = "mixture",
            answer = "mixture",
            answered = false,
            level = 1
        };

        Biology_2_1_009 = new Question()
        {
            number = 9,
            questionAudio = "molecule",
            answer = "molecule",
            answered = false,
            level = 1
        };

        Biology_2_1_010 = new Question()
        {
            number = 10,
            questionAudio = "neutron",
            answer = "neutron",
            answered = false,
            level = 1
        };

        Biology_2_1_011 = new Question()
        {
            number = 11,
            questionAudio = "nucleus",
            answer = "nucleus",
            answered = false,
            level = 1
        };

        Biology_2_1_012 = new Question()
        {
            number = 12,
            questionAudio = "proton",
            answer = "proton",
            answered = false,
            level = 1
        };

        LoadQuestionList();
    }

    public static void LoadQuestionList()
    {
        questions.Add(Biology_2_1_001);
        questions.Add(Biology_2_1_002);
        questions.Add(Biology_2_1_003);
        questions.Add(Biology_2_1_004);
        questions.Add(Biology_2_1_005);
        questions.Add(Biology_2_1_006);
        questions.Add(Biology_2_1_007);
        questions.Add(Biology_2_1_008);
        questions.Add(Biology_2_1_009);
        questions.Add(Biology_2_1_010);
        questions.Add(Biology_2_1_011);
        questions.Add(Biology_2_1_012);

        // questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();

        // Debug.Log(questions.Count);
    }
}

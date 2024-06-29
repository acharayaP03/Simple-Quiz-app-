
using System;


namespace SimpleQuizApp
{
    internal class Question
    {
        public string QuestionText { get; set; }

        public string[] Answers { get; set; }

        public int CorrectAnswer { get; set; }


        public Question(string questionText, string[] answers, int correctAnswer)
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }


        public bool isCorrectAnswer(int answer)
        {
            return CorrectAnswer == answer;
        }

    }
}
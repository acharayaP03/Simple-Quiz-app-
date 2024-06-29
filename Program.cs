using System;

namespace SimpleQuizApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Question[] question = new Question[]
            {
                new Question(
                    "What is the capitol of France?", 
                    new string[] { "Paris", "London", "Berlin", "Madrid" }, 
                    0
                ),
                new Question(
                    "What is the capitol of Australia?", 
                    new string[] { "Melnourn", "Perth", "Darwin", "Sydney" }, 
                    3
                ),
                new Question(
                    "Which fruit is called king of all fruits?", 
                    new string[] { "Banana", "Water melon", "Mango", "Apple" }, 
                    2
                ),
            };  

            Quiz simpleQuiz = new Quiz(question);

            simpleQuiz.StartQuiz();
        }
    }
}
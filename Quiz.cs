
using System;

namespace SimpleQuizApp
{
    internal class Quiz
    {
        private Question[] questions;

        private int score;
    
        public Quiz(Question[] questions)
        {
            this.questions = questions;
            score = 0;
        }

        public void StartQuiz() 
        {
            Console.WriteLine("Welcome to the Simple Quiz App!");
            int questionNumber = 1;

            foreach (Question question in questions)
            {
                Console.WriteLine($"Question {questionNumber}");
                DisplayQuestion(question);
                int userChoice = GetUserAnswer();

                if(question.isCorrectAnswer(userChoice))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!");
                    score++;
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Incorrect! The correct answer is: {question.Answers[question.CorrectAnswer]}");
                    Console.ResetColor();
                }
            }
            DisplayResult();
        }

        private void DisplayQuestion(Question questions)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Question                                ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(questions.QuestionText);
            for (int i = 0; i < questions.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("   ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine($". {questions.Answers[i]}");
            }
        }

        private void DisplayResult()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Results                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine($"You got {score} out of {questions.Length} questions correct.");

            double percentage = (double)score / questions.Length;
            if(percentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations! You are a quiz master!");
            }
            else if(percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Not bad! You did well.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You need to brush up on your general knowledge.");
            }
        }

        private int GetUserAnswer() 
        {
            Console.Write("Your answer: ");
            string answer = Console.ReadLine();
            int choice = 0;
            
            while(!int.TryParse(answer, out choice) || choice < 1 || choice > 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                Console.ResetColor();
                Console.Write("Your answer: ");
                answer = Console.ReadLine();
            }
            return choice - 1 ;
        }
    }
}
using System;
using System.Collections.Generic;

namespace Login
{
    // Base class for a question
    public abstract class Question
    {
        public string QuestionText { get; set; } // The question text
        public string Answer { get; set; } // The correct answer

        // Abstract method to be implemented by subclasses
        public abstract bool CheckAnswer(string answer);
    }

    // Enum to define question types
    public enum QuestionType
    {
        TrueFalse,   // True/False question (e.g., "Is the Earth flat?")
        OpenEnd,     // Open-end question (e.g., "What is your name?")
        MultipleChoice // Multiple Choice Question (e.g., "Which is the largest planet?")
    }

    // True/False question class
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string question, string answer)
        {
            QuestionText = question;
            Answer = answer;
        }

        public override bool CheckAnswer(string answer)
        {
            return string.Equals(Answer, answer, StringComparison.OrdinalIgnoreCase);
        }
    }

    // Open-end question class
    public class OpenEndQuestion : Question
    {
        public OpenEndQuestion(string question, string answer)
        {
            QuestionText = question;
            Answer = answer;
        }

        public override bool CheckAnswer(string answer)
        {
            return string.Equals(Answer, answer, StringComparison.OrdinalIgnoreCase);
        }
    }

    // Multiple choice question class
    public class MultipleChoiceQuestion : Question
    {
        public List<string> Options { get; set; }

        public MultipleChoiceQuestion(string question, List<string> options, string answer)
        {
            QuestionText = question;
            Options = options;
            Answer = answer;
        }

        public override bool CheckAnswer(string answer)
        {
            return string.Equals(Answer, answer, StringComparison.OrdinalIgnoreCase);
        }
    }

    // Question Factory to generate different types of questions
    public static class QuestionFactory
    {
        public static List<Question> GetSampleQuestions()
        {
            return new List<Question>
            {
                // True/False questions
                new TrueFalseQuestion("Is the Earth flat?", "False"),
                new TrueFalseQuestion("Is water essential for human life?", "True"),

                // Open-End questions
                new OpenEndQuestion("Who wrote 'Romeo and Juliet'?", "William Shakespeare"),
                new OpenEndQuestion("What is the chemical symbol for water?", "H2O"),

                // Multiple Choice questions
                new MultipleChoiceQuestion("Which is the largest planet in our solar system?",
                    new List<string> { "Earth", "Mars", "Jupiter", "Saturn" }, "Jupiter"),
                new MultipleChoiceQuestion("Which of these is a prime number?",
                    new List<string> { "4", "6", "11", "15" }, "11"),
                new MultipleChoiceQuestion("What is the boiling point of water in Celsius?",
                    new List<string> { "90°C", "100°C", "110°C", "120°C" }, "100°C")
            };
        }
    }
}

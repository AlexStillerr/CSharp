using System;
using System.Collections.Generic;

namespace Quiz
{

    public enum QuestionType
    {
        MultiSelection,
        SingleSelection
    }

    public class QuizQuestion
    {
        public string question { get; private set; }
        private List<QuizAnswer> originalAnswers { get; set; }
        public List<QuizAnswer> answers { get; private set; }
        public QuestionType QuestionType { get; private set; }
        public int Points { get; private set; }

        public QuizQuestion(string question, List<QuizAnswer> answers)
        {
            this.question = question;
            originalAnswers = answers;
        }

        internal bool CheckAnswer(int answerId)
        {
            return answers[answerId].isCorrect;
        }

        internal string GetAnswerText(int answerId)
        {
            return answers[answerId].text;
        }

        internal void Init()
        {
            Random rnd = new Random();
            originalAnswers.Shuffle(rnd);

            ReduceAnswers(4, rnd);

            if (CountCorrectAnswers(answers) > 1)
            {
                QuestionType = QuestionType.MultiSelection;
                Points = 1;
            }
            else
            {
                QuestionType = QuestionType.SingleSelection;
                Points = 2;
            }
        }

        private void ReduceAnswers(int amount, Random rnd)
        {
            List<QuizAnswer> selection = new(originalAnswers);
            while (selection.Count > amount)
            {
                QuizAnswer removed = selection[rnd.Next(selection.Count)];
                selection.Remove(removed);
                int correctCount = CountCorrectAnswers(selection);
                if (correctCount == 0)
                    selection.Add(removed);
            }
            answers = selection;
        }

        private int CountCorrectAnswers(List<QuizAnswer> list)
        {
            int correctCount = 0;
            foreach (var answer in list)
                if (answer.isCorrect)
                    correctCount++;
            return correctCount;
        }
    }
}

using System;
using System.Collections.Generic;

namespace Quiz
{
    public class QuizCategory
    {
        public string quizTitle { get; set; }
        public List<QuizQuestion> questions { get; set; } = new();

        internal QuizQuestion GetRandomQuest(Random random)
        {
            //do
            //{
            //} while (answeredQuestions.Contains(current));
            int rndQuest = random.Next(questions.Count);
            questions[rndQuest].answers.Shuffle();
            return questions[rndQuest];
        }

        public void InitQuests()
        {
            foreach (var quest in questions)
                quest.Init();
        }
    }
}

//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace Quiz
{
    public class QuizLogic
    {
        private List<QuizCategory> categories = new();
        private QuizCategory currentCategory;
        private QuizQuestion current = null;
        private Random random;

        //private List<QuizItem> answeredQuestions = new();
        public int Points => Math.Max(0, points + lastScore);
        private int points = 0;
        private int lastScore = 0;
        private bool canScore = true;

        internal string GetPossibleAnswer(int v) => current.GetAnswerText(v);
        internal string GetQuestion() => current.question;
        internal string GetCategory() => currentCategory.quizTitle;
        internal bool IsAnswerCorrect(int answer) => current.CheckAnswer(answer);
        internal bool IsQuestionAvailable() => canScore;
        internal QuestionType GetCurrentQuestType() => current.QuestionType;
        internal int Score() => lastScore;

        public QuizLogic()
        {
            random = new Random();
        }

        public void InitializeQuestions()
        {
            /*
            Temp();
            /*/
            LoadFiles();
            //*/

            //SelectCategory();
            NextQuestion();
        }

        private void LoadFiles()
        {
            string path = $"{Directory.GetCurrentDirectory()}\\..\\..\\Questions";
            Console.WriteLine(path);

            string[] files = Directory.GetFiles(path, "*.json");

            foreach (string file in files)
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string jsonString = sr.ReadToEnd();
                    var cat = JsonSerializer.Deserialize<QuizCategory>(jsonString);
                    cat.InitQuests();
                    categories.Add(cat);
                }
            }
        }

        private void Temp()
        {
            currentCategory = new();
            currentCategory.quizTitle = "Test Category";

            currentCategory.questions.Add(new QuizQuestion("Was für ein Test?", 
                new List<QuizAnswer>() {new QuizAnswer("ein guter", true), new QuizAnswer("ein schlechter", false), new QuizAnswer("ein super", true), new QuizAnswer("ein kurzer", true), new QuizAnswer("Banane?", false) }));
            currentCategory.questions.Add(new QuizQuestion("Reihenfolge?",
                new List<QuizAnswer>() { new QuizAnswer("1", true), new QuizAnswer("2", false), new QuizAnswer("3", false), new QuizAnswer("4", false), new QuizAnswer("5", true) }));

            currentCategory.InitQuests();
            categories.Add(currentCategory);
        }

        public void NextQuestion()
        {
            // Todo: better errorhandling
            //if (answeredQuestions.Count == quizItems.Count)
            //  return;
            SelectCategory();
            current = currentCategory.GetRandomQuest(random);

            points = Points;
            lastScore = 0;
            canScore = true;
        }

        private void SelectCategory()
        {
            currentCategory = categories[random.Next(categories.Count)];
            
        }


        internal void AnswerQuestion(int answer)
        {
            canScore = false;
            //answeredQuestions.Add(current);

            if (IsAnswerCorrect(answer))
                lastScore += current.Points;
            else
                lastScore -= current.Points;
        }
    }
}

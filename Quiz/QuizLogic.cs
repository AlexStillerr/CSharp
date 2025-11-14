//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace Quiz
{
    class QuizCategory
    {
        public string quizTitle {  get; set; }
        public List<QuizQuestion> questions { get; set; } = new();

        internal QuizQuestion GetRandomQuest(Random random)
        {
            //do
            //{
            //} while (answeredQuestions.Contains(current));
            return questions[random.Next(questions.Count)];
        }

        public void InitQuests()
        {
            foreach (var quest in questions)
                quest.Init();
        }
    }

    class QuizAnswer
    {
        public string text { get; set; }
        public bool isCorrect { get; set; }

        public QuizAnswer(string answer, bool isCorrect)
        {
            this.text = answer;
            this.isCorrect = isCorrect;
        }
    }

    class QuizQuestion
    {
        public string question { get; private set; }
        public List<QuizAnswer> answers { get; private set; }
        public QuestionType QuestionType { get; private set; }

        public QuizQuestion(string question, List<QuizAnswer> answers)
        {
            this.question = question;
            this.answers = answers;
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
            //answers.Shuffle()
            int correctCount = 0;
            foreach (var answer in answers)
                if(answer.isCorrect)
                    correctCount++;

            if( correctCount > 1)
                QuestionType = QuestionType.MultiSelection;
            else
                QuestionType = QuestionType.SingleSelection;
        }
    }

    public enum QuestionType
    {
        MultiSelection,
        SingleSelection
    }

    internal class QuizLogic
    {
        private string path = "D:\\AlexWeiterBildung\\C#\\Quiz\\quiz.txt";
        private string path2 = "D:\\AlexWeiterBildung\\C#\\Quiz\\Questions\\DesignPatterns.json";

        private QuizCategory currentCategory;
        private QuizQuestion current = null;
        private Random random;

        //private List<QuizItem> answeredQuestions = new();
        private int points = 0;
        private bool canScore = true;

        public QuizLogic()
        {
            random = new Random(7);
        }

        public void InitializeQuestions()
        {
            Temp();
            //LoadFiles();

            NextQuestion();
            //int zufall = (int)(Math.random() * Max); ??
        }

        private void LoadFiles()
        {

            //string[] lines = File.ReadAllLines(path);
            //foreach (string line in lines)
            //    Console.WriteLine(line);

            //var ser = JsonSerializer.Serialize();
            // string jsonString = ser.Serialize

            using (StreamReader sr = new StreamReader(path2))
            {
                string jsonString = sr.ReadToEnd();
                var dings = JsonSerializer.Deserialize<QuizCategory>(jsonString);
                Console.WriteLine(dings);
                currentCategory = dings;
            }
        }

        public void NextQuestion()
        {
            // Todo: better errorhandling
            //if (answeredQuestions.Count == quizItems.Count)
            //  return;

            current = currentCategory.GetRandomQuest(random);

            canScore = true;
        }

        private void Temp()
        {
            currentCategory = new();
            currentCategory.quizTitle = "Test Category";

            currentCategory.questions.Add(new QuizQuestion("Was für ein Test?", 
                new List<QuizAnswer>() {new QuizAnswer("ein guter", true), new QuizAnswer("ein schlechter", false), new QuizAnswer("ein kurzer", true), new QuizAnswer("Banane?", false) }));
            currentCategory.questions.Add(new QuizQuestion("Reihenfolge?",
                new List<QuizAnswer>() { new QuizAnswer("1", true), new QuizAnswer("2", false), new QuizAnswer("3", false), new QuizAnswer("4", false) }));

            currentCategory.InitQuests();
        }

        internal string GetPossibleAnswer(int v) => current.GetAnswerText(v);
        internal string GetQuestion() => current.question;
        internal string GetCategory() => currentCategory.quizTitle;
        internal bool IsAnswerCorrect(int answer) => current.CheckAnswer(answer);
        internal bool IsQuestionAvailable() => canScore;
        internal QuestionType GetCurrentQuestType() => current.QuestionType;

        internal void AnswerQuestion(int answer)
        {
            canScore = false;
            //answeredQuestions.Add(current);
            if (IsAnswerCorrect(answer))
                points++;
        }

    }
}

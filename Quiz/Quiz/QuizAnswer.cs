namespace Quiz
{
    public class QuizAnswer
    {
        public string text { get; set; }
        public bool isCorrect { get; set; }

        public QuizAnswer(string text, bool isCorrect)
        {
            this.text = text;
            this.isCorrect = isCorrect;
        }
    }
}

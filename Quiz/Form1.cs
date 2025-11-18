using System;
using System.Drawing;
using System.Windows.Forms;

namespace Quiz
{
    /*
     TODO:
    - Category selection?
    - Timer?
    - beantwortete Fragen speichern -> keine doppelten Fragen
        - Prozentanzahl wieviel schon beantwortet in der Category
    - Save Load
    + Random selection der Antworten möglichkeiten
    + Antworten shuffeln
    + Show answer result
    + switch zwischen Multiselection und Single selection
    + Punkte
    + Categoryname anzeige
    + nur einmal auf Antworten clicken
    + Start Logic/Screen
     */

    public partial class Form1 : Form
    {
        private QuizLogic quizLogic = new();

        private Color defaultColor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            quizLogic.InitializeQuestions();

            defaultColor = MultiSelectionBox1.BackColor;

            ShowQuest();
        }

        private void ShowQuest()
        {
            CategoryLabel.Text = quizLogic.GetCategory();
            QuestionLabel.Text = quizLogic.GetQuestion();

            switch(quizLogic.GetCurrentQuestType())
            {
                case QuestionType.MultiSelection:
                    ShowMultiselection();
                    break;
                case QuestionType.SingleSelection:
                    ShowSingleSelection();
                    break;
            }
            ShowScorePoints();
        }

        private void ShowSingleSelection()
        {
            HideAll();

            SingleSelection.Show();
            SingleSelection.Enabled = true;

            Setup(0, SingleSelectionRadio1);
            Setup(1, SingleSelectionRadio2);
            Setup(2, SingleSelectionRadio3);
            Setup(3, SingleSelectionRadio4);

            void Setup(int answerId, RadioButton radio)
            {
                radio.Checked = false;
                radio.BackColor = defaultColor;
                radio.Text = quizLogic.GetPossibleAnswer(answerId);
            }
        }

        private void ShowMultiselection()
        {
            HideAll();

            MultiSelection.Show();
            MultiSelection.Enabled = true;

            Setup(0, MultiSelectionBox1);
            Setup(1, MultiSelectionBox2);
            Setup(2, MultiSelectionBox3);
            Setup(3, MultiSelectionBox4);


            void Setup(int answerId, CheckBox box)
            {
                box.Checked = false;
                box.BackColor = defaultColor;
                box.Text = quizLogic.GetPossibleAnswer(answerId);
            }
        }

        private void HideAll()
        {
            MultiSelection.Hide();
            MultiSelection.Enabled = false;
            SingleSelection.Hide();
            SingleSelection.Enabled = false;
        }

        private void AnswerBtn_Click(object sender, EventArgs e)
        {
            if (quizLogic.IsQuestionAvailable() == false)
                return;

            switch(quizLogic.GetCurrentQuestType())
            {
                case QuestionType.MultiSelection:
                    HandleAnswer(0, MultiSelectionBox1.Checked, MultiSelectionBox1);
                    HandleAnswer(1, MultiSelectionBox2.Checked, MultiSelectionBox2);
                    HandleAnswer(2, MultiSelectionBox3.Checked, MultiSelectionBox3);
                    HandleAnswer(3, MultiSelectionBox4.Checked, MultiSelectionBox4);
                    break;
                case QuestionType.SingleSelection:
                    HandleAnswer(0, SingleSelectionRadio1.Checked, SingleSelectionRadio1);
                    HandleAnswer(1, SingleSelectionRadio2.Checked, SingleSelectionRadio2);
                    HandleAnswer(2, SingleSelectionRadio3.Checked, SingleSelectionRadio3);
                    HandleAnswer(3, SingleSelectionRadio4.Checked, SingleSelectionRadio4);
                    break;
            }
            ShowScorePoints();


            void HandleAnswer(int answer, bool isChecked, ButtonBase box)
            {
                if (quizLogic.IsAnswerCorrect(answer))
                {
                    if (isChecked)
                    {
                        box.BackColor = Color.Green;
                        quizLogic.AnswerQuestion(answer);
                    }
                    else
                        box.BackColor = Color.Red;
                }
                else if (isChecked)
                {
                    box.BackColor = Color.Red;
                    quizLogic.AnswerQuestion(answer);
                }
            }
        }

        private void ShowScorePoints()
        {
            int diff = quizLogic.Score();
            pointsDiffLbl.Text = $"{diff:+0;-0}";
            if (diff > 0)
                pointsDiffLbl.ForeColor = Color.Green;
            else if (diff < 0)
                pointsDiffLbl.ForeColor = Color.Red;
            else
                pointsDiffLbl.Text = "";

            pointsLbl.Text = quizLogic.Points.ToString();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            quizLogic.NextQuestion();
            ShowQuest();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartScreen.Hide();
        }
    }
}

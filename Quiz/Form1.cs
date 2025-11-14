using System;
using System.Drawing;
using System.Windows.Forms;

namespace Quiz
{
    /*
     TODO:
    - Category selection?
    - Antworten shuffeln
    + Show answer result
    - Random selection der Antworten möglichkeiten
    + switch zwischen Multiselection und Single selection
    - Punkte
    - beantwortete Fragen speichern -> keine doppelten Fragen
        - Prozentanzahl wieviel schon beantwortet in der Category
    + Categoryname anzeige
    - Timer?
    - Start Logic/Screen
    - Save Load
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

        private bool CheckAnswer(int answer)
        {
            if (quizLogic.IsQuestionAvailable())
            {
                return quizLogic.IsAnswerCorrect(answer);


                //quizLogic.AnswerQuestion(answer);
            }
            return false;
        }

        private void AnswerBtn_Click(object sender, EventArgs e)
        {
            switch(quizLogic.GetCurrentQuestType())
            {
                case QuestionType.MultiSelection:
                    UpdateButton(0, MultiSelectionBox1.Checked, MultiSelectionBox1);
                    UpdateButton(1, MultiSelectionBox2.Checked, MultiSelectionBox2);
                    UpdateButton(2, MultiSelectionBox3.Checked, MultiSelectionBox3);
                    UpdateButton(3, MultiSelectionBox4.Checked, MultiSelectionBox4);
                    break;
                case QuestionType.SingleSelection:
                    UpdateButton(0, SingleSelectionRadio1.Checked, SingleSelectionRadio1);
                    UpdateButton(1, SingleSelectionRadio2.Checked, SingleSelectionRadio2);
                    UpdateButton(2, SingleSelectionRadio3.Checked, SingleSelectionRadio3);
                    UpdateButton(3, SingleSelectionRadio4.Checked, SingleSelectionRadio4);
                    break;
            }


            void UpdateButton(int number, bool isChecked, ButtonBase box)
            {
                if (CheckAnswer(number))
                    if (isChecked)
                        box.BackColor = Color.Green;
                    else
                        box.BackColor = Color.Red;
                else if (isChecked)
                    box.BackColor = Color.Red;
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            quizLogic.NextQuestion();
            ShowQuest();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Examination
{
    public partial class Testing : Form
    {
        List<Questions> questions;
        int count = 0; // лічильник питань
        public Testing()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = "";
        }

        //Конструктор для питань
        public Testing(List<Questions> questions)
        {
            InitializeComponent();
            this.questions = questions;
            toolStripStatusLabel2.Text = "";

            NextQuestion();
        }

        private void Bt_Next_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                if (((Answer)item).check)
                    questions[count - 1].check = true;
                else
                    questions[count - 1].check = false;
            }

            if (count == questions.Count)
            {
                LbQuestion.Text = "You answered the last question";
                checkedListBox1.Visible = false;
                BtFinish.Visible = true;
                BtnNext.Visible = false;
            }

            NextQuestion();
        }

        //Метод переходу на наступне питання
        private void NextQuestion()
        {
            while (count <= questions.Count - 1)
            {
                checkedListBox1.Items.Clear();
                toolStripStatusLabel2.Text = $"You answered {count + 1} questions out of {questions.Count}";
                LbQuestion.Text = questions[count].Question;
                //Додавання вибраної відповіді в checkedListBox1
                for (int i = 0; i < questions[count].answers.Count; i++)
                    checkedListBox1.Items.Add(questions[count].answers[i]);
                count++;
                break;
            }
        }

         //Закі
        private void Finish_Click(object sender, EventArgs e)
        {
            int score = 0;
            int percentage = 0;
            foreach (var item in questions)
                if (item.check)
                {
                    score++; //підрахунок правильних відповідей
                    percentage = (int)Math.Round((double)(score * 100) / questions.Count); ////підрахунок правильних відповідей у %

                }
            checkedListBox1.Visible = false;
          
            BtFinish.Visible = false;
            toolStripStatusLabel2.Text = "";
            LbQuestion.Size = new System.Drawing.Size(299, 136);
            
            if (score < questions.Count)
            {
                LbQuestion.ForeColor = System.Drawing.Color.Green;
                LbQuestion.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 12);
                LbQuestion.Text = "Quiz Ended." + Environment.NewLine +
                              "You have answered " + score +
                              " question correctly." + Environment.NewLine +
                              "Your total percenage is " + percentage + "%";
            }
            else
            {
               LbQuestion.Font = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 12);
               LbQuestion.ForeColor = System.Drawing.Color.Red;
               LbQuestion.Text = "Quiz Ended" + Environment.NewLine +
                            "YOU ARE THE BEST." + Environment.NewLine +
                            "Your total percenage is " + percentage + "%";

            }

            DialogResult dialog = MessageBox.Show("Click OK to play again", "Game", MessageBoxButtons.YesNo);
            switch (dialog)
            {
                case DialogResult.Yes:   // cw  tab tab
                    score = 0;
                    count = 0;
                    checkedListBox1.Visible = true;
                    LbQuestion.Size = new System.Drawing.Size(418, 38);
                    LbQuestion.ForeColor = System.Drawing.Color.Blue;
                    NextQuestion();
                    BtnNext.Visible = true;
                    break;
                case DialogResult.No:
                    this.Close();
                    break;
            }

            
            

                                  
        }
    }
}

using Login;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace login
{
    public partial class open_end : Form
    {
        // Event to send the question and answer to the creator form
        public event Action<Question> OnQuestionAdded;

        public open_end()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string questionText = rt_question.Text.Trim();
            string answerText = rt_answer.Text.Trim();

            // Validate if both question and answer are entered
            if (string.IsNullOrEmpty(questionText) || string.IsNullOrEmpty(answerText))
            {
                MessageBox.Show("Please enter both question and answer.");
                return;
            }

            // Create a new question object
            Question newQuestion = new OpenEndQuestion(questionText, answerText);

            // Trigger the event if it's subscribed
            OnQuestionAdded?.Invoke(newQuestion);

            // Show success message and close the form
            MessageBox.Show("Question added successfully!");
            this.Close();
        }
    }

}

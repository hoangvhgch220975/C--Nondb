using Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class true_false : Form
    {
        public event Action<Question> OnQuestionAdded;

        public true_false()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string questionText = rt_question.Text.Trim();  // Get the question text from RichTextBox
            string answerText = "";

            // Check if a true/false answer is selected
            if (rbtn_true.Checked)
            {
                answerText = "True";  // If true is selected
            }
            else if (rbtn_false.Checked)
            {
                answerText = "False";  // If false is selected
            }

            // Validate if both the question and an answer are provided
            if (string.IsNullOrEmpty(questionText) || string.IsNullOrEmpty(answerText))
            {
                MessageBox.Show("Please enter both the question and the answer (True/False).");
                return;
            }

            // Create a new True/False question
            Question newQuestion = new TrueFalseQuestion(questionText, answerText);

            // Trigger the event to send the question to the creator form
            OnQuestionAdded?.Invoke(newQuestion);

            // Show success message and close the form
            MessageBox.Show("True/False question added successfully!");
            this.Close();
        }
    }
}

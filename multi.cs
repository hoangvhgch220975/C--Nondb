using Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class multi : Form
    {
        public event Action<Question> OnQuestionAdded;

        public multi()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Get the question text
            string questionText = rt_question.Text.Trim();

            // Get the options from the form (assuming you have TextBoxes or other controls for the options)
            List<string> options = new List<string>();
            if (!string.IsNullOrEmpty(txt_opt1.Text)) options.Add(txt_opt1.Text.Trim());
            if (!string.IsNullOrEmpty(txt_opt2.Text)) options.Add(txt_opt2.Text.Trim());
            if (!string.IsNullOrEmpty(txt_opt3.Text)) options.Add(txt_opt3.Text.Trim());
            if (!string.IsNullOrEmpty(txt_opt4.Text)) options.Add(txt_opt4.Text.Trim());

            // Get the correct answer from the radio buttons
            string correctAnswer = "";
            if (chk1.Checked) correctAnswer = txt_opt1.Text.Trim();
            else if (chk2.Checked) correctAnswer = txt_opt2.Text.Trim();
            else if (chk3.Checked) correctAnswer = txt_opt3.Text.Trim();
            else if (chk4.Checked) correctAnswer = txt_opt4.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(questionText) || options.Count == 0 || string.IsNullOrEmpty(correctAnswer))
            {
                MessageBox.Show("Please enter a question, options, and select a correct answer.");
                return;
            }

            // Create a new multiple-choice question
            Question newQuestion = new MultipleChoiceQuestion(questionText, options, correctAnswer);

            // Trigger the event to pass the new question to the creator form
            OnQuestionAdded?.Invoke(newQuestion);

            // Show a success message and close the form
            MessageBox.Show("Multiple choice question added successfully!");
            this.Close();
        }
    }
}

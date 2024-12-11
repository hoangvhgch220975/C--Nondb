using Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace login
{
    public partial class creator : Form
    {
        public List<Question> QuestionBank { get; set; } // List of questions

        public creator(List<Question> questionBank)
        {
            InitializeComponent();
            QuestionBank = questionBank; // Pass the existing question bank from Login form

        }

        private void creator_Load(object sender, EventArgs e)
        {
            // Check if the question bank is empty; if so, add sample questions
            if (QuestionBank.Count == 0)
            {
                QuestionBank.AddRange(QuestionFactory.GetSampleQuestions());
            }
        }

        // Display all questions in the question bank
        private void bt_display_all_Click(object sender, EventArgs e)
        {
            rt_all_question.Clear(); // Clear the RichTextBox

            if (QuestionBank.Count == 0)
            {
                rt_all_question.Text = "No questions in the bank."; // Show message if the bank is empty
                return;
            }

            // Efficient string concatenation
            StringBuilder sb = new StringBuilder();
            foreach (Question question in QuestionBank)
            {
                sb.AppendLine(question.QuestionText);  // Add question
                sb.AppendLine(question.Answer);        // Add answer
                sb.AppendLine(); // Add an empty line for spacing between questions
            }

            rt_all_question.Text = sb.ToString(); // Update the RichTextBox with the concatenated string
        }

        // Add a new question based on selected type (multi, open-end, true/false)
        private void bt_add_question_Click(object sender, EventArgs e)
        {
            if (rbtn_multi.Checked)
            {
                // Open the multiple choice question creation form
                multi form_create = new multi();
                form_create.OnQuestionAdded += AddNewQuestionToBank;  // Register the event handler
                form_create.Show();
            }

            if (rbtn_openend.Checked)
            {
                // Open the open-ended question creation form
                open_end form_create = new open_end();
                form_create.OnQuestionAdded += AddNewQuestionToBank;  // Register the event handler
                form_create.Show();
            }

            if (rbtn_tf.Checked)
            {
                //Open the true / false question creation form
                true_false form_create = new true_false();
                form_create.OnQuestionAdded += AddNewQuestionToBank;  // Register the event handler
                form_create.Show();
            }
        }

        // Delete a question from the bank
        private void bt_delete_Click(object sender, EventArgs e)
        {
            // Get the question text from the RichTextBox to delete
            string questionToDelete = rt_question.Text.Trim();

            if (string.IsNullOrEmpty(questionToDelete))
            {
                MessageBox.Show("Please enter a question to delete.");
                return;
            }

            // Find the question in the question_bank
            Question questionToRemove = QuestionBank.FirstOrDefault(q => q.QuestionText.Equals(questionToDelete, StringComparison.OrdinalIgnoreCase));

            if (questionToRemove != null)
            {
                // If found, remove the question from the bank
                QuestionBank.Remove(questionToRemove);

                // Update the displayed list of questions
                UpdateQuestions();
                MessageBox.Show("Question deleted successfully!");
                rt_question.Text = string.Empty;
            }
            else
            {
                // If not found, show a message
                MessageBox.Show("Question not found!");
            }
        }

        // Edit an existing question
        private void bt_edit_Click(object sender, EventArgs e)
        {
            // Pass the current question bank to the edit form
            edit form_create = new edit(QuestionBank);
            form_create.Show();
        }

        // Event handler to add new questions to the bank
        private void AddNewQuestionToBank(Question newQuestion)
        {

            // Add the new question to the question bank
            QuestionBank.Add(newQuestion);

            // Event triggered when a new question is added
            MessageBox.Show("New question added: " + newQuestion.QuestionText);

            
            // Update the displayed list of questions
            UpdateQuestions();
        }

        // Update the displayed list of questions in the RichTextBox
        private void UpdateQuestions()
        {
            rt_all_question.Clear(); // Clear the RichTextBox

            StringBuilder sb = new StringBuilder();
            foreach (Question question in QuestionBank)
            {
                sb.AppendLine(question.QuestionText);  // Add question followed by a newline
                sb.AppendLine(question.Answer);        // Add answer followed by a newline
                sb.AppendLine(); // Add an empty line for spacing between questions
            }

            rt_all_question.Text = sb.ToString(); // Update the RichTextBox with the new list
        }
    }
}

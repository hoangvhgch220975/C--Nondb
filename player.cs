using Login;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace login
{
    public partial class player : Form
    {
        private List<Question> questionBank = new List<Question>();
        private int currentQuestionIndex;
        private Question currentQuestion;
        private int score;
        private Timer timer;
        private DateTime startTime;

        public player(List<Question> question_bank)
        {
            InitializeComponent();
            this.questionBank = question_bank;
            currentQuestionIndex = 0;
            lbl_score.Text = score.ToString();
            lbl_time.Text = "0m 0s";
            hide();
            rt_answer.Visible = false;
            label1.Visible = false;
            label2.Visible = false;

            // Initialize timer
            timer = new Timer();
            timer.Interval = 1000; // Update every second
            timer.Tick += Timer_Tick;
        }

        // Timer tick event to update the time
        private void Timer_Tick(object sender, EventArgs e)
        {
            var elapsedTime = DateTime.Now - startTime;
            int minutes = elapsedTime.Minutes;
            int seconds = elapsedTime.Seconds;

            lbl_time.Text = $"{minutes}m {seconds}s"; // Update the label with minutes and seconds
        }

        private void LoadQuestion()
        {
            ResetInputs();

            if (currentQuestionIndex < questionBank.Count)
            {
                currentQuestion = questionBank[currentQuestionIndex];
                rt_question.Text = currentQuestion.QuestionText;
                hide();

                // Do not reset the startTime here
                if (currentQuestion is OpenEndQuestion)
                {
                    rt_answer.Visible = true;
                    hide();
                }
                else if (currentQuestion is TrueFalseQuestion)
                {
                    rt_answer.Visible = false;
                    rd_opt1.Visible = true;
                    rd_opt3.Visible = true;

                    rd_opt1.Text = "True";
                    rd_opt3.Text = "False";
                }
                else if (currentQuestion is MultipleChoiceQuestion multipleChoiceQuestion)
                {
                    show();
                    rt_answer.Visible = false;

                    rd_opt1.Text = multipleChoiceQuestion.Options[0];
                    rd_opt2.Text = multipleChoiceQuestion.Options[1];
                    rd_opt3.Text = multipleChoiceQuestion.Options[2];
                    rd_opt4.Text = multipleChoiceQuestion.Options[3];
                }
            }
            else
            {
                MessageBox.Show("No more questions!");
                hide();

                timer.Stop();
                var totalTime = DateTime.Now - startTime;

                rt_answer.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                lbl_score.Visible = false;
                MessageBox.Show($"Game Over! Your score is: {score}/{questionBank.Count * 10}.\nTotal Time: {totalTime.Minutes}m {totalTime.Seconds}s.");
                bt_start.Text = "Replay";
                lbl_time.Text = "0m 0s"; // Reset the time label
                score = 0;
            }
        }

        private void ResetInputs()
        {
            // Reset radio buttons and text box
            rd_opt1.Checked = false;
            rd_opt2.Checked = false;
            rd_opt3.Checked = false;
            rd_opt4.Checked = false;
            rt_answer.Text = string.Empty;
        }

        private void show()
        {
            rd_opt1.Visible = true;
            rd_opt2.Visible = true;
            rd_opt3.Visible = true;
            rd_opt4.Visible = true;
        }

        private void hide()
        {
            rd_opt1.Visible = false;
            rd_opt2.Visible = false;
            rd_opt3.Visible = false;
            rd_opt4.Visible = false;
        }

        private bool CheckAnswer()
        {
            bool isCorrect = false;

            if (currentQuestion is OpenEndQuestion openEndQuestion)
            {
                isCorrect = string.Equals(rt_answer.Text.Trim(), currentQuestion.Answer, StringComparison.OrdinalIgnoreCase);
            }
            else if (currentQuestion is TrueFalseQuestion trueFalseQuestion)
            {
                if (rd_opt1.Checked && currentQuestion.Answer == "True") isCorrect = true;
                if (rd_opt3.Checked && currentQuestion.Answer == "False") isCorrect = true;
            }
            else if (currentQuestion is MultipleChoiceQuestion multipleChoiceQuestion)
            {
                if (rd_opt1.Checked && currentQuestion.Answer == rd_opt1.Text) isCorrect = true;
                if (rd_opt2.Checked && currentQuestion.Answer == rd_opt2.Text) isCorrect = true;
                if (rd_opt3.Checked && currentQuestion.Answer == rd_opt3.Text) isCorrect = true;
                if (rd_opt4.Checked && currentQuestion.Answer == rd_opt4.Text) isCorrect = true;
            }

            return isCorrect;
        }

        private void ShowTemporaryMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người chơi đã trả lời câu hỏi hay chưa
            if (currentQuestion is OpenEndQuestion)
            {
                if (string.IsNullOrWhiteSpace(rt_answer.Text))
                {
                    MessageBox.Show("Please enter an answer before proceeding.");
                    return;
                }
            }
            else if (currentQuestion is TrueFalseQuestion || currentQuestion is MultipleChoiceQuestion)
            {
                if (!rd_opt1.Checked && !rd_opt2.Checked && !rd_opt3.Checked && !rd_opt4.Checked)
                {
                    MessageBox.Show("Please select an option before proceeding.");
                    return;
                }
            }

            bool isCorrect = CheckAnswer();
            if (isCorrect)
            {
                score += 10;
                lbl_score.Text = score.ToString();
            }
            string message = isCorrect ? "Correct!" : "Wrong!";
            ShowTemporaryMessage(message);

            currentQuestionIndex++;
            LoadQuestion();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            currentQuestionIndex = 0;
            score = 0;
            lbl_score.Text = score.ToString();
            lbl_time.Text = "0m 0s"; // Reset the time label

            // Start the timer when the game starts
            startTime = DateTime.Now;
            timer.Start();

            LoadQuestion();
            label1.Visible = true;
            label2.Visible = true;
            lbl_score.Visible = true;
            bt_start.Text = "Start";
        }

        private void bt_finish_Click(object sender, EventArgs e)
        {
            Application.Exit();
            timer.Stop();
        }
    }
}

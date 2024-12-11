using Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class edit : Form
    {
        public List<Question> questionBank = new List<Question>(); // List of questions
        private Question selectedQuestion = null; // Câu hỏi được chọn để chỉnh sửa

        public edit(List<Question> questions)
        {
            InitializeComponent();
            questionBank = questions; // Gán danh sách câu hỏi từ form gọi
        }

        private void edit_Load(object sender, EventArgs e)
        {
            // Hiển thị tất cả các câu hỏi trong rt_all_question
            rt_all_question.Clear(); // Xóa nội dung cũ
            if (questionBank.Count == 0)
            {
                rt_all_question.Text = "No questions in the bank."; // Thông báo nếu không có câu hỏi
                return;
            }

            // Hiển thị tất cả các câu hỏi trong question_bank
            StringBuilder sb = new StringBuilder(); // Use StringBuilder for efficient concatenation
            foreach (Question question in questionBank)
            {
                sb.AppendLine($"{question.QuestionText}"); // Add question text
                sb.AppendLine($"{question.Answer}"); // Add answer
                sb.AppendLine(); // Add empty line between questions
            }

            rt_all_question.Text = sb.ToString(); // Update the RichTextBox with the concatenated string
        }

        // Sự kiện khi người dùng chọn một câu hỏi trong rt_all_question
        private void rt_all_question_SelectionChanged(object sender, EventArgs e)
        {
            string selectedText = rt_all_question.SelectedText.Trim(); // Lấy văn bản đã chọn

            if (string.IsNullOrEmpty(selectedText))
                return;

            // Tìm câu hỏi trong danh sách bằng cách kiểm tra câu hỏi đã chọn
            selectedQuestion = questionBank.FirstOrDefault(q => q.QuestionText.Contains(selectedText));

            if (selectedQuestion != null)
            {
                // Hiển thị câu hỏi và câu trả lời đã chọn vào các RichTextBox
                rt_question.Text = selectedQuestion.QuestionText;
                rt_answer.Text = selectedQuestion.Answer;
            }
            else
            {
                MessageBox.Show("Question not found!");
            }
        }

        // Sự kiện khi người dùng nhấn nút Save
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (selectedQuestion == null)
            {
                MessageBox.Show("Please select a question to edit.");
                return;
            }

            // Lưu câu hỏi và câu trả lời đã chỉnh sửa
            selectedQuestion.QuestionText = rt_question.Text; // Use the correct property name
            selectedQuestion.Answer = rt_answer.Text; // Use the correct property name

            // Thông báo người dùng đã lưu thành công và đóng form
            MessageBox.Show("Question updated successfully!");
            this.Close();
        }
    }
}

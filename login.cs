using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class login : Form
    {
        // Initialize a shared question bank
        public List<Question> QuestionBank { get; set; }

        public login()
        {
            InitializeComponent();
            password.PasswordChar = '*';

            QuestionBank = QuestionFactory.GetSampleQuestions();

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // Validate login credentials
            if (name.Text == "tony" && password.Text == "1234")
            {
                if (cb_role.Text == "Creator")
                {
                    // Open creator form and pass the question bank
                    //this.Hide();
                    creator creatorForm = new creator(QuestionBank);
                    creatorForm.QuestionBank = QuestionBank; // Pass question bank to creator
                    creatorForm.ShowDialog();
                }
                else if (cb_role.Text == "Player")
                {
                    //this.Hide();
                    // Open player form and pass the question bank
                    player playerForm = new player(QuestionBank); // Pass question bank to player
                    playerForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a valid role.");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}

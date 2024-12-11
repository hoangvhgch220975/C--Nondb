namespace login
{
    partial class player
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rt_question = new System.Windows.Forms.RichTextBox();
            this.rt_answer = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_next = new System.Windows.Forms.Button();
            this.bt_finish = new System.Windows.Forms.Button();
            this.rd_opt1 = new System.Windows.Forms.RadioButton();
            this.rd_opt2 = new System.Windows.Forms.RadioButton();
            this.rd_opt3 = new System.Windows.Forms.RadioButton();
            this.rd_opt4 = new System.Windows.Forms.RadioButton();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rt_question
            // 
            this.rt_question.Location = new System.Drawing.Point(16, 53);
            this.rt_question.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rt_question.Name = "rt_question";
            this.rt_question.Size = new System.Drawing.Size(459, 297);
            this.rt_question.TabIndex = 0;
            this.rt_question.Text = "";
            // 
            // rt_answer
            // 
            this.rt_answer.Location = new System.Drawing.Point(591, 53);
            this.rt_answer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rt_answer.Name = "rt_answer";
            this.rt_answer.Size = new System.Drawing.Size(459, 297);
            this.rt_answer.TabIndex = 1;
            this.rt_answer.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Answer";
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(303, 406);
            this.bt_start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(100, 28);
            this.bt_start.TabIndex = 4;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_next
            // 
            this.bt_next.Location = new System.Drawing.Point(487, 406);
            this.bt_next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(100, 28);
            this.bt_next.TabIndex = 5;
            this.bt_next.Text = "Next";
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
            // 
            // bt_finish
            // 
            this.bt_finish.Location = new System.Drawing.Point(704, 406);
            this.bt_finish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_finish.Name = "bt_finish";
            this.bt_finish.Size = new System.Drawing.Size(100, 28);
            this.bt_finish.TabIndex = 6;
            this.bt_finish.Text = "Finish";
            this.bt_finish.UseVisualStyleBackColor = true;
            this.bt_finish.Click += new System.EventHandler(this.bt_finish_Click);
            // 
            // rd_opt1
            // 
            this.rd_opt1.AutoSize = true;
            this.rd_opt1.Location = new System.Drawing.Point(591, 75);
            this.rd_opt1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_opt1.Name = "rd_opt1";
            this.rd_opt1.Size = new System.Drawing.Size(103, 20);
            this.rd_opt1.TabIndex = 7;
            this.rd_opt1.TabStop = true;
            this.rd_opt1.Text = "radioButton1";
            this.rd_opt1.UseVisualStyleBackColor = true;
            // 
            // rd_opt2
            // 
            this.rd_opt2.AutoSize = true;
            this.rd_opt2.Location = new System.Drawing.Point(591, 127);
            this.rd_opt2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_opt2.Name = "rd_opt2";
            this.rd_opt2.Size = new System.Drawing.Size(103, 20);
            this.rd_opt2.TabIndex = 8;
            this.rd_opt2.TabStop = true;
            this.rd_opt2.Text = "radioButton2";
            this.rd_opt2.UseVisualStyleBackColor = true;
            // 
            // rd_opt3
            // 
            this.rd_opt3.AutoSize = true;
            this.rd_opt3.Location = new System.Drawing.Point(591, 183);
            this.rd_opt3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_opt3.Name = "rd_opt3";
            this.rd_opt3.Size = new System.Drawing.Size(103, 20);
            this.rd_opt3.TabIndex = 9;
            this.rd_opt3.TabStop = true;
            this.rd_opt3.Text = "radioButton3";
            this.rd_opt3.UseVisualStyleBackColor = true;
            // 
            // rd_opt4
            // 
            this.rd_opt4.AutoSize = true;
            this.rd_opt4.Location = new System.Drawing.Point(591, 245);
            this.rd_opt4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_opt4.Name = "rd_opt4";
            this.rd_opt4.Size = new System.Drawing.Size(103, 20);
            this.rd_opt4.TabIndex = 10;
            this.rd_opt4.TabStop = true;
            this.rd_opt4.Text = "radioButton4";
            this.rd_opt4.UseVisualStyleBackColor = true;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(989, 16);
            this.lbl_score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(66, 24);
            this.lbl_score.TabIndex = 11;
            this.lbl_score.Text = "label3";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(852, 16);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(76, 34);
            this.lbl_time.TabIndex = 12;
            this.lbl_time.Text = "label3";
            this.lbl_time.UseCompatibleTextRendering = true;
            // 
            // player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.rd_opt4);
            this.Controls.Add(this.rd_opt3);
            this.Controls.Add(this.rd_opt2);
            this.Controls.Add(this.rd_opt1);
            this.Controls.Add(this.bt_finish);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rt_answer);
            this.Controls.Add(this.rt_question);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "player";
            this.Text = "player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_question;
        private System.Windows.Forms.RichTextBox rt_answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.Button bt_finish;
        private System.Windows.Forms.RadioButton rd_opt1;
        private System.Windows.Forms.RadioButton rd_opt2;
        private System.Windows.Forms.RadioButton rd_opt3;
        private System.Windows.Forms.RadioButton rd_opt4;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_time;
    }
}
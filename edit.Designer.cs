namespace login
{
    partial class edit
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rt_answer = new System.Windows.Forms.RichTextBox();
            this.rt_question = new System.Windows.Forms.RichTextBox();
            this.rt_all_question = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();

            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(327, 358);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 41);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Answer";

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Question";

            // 
            // rt_answer
            // 
            this.rt_answer.Location = new System.Drawing.Point(30, 206);
            this.rt_answer.Name = "rt_answer";
            this.rt_answer.Size = new System.Drawing.Size(322, 96);
            this.rt_answer.TabIndex = 11;
            this.rt_answer.Text = "";

            // 
            // rt_question
            // 
            this.rt_question.Location = new System.Drawing.Point(30, 43);
            this.rt_question.Name = "rt_question";
            this.rt_question.Size = new System.Drawing.Size(322, 96);
            this.rt_question.TabIndex = 10;
            this.rt_question.Text = "";

            // 
            // rt_all_question
            // 
            this.rt_all_question.Location = new System.Drawing.Point(421, 43);
            this.rt_all_question.Name = "rt_all_question";
            this.rt_all_question.Size = new System.Drawing.Size(274, 259);
            this.rt_all_question.TabIndex = 15;
            this.rt_all_question.Text = "";
            this.rt_all_question.SelectionChanged += new System.EventHandler(this.rt_all_question_SelectionChanged);

            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.rt_all_question);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rt_answer);
            this.Controls.Add(this.rt_question);
            this.Name = "edit";
            this.Text = "Edit Question";
            this.Load += new System.EventHandler(this.edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rt_answer;
        private System.Windows.Forms.RichTextBox rt_question;
        private System.Windows.Forms.RichTextBox rt_all_question;
    }
}

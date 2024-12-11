namespace login
{
    partial class true_false
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(true_false));
            this.label1 = new System.Windows.Forms.Label();
            this.rt_question = new System.Windows.Forms.RichTextBox();
            this.rbtn_true = new System.Windows.Forms.RadioButton();
            this.rbtn_false = new System.Windows.Forms.RadioButton();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Question";
            // 
            // rt_question
            // 
            this.rt_question.Location = new System.Drawing.Point(116, 64);
            this.rt_question.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rt_question.Name = "rt_question";
            this.rt_question.Size = new System.Drawing.Size(428, 117);
            this.rt_question.TabIndex = 8;
            this.rt_question.Text = "";
            // 
            // rbtn_true
            // 
            this.rbtn_true.AutoSize = true;
            this.rbtn_true.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_true.Location = new System.Drawing.Point(116, 228);
            this.rbtn_true.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_true.Name = "rbtn_true";
            this.rbtn_true.Size = new System.Drawing.Size(76, 30);
            this.rbtn_true.TabIndex = 10;
            this.rbtn_true.TabStop = true;
            this.rbtn_true.Text = "True";
            this.rbtn_true.UseVisualStyleBackColor = true;
            // 
            // rbtn_false
            // 
            this.rbtn_false.AutoSize = true;
            this.rbtn_false.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_false.Location = new System.Drawing.Point(447, 228);
            this.rbtn_false.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_false.Name = "rbtn_false";
            this.rbtn_false.Size = new System.Drawing.Size(77, 30);
            this.rbtn_false.TabIndex = 11;
            this.rbtn_false.TabStop = true;
            this.rbtn_false.Text = "False";
            this.rbtn_false.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(265, 310);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(124, 52);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // true_false
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 457);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.rbtn_false);
            this.Controls.Add(this.rbtn_true);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rt_question);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "true_false";
            this.Text = "true_false";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rt_question;
        private System.Windows.Forms.RadioButton rbtn_true;
        private System.Windows.Forms.RadioButton rbtn_false;
        private System.Windows.Forms.Button btn_save;
    }
}
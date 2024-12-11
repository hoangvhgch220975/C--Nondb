namespace login
{
    partial class creator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(creator));
            this.rt_all_question = new System.Windows.Forms.RichTextBox();
            this.bt_add_question = new System.Windows.Forms.Button();
            this.bt_display_all = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.rbtn_tf = new System.Windows.Forms.RadioButton();
            this.rbtn_multi = new System.Windows.Forms.RadioButton();
            this.rbtn_openend = new System.Windows.Forms.RadioButton();
            this.rt_question = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rt_all_question
            // 
            this.rt_all_question.Location = new System.Drawing.Point(624, 26);
            this.rt_all_question.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rt_all_question.Name = "rt_all_question";
            this.rt_all_question.Size = new System.Drawing.Size(364, 358);
            this.rt_all_question.TabIndex = 1;
            this.rt_all_question.Text = "";
            // 
            // bt_add_question
            // 
            this.bt_add_question.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add_question.Location = new System.Drawing.Point(37, 409);
            this.bt_add_question.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_add_question.Name = "bt_add_question";
            this.bt_add_question.Size = new System.Drawing.Size(193, 52);
            this.bt_add_question.TabIndex = 5;
            this.bt_add_question.Text = "Add Question";
            this.bt_add_question.UseVisualStyleBackColor = true;
            this.bt_add_question.Click += new System.EventHandler(this.bt_add_question_Click);
            // 
            // bt_display_all
            // 
            this.bt_display_all.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_display_all.Location = new System.Drawing.Point(624, 409);
            this.bt_display_all.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_display_all.Name = "bt_display_all";
            this.bt_display_all.Size = new System.Drawing.Size(163, 53);
            this.bt_display_all.TabIndex = 6;
            this.bt_display_all.Text = "Display All Questions";
            this.bt_display_all.UseVisualStyleBackColor = true;
            this.bt_display_all.Click += new System.EventHandler(this.bt_display_all_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.Location = new System.Drawing.Point(827, 409);
            this.bt_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(163, 53);
            this.bt_delete.TabIndex = 7;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit.Location = new System.Drawing.Point(273, 409);
            this.bt_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(193, 52);
            this.bt_edit.TabIndex = 8;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // rbtn_tf
            // 
            this.rbtn_tf.AutoSize = true;
            this.rbtn_tf.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_tf.Location = new System.Drawing.Point(37, 257);
            this.rbtn_tf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_tf.Name = "rbtn_tf";
            this.rbtn_tf.Size = new System.Drawing.Size(129, 30);
            this.rbtn_tf.TabIndex = 9;
            this.rbtn_tf.TabStop = true;
            this.rbtn_tf.Text = "True-False";
            this.rbtn_tf.UseVisualStyleBackColor = true;
            // 
            // rbtn_multi
            // 
            this.rbtn_multi.AutoSize = true;
            this.rbtn_multi.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_multi.Location = new System.Drawing.Point(37, 299);
            this.rbtn_multi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_multi.Name = "rbtn_multi";
            this.rbtn_multi.Size = new System.Drawing.Size(183, 30);
            this.rbtn_multi.TabIndex = 11;
            this.rbtn_multi.TabStop = true;
            this.rbtn_multi.Text = "Multiple choices";
            this.rbtn_multi.UseVisualStyleBackColor = true;
            // 
            // rbtn_openend
            // 
            this.rbtn_openend.AutoSize = true;
            this.rbtn_openend.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_openend.Location = new System.Drawing.Point(37, 341);
            this.rbtn_openend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_openend.Name = "rbtn_openend";
            this.rbtn_openend.Size = new System.Drawing.Size(120, 30);
            this.rbtn_openend.TabIndex = 13;
            this.rbtn_openend.TabStop = true;
            this.rbtn_openend.Text = "Open-end";
            this.rbtn_openend.UseVisualStyleBackColor = true;
            // 
            // rt_question
            // 
            this.rt_question.Location = new System.Drawing.Point(37, 26);
            this.rt_question.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rt_question.Name = "rt_question";
            this.rt_question.Size = new System.Drawing.Size(428, 223);
            this.rt_question.TabIndex = 14;
            this.rt_question.Text = "";
            // 
            // creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rt_question);
            this.Controls.Add(this.rbtn_openend);
            this.Controls.Add(this.rbtn_multi);
            this.Controls.Add(this.rbtn_tf);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_display_all);
            this.Controls.Add(this.bt_add_question);
            this.Controls.Add(this.rt_all_question);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "creator";
            this.Text = "creator";
            this.Load += new System.EventHandler(this.creator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rt_all_question;
        private System.Windows.Forms.Button bt_add_question;
        private System.Windows.Forms.Button bt_display_all;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.RadioButton rbtn_tf;
        private System.Windows.Forms.RadioButton rbtn_multi;
        private System.Windows.Forms.RadioButton rbtn_openend;
        private System.Windows.Forms.RichTextBox rt_question;
    }
}
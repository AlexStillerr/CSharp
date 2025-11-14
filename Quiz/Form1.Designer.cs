namespace Quiz
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.AnswerBtn = new System.Windows.Forms.Button();
            this.MultiSelection = new System.Windows.Forms.Panel();
            this.MultiSelectionBox4 = new System.Windows.Forms.CheckBox();
            this.MultiSelectionBox3 = new System.Windows.Forms.CheckBox();
            this.MultiSelectionBox2 = new System.Windows.Forms.CheckBox();
            this.MultiSelectionBox1 = new System.Windows.Forms.CheckBox();
            this.SingleSelection = new System.Windows.Forms.Panel();
            this.SingleSelectionRadio4 = new System.Windows.Forms.RadioButton();
            this.SingleSelectionRadio3 = new System.Windows.Forms.RadioButton();
            this.SingleSelectionRadio2 = new System.Windows.Forms.RadioButton();
            this.SingleSelectionRadio1 = new System.Windows.Forms.RadioButton();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.NextBtn = new System.Windows.Forms.Button();
            this.MultiSelection.SuspendLayout();
            this.SingleSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(45, 9);
            this.CategoryLabel.MinimumSize = new System.Drawing.Size(500, 50);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(500, 50);
            this.CategoryLabel.TabIndex = 0;
            this.CategoryLabel.Text = "Kategorie";
            this.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerBtn
            // 
            this.AnswerBtn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerBtn.Location = new System.Drawing.Point(12, 404);
            this.AnswerBtn.Name = "AnswerBtn";
            this.AnswerBtn.Size = new System.Drawing.Size(206, 45);
            this.AnswerBtn.TabIndex = 4;
            this.AnswerBtn.Text = "Antworten";
            this.AnswerBtn.UseVisualStyleBackColor = true;
            this.AnswerBtn.Click += new System.EventHandler(this.AnswerBtn_Click);
            // 
            // MultiSelection
            // 
            this.MultiSelection.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MultiSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MultiSelection.Controls.Add(this.MultiSelectionBox4);
            this.MultiSelection.Controls.Add(this.MultiSelectionBox3);
            this.MultiSelection.Controls.Add(this.MultiSelectionBox2);
            this.MultiSelection.Controls.Add(this.MultiSelectionBox1);
            this.MultiSelection.Enabled = false;
            this.MultiSelection.Location = new System.Drawing.Point(12, 165);
            this.MultiSelection.Name = "MultiSelection";
            this.MultiSelection.Size = new System.Drawing.Size(560, 199);
            this.MultiSelection.TabIndex = 1;
            this.MultiSelection.Visible = false;
            // 
            // MultiSelectionBox4
            // 
            this.MultiSelectionBox4.AutoSize = true;
            this.MultiSelectionBox4.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiSelectionBox4.Location = new System.Drawing.Point(38, 156);
            this.MultiSelectionBox4.Name = "MultiSelectionBox4";
            this.MultiSelectionBox4.Size = new System.Drawing.Size(281, 25);
            this.MultiSelectionBox4.TabIndex = 4;
            this.MultiSelectionBox4.TabStop = false;
            this.MultiSelectionBox4.Text = "Das ist Antwortmöglichkeit 1";
            this.MultiSelectionBox4.UseVisualStyleBackColor = true;
            // 
            // MultiSelectionBox3
            // 
            this.MultiSelectionBox3.AutoSize = true;
            this.MultiSelectionBox3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiSelectionBox3.Location = new System.Drawing.Point(38, 113);
            this.MultiSelectionBox3.Name = "MultiSelectionBox3";
            this.MultiSelectionBox3.Size = new System.Drawing.Size(281, 25);
            this.MultiSelectionBox3.TabIndex = 3;
            this.MultiSelectionBox3.TabStop = false;
            this.MultiSelectionBox3.Text = "Das ist Antwortmöglichkeit 1";
            this.MultiSelectionBox3.UseVisualStyleBackColor = true;
            // 
            // MultiSelectionBox2
            // 
            this.MultiSelectionBox2.AutoSize = true;
            this.MultiSelectionBox2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiSelectionBox2.Location = new System.Drawing.Point(38, 69);
            this.MultiSelectionBox2.Name = "MultiSelectionBox2";
            this.MultiSelectionBox2.Size = new System.Drawing.Size(281, 25);
            this.MultiSelectionBox2.TabIndex = 2;
            this.MultiSelectionBox2.TabStop = false;
            this.MultiSelectionBox2.Text = "Das ist Antwortmöglichkeit 1";
            this.MultiSelectionBox2.UseVisualStyleBackColor = true;
            // 
            // MultiSelectionBox1
            // 
            this.MultiSelectionBox1.AutoSize = true;
            this.MultiSelectionBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MultiSelectionBox1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiSelectionBox1.Location = new System.Drawing.Point(38, 24);
            this.MultiSelectionBox1.Name = "MultiSelectionBox1";
            this.MultiSelectionBox1.Size = new System.Drawing.Size(281, 25);
            this.MultiSelectionBox1.TabIndex = 1;
            this.MultiSelectionBox1.TabStop = false;
            this.MultiSelectionBox1.Text = "Das ist Antwortmöglichkeit 1";
            this.MultiSelectionBox1.UseVisualStyleBackColor = false;
            // 
            // SingleSelection
            // 
            this.SingleSelection.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SingleSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SingleSelection.Controls.Add(this.SingleSelectionRadio4);
            this.SingleSelection.Controls.Add(this.SingleSelectionRadio3);
            this.SingleSelection.Controls.Add(this.SingleSelectionRadio2);
            this.SingleSelection.Controls.Add(this.SingleSelectionRadio1);
            this.SingleSelection.Enabled = false;
            this.SingleSelection.Location = new System.Drawing.Point(12, 165);
            this.SingleSelection.Name = "SingleSelection";
            this.SingleSelection.Size = new System.Drawing.Size(560, 199);
            this.SingleSelection.TabIndex = 5;
            this.SingleSelection.Visible = false;
            // 
            // SingleSelectionRadio4
            // 
            this.SingleSelectionRadio4.AutoSize = true;
            this.SingleSelectionRadio4.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleSelectionRadio4.Location = new System.Drawing.Point(38, 155);
            this.SingleSelectionRadio4.Name = "SingleSelectionRadio4";
            this.SingleSelectionRadio4.Size = new System.Drawing.Size(280, 25);
            this.SingleSelectionRadio4.TabIndex = 8;
            this.SingleSelectionRadio4.Text = "Das ist Antwortmöglichkeit 1";
            this.SingleSelectionRadio4.UseVisualStyleBackColor = true;
            // 
            // SingleSelectionRadio3
            // 
            this.SingleSelectionRadio3.AutoSize = true;
            this.SingleSelectionRadio3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleSelectionRadio3.Location = new System.Drawing.Point(38, 113);
            this.SingleSelectionRadio3.Name = "SingleSelectionRadio3";
            this.SingleSelectionRadio3.Size = new System.Drawing.Size(280, 25);
            this.SingleSelectionRadio3.TabIndex = 7;
            this.SingleSelectionRadio3.Text = "Das ist Antwortmöglichkeit 1";
            this.SingleSelectionRadio3.UseVisualStyleBackColor = true;
            // 
            // SingleSelectionRadio2
            // 
            this.SingleSelectionRadio2.AutoSize = true;
            this.SingleSelectionRadio2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleSelectionRadio2.Location = new System.Drawing.Point(38, 69);
            this.SingleSelectionRadio2.Name = "SingleSelectionRadio2";
            this.SingleSelectionRadio2.Size = new System.Drawing.Size(280, 25);
            this.SingleSelectionRadio2.TabIndex = 6;
            this.SingleSelectionRadio2.Text = "Das ist Antwortmöglichkeit 1";
            this.SingleSelectionRadio2.UseVisualStyleBackColor = true;
            // 
            // SingleSelectionRadio1
            // 
            this.SingleSelectionRadio1.AutoSize = true;
            this.SingleSelectionRadio1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleSelectionRadio1.Location = new System.Drawing.Point(38, 23);
            this.SingleSelectionRadio1.Name = "SingleSelectionRadio1";
            this.SingleSelectionRadio1.Size = new System.Drawing.Size(280, 25);
            this.SingleSelectionRadio1.TabIndex = 5;
            this.SingleSelectionRadio1.Text = "Das ist Antwortmöglichkeit 1";
            this.SingleSelectionRadio1.UseVisualStyleBackColor = true;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.QuestionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(12, 62);
            this.QuestionLabel.MinimumSize = new System.Drawing.Size(560, 100);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(560, 100);
            this.QuestionLabel.TabIndex = 6;
            this.QuestionLabel.Text = "Frage";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextBtn
            // 
            this.NextBtn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.Location = new System.Drawing.Point(366, 404);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(206, 45);
            this.NextBtn.TabIndex = 7;
            this.NextBtn.Text = "Skip";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.SingleSelection);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.MultiSelection);
            this.Controls.Add(this.AnswerBtn);
            this.Controls.Add(this.CategoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Code Quizzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MultiSelection.ResumeLayout(false);
            this.MultiSelection.PerformLayout();
            this.SingleSelection.ResumeLayout(false);
            this.SingleSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Button AnswerBtn;
        private System.Windows.Forms.Panel MultiSelection;
        private System.Windows.Forms.CheckBox MultiSelectionBox4;
        private System.Windows.Forms.CheckBox MultiSelectionBox3;
        private System.Windows.Forms.CheckBox MultiSelectionBox2;
        private System.Windows.Forms.CheckBox MultiSelectionBox1;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Panel SingleSelection;
        private System.Windows.Forms.RadioButton SingleSelectionRadio4;
        private System.Windows.Forms.RadioButton SingleSelectionRadio3;
        private System.Windows.Forms.RadioButton SingleSelectionRadio2;
        private System.Windows.Forms.RadioButton SingleSelectionRadio1;
    }
}


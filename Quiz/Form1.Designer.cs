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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.label1 = new System.Windows.Forms.Label();
            this.pointsLbl = new System.Windows.Forms.Label();
            this.pointsDiffLbl = new System.Windows.Forms.Label();
            this.StartScreen = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MultiSelection.SuspendLayout();
            this.SingleSelection.SuspendLayout();
            this.StartScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(5, 9);
            this.CategoryLabel.MaximumSize = new System.Drawing.Size(595, 0);
            this.CategoryLabel.MinimumSize = new System.Drawing.Size(570, 50);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(570, 52);
            this.CategoryLabel.TabIndex = 0;
            this.CategoryLabel.Text = "Kategorie Kategorie Kategorie Kategorie Kategorie Kategorie Kategorie v Kategorie" +
    "  v v  Kategoriev";
            this.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerBtn
            // 
            this.AnswerBtn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerBtn.Location = new System.Drawing.Point(12, 518);
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
            this.MultiSelection.Size = new System.Drawing.Size(560, 319);
            this.MultiSelection.TabIndex = 1;
            this.MultiSelection.Visible = false;
            // 
            // MultiSelectionBox4
            // 
            this.MultiSelectionBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MultiSelectionBox4.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiSelectionBox4.Location = new System.Drawing.Point(21, 233);
            this.MultiSelectionBox4.Name = "MultiSelectionBox4";
            this.MultiSelectionBox4.Size = new System.Drawing.Size(523, 70);
            this.MultiSelectionBox4.TabIndex = 4;
            this.MultiSelectionBox4.TabStop = false;
            this.MultiSelectionBox4.Text = "Das ist Antwortmöglichkeit 4";
            this.MultiSelectionBox4.UseVisualStyleBackColor = false;
            // 
            // MultiSelectionBox3
            // 
            this.MultiSelectionBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MultiSelectionBox3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiSelectionBox3.Location = new System.Drawing.Point(21, 157);
            this.MultiSelectionBox3.Name = "MultiSelectionBox3";
            this.MultiSelectionBox3.Size = new System.Drawing.Size(523, 70);
            this.MultiSelectionBox3.TabIndex = 3;
            this.MultiSelectionBox3.TabStop = false;
            this.MultiSelectionBox3.Text = "Das ist Antwortmöglichkeit 3";
            this.MultiSelectionBox3.UseVisualStyleBackColor = false;
            // 
            // MultiSelectionBox2
            // 
            this.MultiSelectionBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MultiSelectionBox2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiSelectionBox2.Location = new System.Drawing.Point(21, 81);
            this.MultiSelectionBox2.Name = "MultiSelectionBox2";
            this.MultiSelectionBox2.Size = new System.Drawing.Size(523, 70);
            this.MultiSelectionBox2.TabIndex = 2;
            this.MultiSelectionBox2.TabStop = false;
            this.MultiSelectionBox2.Text = "Das ist Antwortmöglichkeit 2";
            this.MultiSelectionBox2.UseVisualStyleBackColor = false;
            // 
            // MultiSelectionBox1
            // 
            this.MultiSelectionBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MultiSelectionBox1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiSelectionBox1.Location = new System.Drawing.Point(21, 6);
            this.MultiSelectionBox1.Name = "MultiSelectionBox1";
            this.MultiSelectionBox1.Size = new System.Drawing.Size(523, 70);
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
            this.SingleSelection.Size = new System.Drawing.Size(560, 319);
            this.SingleSelection.TabIndex = 5;
            this.SingleSelection.Visible = false;
            // 
            // SingleSelectionRadio4
            // 
            this.SingleSelectionRadio4.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleSelectionRadio4.Location = new System.Drawing.Point(21, 233);
            this.SingleSelectionRadio4.Name = "SingleSelectionRadio4";
            this.SingleSelectionRadio4.Size = new System.Drawing.Size(523, 70);
            this.SingleSelectionRadio4.TabIndex = 8;
            this.SingleSelectionRadio4.Text = "Antwort 4";
            this.SingleSelectionRadio4.UseVisualStyleBackColor = true;
            // 
            // SingleSelectionRadio3
            // 
            this.SingleSelectionRadio3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleSelectionRadio3.Location = new System.Drawing.Point(21, 157);
            this.SingleSelectionRadio3.Name = "SingleSelectionRadio3";
            this.SingleSelectionRadio3.Size = new System.Drawing.Size(523, 70);
            this.SingleSelectionRadio3.TabIndex = 7;
            this.SingleSelectionRadio3.Text = "Antwort 3";
            this.SingleSelectionRadio3.UseVisualStyleBackColor = true;
            // 
            // SingleSelectionRadio2
            // 
            this.SingleSelectionRadio2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleSelectionRadio2.Location = new System.Drawing.Point(21, 81);
            this.SingleSelectionRadio2.Name = "SingleSelectionRadio2";
            this.SingleSelectionRadio2.Size = new System.Drawing.Size(523, 70);
            this.SingleSelectionRadio2.TabIndex = 6;
            this.SingleSelectionRadio2.Text = "Antwort 2";
            this.SingleSelectionRadio2.UseVisualStyleBackColor = true;
            // 
            // SingleSelectionRadio1
            // 
            this.SingleSelectionRadio1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleSelectionRadio1.Location = new System.Drawing.Point(21, 5);
            this.SingleSelectionRadio1.Name = "SingleSelectionRadio1";
            this.SingleSelectionRadio1.Size = new System.Drawing.Size(523, 70);
            this.SingleSelectionRadio1.TabIndex = 5;
            this.SingleSelectionRadio1.Text = "Antwort 1";
            this.SingleSelectionRadio1.UseVisualStyleBackColor = true;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.QuestionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(12, 62);
            this.QuestionLabel.MinimumSize = new System.Drawing.Size(560, 100);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(560, 100);
            this.QuestionLabel.TabIndex = 6;
            this.QuestionLabel.Text = "Welche Aussagen über den Unterschied zwischen Policy-Based und Value-Based Method" +
    "en sind korrekt?";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextBtn
            // 
            this.NextBtn.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.Location = new System.Drawing.Point(366, 518);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(206, 45);
            this.NextBtn.TabIndex = 7;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Points:";
            // 
            // pointsLbl
            // 
            this.pointsLbl.AutoSize = true;
            this.pointsLbl.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLbl.Location = new System.Drawing.Point(273, 518);
            this.pointsLbl.Name = "pointsLbl";
            this.pointsLbl.Size = new System.Drawing.Size(47, 35);
            this.pointsLbl.TabIndex = 9;
            this.pointsLbl.Text = "99";
            // 
            // pointsDiffLbl
            // 
            this.pointsDiffLbl.AutoSize = true;
            this.pointsDiffLbl.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsDiffLbl.ForeColor = System.Drawing.Color.Tomato;
            this.pointsDiffLbl.Location = new System.Drawing.Point(314, 524);
            this.pointsDiffLbl.Name = "pointsDiffLbl";
            this.pointsDiffLbl.Size = new System.Drawing.Size(36, 28);
            this.pointsDiffLbl.TabIndex = 10;
            this.pointsDiffLbl.Text = "-4";
            // 
            // StartScreen
            // 
            this.StartScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartScreen.Controls.Add(this.button1);
            this.StartScreen.Controls.Add(this.label2);
            this.StartScreen.Controls.Add(this.pictureBox1);
            this.StartScreen.Location = new System.Drawing.Point(12, 12);
            this.StartScreen.Name = "StartScreen";
            this.StartScreen.Size = new System.Drawing.Size(560, 554);
            this.StartScreen.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(211, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Starten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mein Lern Quiz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 393);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 575);
            this.Controls.Add(this.StartScreen);
            this.Controls.Add(this.pointsDiffLbl);
            this.Controls.Add(this.pointsLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.MultiSelection);
            this.Controls.Add(this.AnswerBtn);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.SingleSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Code Quizzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MultiSelection.ResumeLayout(false);
            this.SingleSelection.ResumeLayout(false);
            this.StartScreen.ResumeLayout(false);
            this.StartScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Button AnswerBtn;
        private System.Windows.Forms.Panel MultiSelection;
        private System.Windows.Forms.CheckBox MultiSelectionBox1;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Panel SingleSelection;
        private System.Windows.Forms.RadioButton SingleSelectionRadio1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pointsLbl;
        private System.Windows.Forms.Label pointsDiffLbl;
        private System.Windows.Forms.Panel StartScreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton SingleSelectionRadio4;
        private System.Windows.Forms.RadioButton SingleSelectionRadio3;
        private System.Windows.Forms.RadioButton SingleSelectionRadio2;
        private System.Windows.Forms.CheckBox MultiSelectionBox4;
        private System.Windows.Forms.CheckBox MultiSelectionBox3;
        private System.Windows.Forms.CheckBox MultiSelectionBox2;
    }
}


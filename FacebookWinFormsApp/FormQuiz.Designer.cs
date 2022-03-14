namespace B22_Ex01_Alex_324777424_Lior_208678425
{
    partial class FormQuiz
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.questionGroupBox = new System.Windows.Forms.GroupBox();
            this.answerRadioButton1 = new System.Windows.Forms.RadioButton();
            this.answerRadioButton2 = new System.Windows.Forms.RadioButton();
            this.answerRadioButton3 = new System.Windows.Forms.RadioButton();
            this.answerRadioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.questionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(495, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // questionGroupBox
            // 
            this.questionGroupBox.Controls.Add(this.answerRadioButton4);
            this.questionGroupBox.Controls.Add(this.answerRadioButton3);
            this.questionGroupBox.Controls.Add(this.answerRadioButton2);
            this.questionGroupBox.Controls.Add(this.answerRadioButton1);
            this.questionGroupBox.Location = new System.Drawing.Point(267, 234);
            this.questionGroupBox.Name = "questionGroupBox";
            this.questionGroupBox.Size = new System.Drawing.Size(200, 204);
            this.questionGroupBox.TabIndex = 1;
            this.questionGroupBox.TabStop = false;
            this.questionGroupBox.Text = "groupBox1";
            // 
            // answerRadioButton1
            // 
            this.answerRadioButton1.AutoSize = true;
            this.answerRadioButton1.Location = new System.Drawing.Point(9, 47);
            this.answerRadioButton1.Name = "answerRadioButton1";
            this.answerRadioButton1.Size = new System.Drawing.Size(85, 17);
            this.answerRadioButton1.TabIndex = 1;
            this.answerRadioButton1.TabStop = true;
            this.answerRadioButton1.Text = "radioButton1";
            this.answerRadioButton1.UseVisualStyleBackColor = true;
            // 
            // answerRadioButton2
            // 
            this.answerRadioButton2.AutoSize = true;
            this.answerRadioButton2.Location = new System.Drawing.Point(9, 83);
            this.answerRadioButton2.Name = "answerRadioButton2";
            this.answerRadioButton2.Size = new System.Drawing.Size(85, 17);
            this.answerRadioButton2.TabIndex = 2;
            this.answerRadioButton2.TabStop = true;
            this.answerRadioButton2.Text = "radioButton2";
            this.answerRadioButton2.UseVisualStyleBackColor = true;
            // 
            // answerRadioButton3
            // 
            this.answerRadioButton3.AutoSize = true;
            this.answerRadioButton3.Location = new System.Drawing.Point(9, 120);
            this.answerRadioButton3.Name = "answerRadioButton3";
            this.answerRadioButton3.Size = new System.Drawing.Size(85, 17);
            this.answerRadioButton3.TabIndex = 3;
            this.answerRadioButton3.TabStop = true;
            this.answerRadioButton3.Text = "radioButton3";
            this.answerRadioButton3.UseVisualStyleBackColor = true;
            // 
            // answerRadioButton4
            // 
            this.answerRadioButton4.AutoSize = true;
            this.answerRadioButton4.Location = new System.Drawing.Point(9, 159);
            this.answerRadioButton4.Name = "answerRadioButton4";
            this.answerRadioButton4.Size = new System.Drawing.Size(85, 17);
            this.answerRadioButton4.TabIndex = 4;
            this.answerRadioButton4.TabStop = true;
            this.answerRadioButton4.Text = "radioButton4";
            this.answerRadioButton4.UseVisualStyleBackColor = true;
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources._3551576;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.questionGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormQuiz";
            this.Text = "FormQuiz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.questionGroupBox.ResumeLayout(false);
            this.questionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox questionGroupBox;
        private System.Windows.Forms.RadioButton answerRadioButton4;
        private System.Windows.Forms.RadioButton answerRadioButton3;
        private System.Windows.Forms.RadioButton answerRadioButton2;
        private System.Windows.Forms.RadioButton answerRadioButton1;
    }
}
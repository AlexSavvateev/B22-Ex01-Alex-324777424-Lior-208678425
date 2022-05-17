namespace B22_Ex03_Alex_324777424_Lior_208678425
{
    public partial class FormQuiz
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nameLabel;
            this.questionGroupBox2 = new System.Windows.Forms.GroupBox();
            this.answer4RadioButtonQuestion2 = new System.Windows.Forms.RadioButton();
            this.answer3RadioButtonQuestion2 = new System.Windows.Forms.RadioButton();
            this.answer2RadioButtonQuestion2 = new System.Windows.Forms.RadioButton();
            this.answer1RadioButtonQuestion2 = new System.Windows.Forms.RadioButton();
            this.questionGroupBox1 = new System.Windows.Forms.GroupBox();
            this.answer4RadioButtonQuestion1 = new System.Windows.Forms.RadioButton();
            this.answer3RadioButtonQuestion1 = new System.Windows.Forms.RadioButton();
            this.answer2RadioButtonQuestion1 = new System.Windows.Forms.RadioButton();
            this.answer1RadioButtonQuestion1 = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.LogedInUserLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.questionGroupBox2.SuspendLayout();
            this.questionGroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(21, 125);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(21, 102);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // questionGroupBox2
            // 
            this.questionGroupBox2.Controls.Add(this.answer4RadioButtonQuestion2);
            this.questionGroupBox2.Controls.Add(this.answer3RadioButtonQuestion2);
            this.questionGroupBox2.Controls.Add(this.answer2RadioButtonQuestion2);
            this.questionGroupBox2.Controls.Add(this.answer1RadioButtonQuestion2);
            this.questionGroupBox2.Location = new System.Drawing.Point(265, 243);
            this.questionGroupBox2.Name = "questionGroupBox2";
            this.questionGroupBox2.Size = new System.Drawing.Size(122, 204);
            this.questionGroupBox2.TabIndex = 1;
            this.questionGroupBox2.TabStop = false;
            this.questionGroupBox2.Text = "groupBox2";
            // 
            // answer4RadioButtonQuestion2
            // 
            this.answer4RadioButtonQuestion2.AutoSize = true;
            this.answer4RadioButtonQuestion2.Location = new System.Drawing.Point(9, 159);
            this.answer4RadioButtonQuestion2.Name = "answer4RadioButtonQuestion2";
            this.answer4RadioButtonQuestion2.Size = new System.Drawing.Size(85, 17);
            this.answer4RadioButtonQuestion2.TabIndex = 4;
            this.answer4RadioButtonQuestion2.TabStop = true;
            this.answer4RadioButtonQuestion2.Text = "radioButton4";
            this.answer4RadioButtonQuestion2.UseVisualStyleBackColor = true;
            // 
            // answer3RadioButtonQuestion2
            // 
            this.answer3RadioButtonQuestion2.AutoSize = true;
            this.answer3RadioButtonQuestion2.Location = new System.Drawing.Point(9, 120);
            this.answer3RadioButtonQuestion2.Name = "answer3RadioButtonQuestion2";
            this.answer3RadioButtonQuestion2.Size = new System.Drawing.Size(85, 17);
            this.answer3RadioButtonQuestion2.TabIndex = 3;
            this.answer3RadioButtonQuestion2.TabStop = true;
            this.answer3RadioButtonQuestion2.Text = "radioButton3";
            this.answer3RadioButtonQuestion2.UseVisualStyleBackColor = true;
            // 
            // answer2RadioButtonQuestion2
            // 
            this.answer2RadioButtonQuestion2.AutoSize = true;
            this.answer2RadioButtonQuestion2.Location = new System.Drawing.Point(9, 83);
            this.answer2RadioButtonQuestion2.Name = "answer2RadioButtonQuestion2";
            this.answer2RadioButtonQuestion2.Size = new System.Drawing.Size(85, 17);
            this.answer2RadioButtonQuestion2.TabIndex = 2;
            this.answer2RadioButtonQuestion2.TabStop = true;
            this.answer2RadioButtonQuestion2.Text = "radioButton2";
            this.answer2RadioButtonQuestion2.UseVisualStyleBackColor = true;
            // 
            // answer1RadioButtonQuestion2
            // 
            this.answer1RadioButtonQuestion2.AutoSize = true;
            this.answer1RadioButtonQuestion2.Checked = true;
            this.answer1RadioButtonQuestion2.Location = new System.Drawing.Point(9, 47);
            this.answer1RadioButtonQuestion2.Name = "answer1RadioButtonQuestion2";
            this.answer1RadioButtonQuestion2.Size = new System.Drawing.Size(85, 17);
            this.answer1RadioButtonQuestion2.TabIndex = 1;
            this.answer1RadioButtonQuestion2.TabStop = true;
            this.answer1RadioButtonQuestion2.Text = "radioButton1";
            this.answer1RadioButtonQuestion2.UseVisualStyleBackColor = true;
            // 
            // questionGroupBox1
            // 
            this.questionGroupBox1.Controls.Add(this.answer4RadioButtonQuestion1);
            this.questionGroupBox1.Controls.Add(this.answer3RadioButtonQuestion1);
            this.questionGroupBox1.Controls.Add(this.answer2RadioButtonQuestion1);
            this.questionGroupBox1.Controls.Add(this.answer1RadioButtonQuestion1);
            this.questionGroupBox1.Location = new System.Drawing.Point(68, 243);
            this.questionGroupBox1.Name = "questionGroupBox1";
            this.questionGroupBox1.Size = new System.Drawing.Size(125, 204);
            this.questionGroupBox1.TabIndex = 2;
            this.questionGroupBox1.TabStop = false;
            this.questionGroupBox1.Text = "groupBox1";
            // 
            // answer4RadioButtonQuestion1
            // 
            this.answer4RadioButtonQuestion1.AutoSize = true;
            this.answer4RadioButtonQuestion1.Location = new System.Drawing.Point(9, 159);
            this.answer4RadioButtonQuestion1.Name = "answer4RadioButtonQuestion1";
            this.answer4RadioButtonQuestion1.Size = new System.Drawing.Size(85, 17);
            this.answer4RadioButtonQuestion1.TabIndex = 4;
            this.answer4RadioButtonQuestion1.TabStop = true;
            this.answer4RadioButtonQuestion1.Text = "radioButton4";
            this.answer4RadioButtonQuestion1.UseVisualStyleBackColor = true;
            // 
            // answer3RadioButtonQuestion1
            // 
            this.answer3RadioButtonQuestion1.AutoSize = true;
            this.answer3RadioButtonQuestion1.Location = new System.Drawing.Point(9, 120);
            this.answer3RadioButtonQuestion1.Name = "answer3RadioButtonQuestion1";
            this.answer3RadioButtonQuestion1.Size = new System.Drawing.Size(85, 17);
            this.answer3RadioButtonQuestion1.TabIndex = 3;
            this.answer3RadioButtonQuestion1.TabStop = true;
            this.answer3RadioButtonQuestion1.Text = "radioButton3";
            this.answer3RadioButtonQuestion1.UseVisualStyleBackColor = true;
            // 
            // answer2RadioButtonQuestion1
            // 
            this.answer2RadioButtonQuestion1.AutoSize = true;
            this.answer2RadioButtonQuestion1.Location = new System.Drawing.Point(9, 83);
            this.answer2RadioButtonQuestion1.Name = "answer2RadioButtonQuestion1";
            this.answer2RadioButtonQuestion1.Size = new System.Drawing.Size(85, 17);
            this.answer2RadioButtonQuestion1.TabIndex = 2;
            this.answer2RadioButtonQuestion1.TabStop = true;
            this.answer2RadioButtonQuestion1.Text = "radioButton2";
            this.answer2RadioButtonQuestion1.UseVisualStyleBackColor = true;
            // 
            // answer1RadioButtonQuestion1
            // 
            this.answer1RadioButtonQuestion1.AutoSize = true;
            this.answer1RadioButtonQuestion1.Checked = true;
            this.answer1RadioButtonQuestion1.Location = new System.Drawing.Point(9, 47);
            this.answer1RadioButtonQuestion1.Name = "answer1RadioButtonQuestion1";
            this.answer1RadioButtonQuestion1.Size = new System.Drawing.Size(85, 17);
            this.answer1RadioButtonQuestion1.TabIndex = 1;
            this.answer1RadioButtonQuestion1.TabStop = true;
            this.answer1RadioButtonQuestion1.Text = "radioButton1";
            this.answer1RadioButtonQuestion1.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(209, 103);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(83, 29);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailLabel1);
            this.panel1.Controls.Add(this.imageNormalPictureBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameLabel1);
            this.panel1.Location = new System.Drawing.Point(368, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 155);
            this.panel1.TabIndex = 4;
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLabel1.Location = new System.Drawing.Point(60, 125);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(100, 23);
            this.emailLabel1.TabIndex = 1;
            this.emailLabel1.Text = "label1";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(17, 4);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(100, 91);
            this.imageNormalPictureBox.TabIndex = 3;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(60, 102);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 5;
            this.nameLabel1.Text = "label1";
            // 
            // LogedInUserLabel
            // 
            this.LogedInUserLabel.AutoSize = true;
            this.LogedInUserLabel.Location = new System.Drawing.Point(12, 9);
            this.LogedInUserLabel.Name = "LogedInUserLabel";
            this.LogedInUserLabel.Size = new System.Drawing.Size(35, 13);
            this.LogedInUserLabel.TabIndex = 6;
            this.LogedInUserLabel.Text = "label1";
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources._3551576;
            this.ClientSize = new System.Drawing.Size(578, 476);
            this.Controls.Add(this.LogedInUserLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.questionGroupBox1);
            this.Controls.Add(this.questionGroupBox2);
            this.Name = "FormQuiz";
            this.Text = "FormQuiz";
            this.questionGroupBox2.ResumeLayout(false);
            this.questionGroupBox2.PerformLayout();
            this.questionGroupBox1.ResumeLayout(false);
            this.questionGroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox questionGroupBox2;
        private System.Windows.Forms.RadioButton answer4RadioButtonQuestion2;
        private System.Windows.Forms.RadioButton answer3RadioButtonQuestion2;
        private System.Windows.Forms.RadioButton answer2RadioButtonQuestion2;
        private System.Windows.Forms.RadioButton answer1RadioButtonQuestion2;
        private System.Windows.Forms.GroupBox questionGroupBox1;
        private System.Windows.Forms.RadioButton answer4RadioButtonQuestion1;
        private System.Windows.Forms.RadioButton answer3RadioButtonQuestion1;
        private System.Windows.Forms.RadioButton answer2RadioButtonQuestion1;
        private System.Windows.Forms.RadioButton answer1RadioButtonQuestion1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label LogedInUserLabel;
    }
}
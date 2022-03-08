namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.feedListBox = new System.Windows.Forms.ListBox();
            this.albumsListBox = new System.Windows.Forms.ListBox();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.likedPagesListBox = new System.Windows.Forms.ListBox();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.mainLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.albumsLabel = new System.Windows.Forms.Label();
            this.groupsLabel = new System.Windows.Forms.Label();
            this.likedPagesLabel = new System.Windows.Forms.Label();
            this.eventsLabel = new System.Windows.Forms.Label();
            this.feedPictureBox = new System.Windows.Forms.PictureBox();
            this.commentsListBox = new System.Windows.Forms.ListBox();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.postButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(179, 23);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(12, 41);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(179, 23);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(12, 93);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(179, 179);
            this.profilePictureBox.TabIndex = 53;
            this.profilePictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 275);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(60, 13);
            this.nameLabel.TabIndex = 54;
            this.nameLabel.Text = "Full Name: ";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(12, 292);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(51, 13);
            this.birthDateLabel.TabIndex = 55;
            this.birthDateLabel.Text = "Birthday: ";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(12, 309);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(48, 13);
            this.genderLabel.TabIndex = 56;
            this.genderLabel.Text = "Gender: ";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(12, 326);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(54, 13);
            this.locationLabel.TabIndex = 57;
            this.locationLabel.Text = "Location: ";
            // 
            // feedListBox
            // 
            this.feedListBox.FormattingEnabled = true;
            this.feedListBox.Location = new System.Drawing.Point(198, 145);
            this.feedListBox.Name = "feedListBox";
            this.feedListBox.Size = new System.Drawing.Size(489, 225);
            this.feedListBox.TabIndex = 58;
            this.feedListBox.SelectedIndexChanged += new System.EventHandler(this.feedListBox_SelectedIndexChanged);
            // 
            // albumsListBox
            // 
            this.albumsListBox.FormattingEnabled = true;
            this.albumsListBox.Location = new System.Drawing.Point(692, 28);
            this.albumsListBox.Name = "albumsListBox";
            this.albumsListBox.Size = new System.Drawing.Size(138, 186);
            this.albumsListBox.TabIndex = 59;
            // 
            // eventsListBox
            // 
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.Location = new System.Drawing.Point(197, 511);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(489, 134);
            this.eventsListBox.TabIndex = 60;
            // 
            // groupsListBox
            // 
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.Location = new System.Drawing.Point(692, 247);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(138, 186);
            this.groupsListBox.TabIndex = 61;
            // 
            // likedPagesListBox
            // 
            this.likedPagesListBox.FormattingEnabled = true;
            this.likedPagesListBox.Location = new System.Drawing.Point(692, 459);
            this.likedPagesListBox.Name = "likedPagesListBox";
            this.likedPagesListBox.Size = new System.Drawing.Size(138, 186);
            this.likedPagesListBox.TabIndex = 62;
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.Location = new System.Drawing.Point(12, 342);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(179, 303);
            this.friendsListBox.TabIndex = 63;
            // 
            // mainLogoPictureBox
            // 
            this.mainLogoPictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_Logo;
            this.mainLogoPictureBox.Location = new System.Drawing.Point(208, 12);
            this.mainLogoPictureBox.Name = "mainLogoPictureBox";
            this.mainLogoPictureBox.Size = new System.Drawing.Size(467, 75);
            this.mainLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainLogoPictureBox.TabIndex = 64;
            this.mainLogoPictureBox.TabStop = false;
            // 
            // albumsLabel
            // 
            this.albumsLabel.AutoSize = true;
            this.albumsLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumsLabel.Location = new System.Drawing.Point(731, 3);
            this.albumsLabel.Name = "albumsLabel";
            this.albumsLabel.Size = new System.Drawing.Size(62, 22);
            this.albumsLabel.TabIndex = 66;
            this.albumsLabel.Text = "Albums";
            // 
            // groupsLabel
            // 
            this.groupsLabel.AutoSize = true;
            this.groupsLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsLabel.Location = new System.Drawing.Point(731, 222);
            this.groupsLabel.Name = "groupsLabel";
            this.groupsLabel.Size = new System.Drawing.Size(59, 22);
            this.groupsLabel.TabIndex = 67;
            this.groupsLabel.Text = "Groups";
            // 
            // likedPagesLabel
            // 
            this.likedPagesLabel.AutoSize = true;
            this.likedPagesLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likedPagesLabel.Location = new System.Drawing.Point(717, 436);
            this.likedPagesLabel.Name = "likedPagesLabel";
            this.likedPagesLabel.Size = new System.Drawing.Size(92, 22);
            this.likedPagesLabel.TabIndex = 68;
            this.likedPagesLabel.Text = "Liked Pages";
            // 
            // eventsLabel
            // 
            this.eventsLabel.AutoSize = true;
            this.eventsLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsLabel.Location = new System.Drawing.Point(417, 486);
            this.eventsLabel.Name = "eventsLabel";
            this.eventsLabel.Size = new System.Drawing.Size(58, 22);
            this.eventsLabel.TabIndex = 69;
            this.eventsLabel.Text = "Events";
            // 
            // feedPictureBox
            // 
            this.feedPictureBox.Location = new System.Drawing.Point(565, 145);
            this.feedPictureBox.Name = "feedPictureBox";
            this.feedPictureBox.Size = new System.Drawing.Size(15, 15);
            this.feedPictureBox.TabIndex = 70;
            this.feedPictureBox.TabStop = false;
            this.feedPictureBox.Visible = false;
            // 
            // commentsListBox
            // 
            this.commentsListBox.FormattingEnabled = true;
            this.commentsListBox.Location = new System.Drawing.Point(198, 398);
            this.commentsListBox.Name = "commentsListBox";
            this.commentsListBox.Size = new System.Drawing.Size(488, 82);
            this.commentsListBox.TabIndex = 71;
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.Location = new System.Drawing.Point(407, 373);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(80, 22);
            this.commentsLabel.TabIndex = 72;
            this.commentsLabel.Text = "Comments";
            // 
            // postTextBox
            // 
            this.postTextBox.Location = new System.Drawing.Point(198, 93);
            this.postTextBox.Multiline = true;
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(398, 46);
            this.postTextBox.TabIndex = 73;
            // 
            // postButton
            // 
            this.postButton.Location = new System.Drawing.Point(602, 105);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(75, 23);
            this.postButton.TabIndex = 74;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 657);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.commentsListBox);
            this.Controls.Add(this.feedPictureBox);
            this.Controls.Add(this.eventsLabel);
            this.Controls.Add(this.likedPagesLabel);
            this.Controls.Add(this.groupsLabel);
            this.Controls.Add(this.albumsLabel);
            this.Controls.Add(this.mainLogoPictureBox);
            this.Controls.Add(this.friendsListBox);
            this.Controls.Add(this.likedPagesListBox);
            this.Controls.Add(this.groupsListBox);
            this.Controls.Add(this.eventsListBox);
            this.Controls.Add(this.albumsListBox);
            this.Controls.Add(this.feedListBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.ListBox feedListBox;
        private System.Windows.Forms.ListBox albumsListBox;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.ListBox groupsListBox;
        private System.Windows.Forms.ListBox likedPagesListBox;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.PictureBox mainLogoPictureBox;
        private System.Windows.Forms.Label albumsLabel;
        private System.Windows.Forms.Label groupsLabel;
        private System.Windows.Forms.Label likedPagesLabel;
        private System.Windows.Forms.Label eventsLabel;
        private System.Windows.Forms.PictureBox feedPictureBox;
        private System.Windows.Forms.ListBox commentsListBox;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.Button postButton;
    }
}


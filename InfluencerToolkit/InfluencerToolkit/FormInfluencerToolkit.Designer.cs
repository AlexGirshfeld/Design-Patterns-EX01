namespace InfluencerToolkit
{
    partial class FormInfluencerToolkit
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
            this.loginButton = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(12, 12);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(108, 26);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login to Facbook";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(126, 12);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(93, 82);
            this.pictureBoxProfile.TabIndex = 1;
            this.pictureBoxProfile.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(12, 74);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(94, 17);
            this.checkBoxRememberUser.TabIndex = 3;
            this.checkBoxRememberUser.Text = "Remember me";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(12, 152);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(120, 199);
            this.listBoxAlbums.TabIndex = 4;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(138, 152);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(120, 199);
            this.listBoxPosts.TabIndex = 5;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(264, 152);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(120, 199);
            this.listBoxFriends.TabIndex = 6;
            // 
            // FormInfluencerToolkit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.loginButton);
            this.Name = "FormInfluencerToolkit";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
        public System.Windows.Forms.PictureBox pictureBoxProfile;
        public System.Windows.Forms.ListBox listBoxAlbums;
        public System.Windows.Forms.ListBox listBoxPosts;
        public System.Windows.Forms.ListBox listBoxFriends;
    }
}


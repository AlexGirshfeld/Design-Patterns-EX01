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
            this.components = new System.ComponentModel.Container();
            this.loginButton = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.SortUserLikesButton = new System.Windows.Forms.Button();
            this.UserNameLikesListView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LikesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.AnalyzePostInfluenceExpansionButton = new System.Windows.Forms.Button();
            this.pictureBoxUserPreview = new System.Windows.Forms.PictureBox();
            this.AnalyzePostInfluencePreservationButton = new System.Windows.Forms.Button();
            this.textBoxPostAnalyzerPreview = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPreview)).BeginInit();
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
            this.checkBoxRememberUser.CheckedChanged += new System.EventHandler(this.checkBoxRememberUser_CheckedChanged);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(12, 104);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(120, 199);
            this.listBoxAlbums.TabIndex = 4;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(138, 104);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(120, 199);
            this.listBoxPosts.TabIndex = 5;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(264, 104);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(120, 199);
            this.listBoxFriends.TabIndex = 6;
            // 
            // SortUserLikesButton
            // 
            this.SortUserLikesButton.Location = new System.Drawing.Point(399, 12);
            this.SortUserLikesButton.Name = "SortUserLikesButton";
            this.SortUserLikesButton.Size = new System.Drawing.Size(138, 55);
            this.SortUserLikesButton.TabIndex = 9;
            this.SortUserLikesButton.Text = "Show people who like my content";
            this.SortUserLikesButton.UseVisualStyleBackColor = true;
            this.SortUserLikesButton.Click += new System.EventHandler(this.SortUserLikesButton_Click);
            // 
            // UserNameLikesListView
            // 
            this.UserNameLikesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.LikesColumn});
            this.UserNameLikesListView.HideSelection = false;
            this.UserNameLikesListView.Location = new System.Drawing.Point(399, 74);
            this.UserNameLikesListView.Name = "UserNameLikesListView";
            this.UserNameLikesListView.Size = new System.Drawing.Size(264, 229);
            this.UserNameLikesListView.TabIndex = 10;
            this.UserNameLikesListView.UseCompatibleStateImageBehavior = false;
            this.UserNameLikesListView.View = System.Windows.Forms.View.Details;
            this.UserNameLikesListView.SelectedIndexChanged += new System.EventHandler(this.UserNameLikesListView_SelectedIndexChanged);
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 200;
            // 
            // LikesColumn
            // 
            this.LikesColumn.Text = "Likes ";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // AnalyzePostInfluenceExpansionButton
            // 
            this.AnalyzePostInfluenceExpansionButton.Location = new System.Drawing.Point(12, 339);
            this.AnalyzePostInfluenceExpansionButton.Name = "AnalyzePostInfluenceExpansionButton";
            this.AnalyzePostInfluenceExpansionButton.Size = new System.Drawing.Size(138, 40);
            this.AnalyzePostInfluenceExpansionButton.TabIndex = 11;
            this.AnalyzePostInfluenceExpansionButton.Text = "Analyze selected post influence expansion";
            this.AnalyzePostInfluenceExpansionButton.UseVisualStyleBackColor = true;
            this.AnalyzePostInfluenceExpansionButton.Click += new System.EventHandler(this.AnalyzePostInfluenceExpansionButton_Click);
            // 
            // pictureBoxUserPreview
            // 
            this.pictureBoxUserPreview.Location = new System.Drawing.Point(686, 95);
            this.pictureBoxUserPreview.Name = "pictureBoxUserPreview";
            this.pictureBoxUserPreview.Size = new System.Drawing.Size(150, 96);
            this.pictureBoxUserPreview.TabIndex = 12;
            this.pictureBoxUserPreview.TabStop = false;
            // 
            // AnalyzePostInfluencePreservationButton
            // 
            this.AnalyzePostInfluencePreservationButton.Location = new System.Drawing.Point(12, 395);
            this.AnalyzePostInfluencePreservationButton.Name = "AnalyzePostInfluencePreservationButton";
            this.AnalyzePostInfluencePreservationButton.Size = new System.Drawing.Size(138, 40);
            this.AnalyzePostInfluencePreservationButton.TabIndex = 13;
            this.AnalyzePostInfluencePreservationButton.Text = "Analyze selected post influence preservation";
            this.AnalyzePostInfluencePreservationButton.UseVisualStyleBackColor = true;
            this.AnalyzePostInfluencePreservationButton.Click += new System.EventHandler(this.AnalyzePostInfluencePreservationButton_Click);
            // 
            // textBoxPostAnalyzerPreview
            // 
            this.textBoxPostAnalyzerPreview.Location = new System.Drawing.Point(171, 339);
            this.textBoxPostAnalyzerPreview.Multiline = true;
            this.textBoxPostAnalyzerPreview.Name = "textBoxPostAnalyzerPreview";
            this.textBoxPostAnalyzerPreview.Size = new System.Drawing.Size(366, 96);
            this.textBoxPostAnalyzerPreview.TabIndex = 15;
            this.textBoxPostAnalyzerPreview.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FormInfluencerToolkit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 570);
            this.Controls.Add(this.textBoxPostAnalyzerPreview);
            this.Controls.Add(this.AnalyzePostInfluencePreservationButton);
            this.Controls.Add(this.pictureBoxUserPreview);
            this.Controls.Add(this.AnalyzePostInfluenceExpansionButton);
            this.Controls.Add(this.UserNameLikesListView);
            this.Controls.Add(this.SortUserLikesButton);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.loginButton);
            this.Name = "FormInfluencerToolkit";
            this.Text = "Influencers Toolkit";
            this.ResizeEnd += new System.EventHandler(this.FormInfluencerToolkit_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPreview)).EndInit();
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
        private System.Windows.Forms.Button SortUserLikesButton;
        private System.Windows.Forms.ListView UserNameLikesListView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader LikesColumn;
        private System.Windows.Forms.Button AnalyzePostInfluenceExpansionButton;
        private System.Windows.Forms.Button AnalyzePostInfluencePreservationButton;
        public System.Windows.Forms.TextBox textBoxPostAnalyzerPreview;
        public System.Windows.Forms.PictureBox pictureBoxUserPreview;
    }
}


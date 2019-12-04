namespace InfluencerToolkit
{
    public partial class FormInfluencerToolkit
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
            this.PictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.ListBoxAlbums = new System.Windows.Forms.ListBox();
            this.ListBoxPosts = new System.Windows.Forms.ListBox();
            this.ListBoxFriends = new System.Windows.Forms.ListBox();
            this.SortUserLikesButton = new System.Windows.Forms.Button();
            this.UserNameLikesListView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LikesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.AnalyzePostInfluenceExpansionButton = new System.Windows.Forms.Button();
            this.PictureBoxUserPreview = new System.Windows.Forms.PictureBox();
            this.AnalyzePostInfluencePreservationButton = new System.Windows.Forms.Button();
            this.TextBoxPostAnalyzerPreview = new System.Windows.Forms.TextBox();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(12, 12);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(108, 55);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login to Facbook";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // PictureBoxProfile
            // 
            this.PictureBoxProfile.Location = new System.Drawing.Point(126, 12);
            this.PictureBoxProfile.Name = "PictureBoxProfile";
            this.PictureBoxProfile.Size = new System.Drawing.Size(93, 82);
            this.PictureBoxProfile.TabIndex = 1;
            this.PictureBoxProfile.TabStop = false;
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
            // ListBoxAlbums
            // 
            this.ListBoxAlbums.FormattingEnabled = true;
            this.ListBoxAlbums.Location = new System.Drawing.Point(12, 131);
            this.ListBoxAlbums.Name = "ListBoxAlbums";
            this.ListBoxAlbums.Size = new System.Drawing.Size(120, 199);
            this.ListBoxAlbums.TabIndex = 4;
            // 
            // ListBoxPosts
            // 
            this.ListBoxPosts.FormattingEnabled = true;
            this.ListBoxPosts.Location = new System.Drawing.Point(138, 131);
            this.ListBoxPosts.Name = "ListBoxPosts";
            this.ListBoxPosts.Size = new System.Drawing.Size(120, 199);
            this.ListBoxPosts.TabIndex = 5;
            this.ListBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // ListBoxFriends
            // 
            this.ListBoxFriends.FormattingEnabled = true;
            this.ListBoxFriends.Location = new System.Drawing.Point(264, 131);
            this.ListBoxFriends.Name = "ListBoxFriends";
            this.ListBoxFriends.Size = new System.Drawing.Size(120, 199);
            this.ListBoxFriends.TabIndex = 6;
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
            // PictureBoxUserPreview
            // 
            this.PictureBoxUserPreview.Location = new System.Drawing.Point(669, 131);
            this.PictureBoxUserPreview.Name = "PictureBoxUserPreview";
            this.PictureBoxUserPreview.Size = new System.Drawing.Size(150, 96);
            this.PictureBoxUserPreview.TabIndex = 12;
            this.PictureBoxUserPreview.TabStop = false;
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
            // TextBoxPostAnalyzerPreview
            // 
            this.TextBoxPostAnalyzerPreview.Location = new System.Drawing.Point(171, 339);
            this.TextBoxPostAnalyzerPreview.Multiline = true;
            this.TextBoxPostAnalyzerPreview.Name = "TextBoxPostAnalyzerPreview";
            this.TextBoxPostAnalyzerPreview.Size = new System.Drawing.Size(366, 96);
            this.TextBoxPostAnalyzerPreview.TabIndex = 15;
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.Location = new System.Drawing.Point(543, 339);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(83, 13);
            this.GradeLabel.TabIndex = 16;
            this.GradeLabel.Text = "InfluenceGrade:";
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(543, 359);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(120, 20);
            this.gradeTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Friends:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Posts:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Albums:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(669, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Photo preview:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInfluencerToolkit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 570);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.GradeLabel);
            this.Controls.Add(this.TextBoxPostAnalyzerPreview);
            this.Controls.Add(this.AnalyzePostInfluencePreservationButton);
            this.Controls.Add(this.PictureBoxUserPreview);
            this.Controls.Add(this.AnalyzePostInfluenceExpansionButton);
            this.Controls.Add(this.UserNameLikesListView);
            this.Controls.Add(this.SortUserLikesButton);
            this.Controls.Add(this.ListBoxFriends);
            this.Controls.Add(this.ListBoxPosts);
            this.Controls.Add(this.ListBoxAlbums);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.PictureBoxProfile);
            this.Controls.Add(this.loginButton);
            this.Name = "FormInfluencerToolkit";
            this.Text = "Influencers Toolkit";
            this.ResizeEnd += new System.EventHandler(this.FormInfluencerToolkit_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
        public System.Windows.Forms.PictureBox PictureBoxProfile;
        public System.Windows.Forms.ListBox ListBoxAlbums;
        public System.Windows.Forms.ListBox ListBoxPosts;
        public System.Windows.Forms.ListBox ListBoxFriends;
        private System.Windows.Forms.Button SortUserLikesButton;
        private System.Windows.Forms.ListView UserNameLikesListView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader LikesColumn;
        private System.Windows.Forms.Button AnalyzePostInfluenceExpansionButton;
        private System.Windows.Forms.Button AnalyzePostInfluencePreservationButton;
        public System.Windows.Forms.TextBox TextBoxPostAnalyzerPreview;
        public System.Windows.Forms.PictureBox PictureBoxUserPreview;
        private System.Windows.Forms.Label GradeLabel;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

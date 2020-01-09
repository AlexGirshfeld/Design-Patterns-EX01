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
            System.Windows.Forms.Label rememberUserLabel;
            this.loginButton = new System.Windows.Forms.Button();
            this.PictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.ListBoxPosts = new System.Windows.Forms.ListBox();
            this.ListBoxFriends = new System.Windows.Forms.ListBox();
            this.SortUserLikesButton = new System.Windows.Forms.Button();
            this.UserNameLikesListView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LikesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnalyzePostInfluenceExpansionButton = new System.Windows.Forms.Button();
            this.PictureBoxUserPreview = new System.Windows.Forms.PictureBox();
            this.AnalyzePostInfluencePreservationButton = new System.Windows.Forms.Button();
            this.TextBoxPostAnalyzerPreview = new System.Windows.Forms.TextBox();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.GradeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AppSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rememberUserCheckBox = new System.Windows.Forms.CheckBox();
            this.AlbumAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageSmallPictureBox = new System.Windows.Forms.PictureBox();
            this.ListBoxAlbums = new System.Windows.Forms.ListBox();
            rememberUserLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppSettingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rememberUserLabel
            // 
            rememberUserLabel.AutoSize = true;
            rememberUserLabel.Location = new System.Drawing.Point(12, 101);
            rememberUserLabel.Name = "rememberUserLabel";
            rememberUserLabel.Size = new System.Drawing.Size(115, 17);
            rememberUserLabel.TabIndex = 23;
            rememberUserLabel.Text = "Remember User:";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(16, 15);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(144, 68);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login to Facbook";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // PictureBoxProfile
            // 
            this.PictureBoxProfile.Location = new System.Drawing.Point(168, 15);
            this.PictureBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxProfile.Name = "PictureBoxProfile";
            this.PictureBoxProfile.Size = new System.Drawing.Size(124, 101);
            this.PictureBoxProfile.TabIndex = 1;
            this.PictureBoxProfile.TabStop = false;
            // 
            // ListBoxPosts
            // 
            this.ListBoxPosts.FormattingEnabled = true;
            this.ListBoxPosts.ItemHeight = 16;
            this.ListBoxPosts.Location = new System.Drawing.Point(184, 161);
            this.ListBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.ListBoxPosts.Name = "ListBoxPosts";
            this.ListBoxPosts.Size = new System.Drawing.Size(159, 244);
            this.ListBoxPosts.TabIndex = 5;
            this.ListBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // ListBoxFriends
            // 
            this.ListBoxFriends.FormattingEnabled = true;
            this.ListBoxFriends.ItemHeight = 16;
            this.ListBoxFriends.Location = new System.Drawing.Point(352, 161);
            this.ListBoxFriends.Margin = new System.Windows.Forms.Padding(4);
            this.ListBoxFriends.Name = "ListBoxFriends";
            this.ListBoxFriends.Size = new System.Drawing.Size(159, 244);
            this.ListBoxFriends.TabIndex = 6;
            // 
            // SortUserLikesButton
            // 
            this.SortUserLikesButton.Location = new System.Drawing.Point(532, 15);
            this.SortUserLikesButton.Margin = new System.Windows.Forms.Padding(4);
            this.SortUserLikesButton.Name = "SortUserLikesButton";
            this.SortUserLikesButton.Size = new System.Drawing.Size(184, 68);
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
            this.UserNameLikesListView.Location = new System.Drawing.Point(532, 91);
            this.UserNameLikesListView.Margin = new System.Windows.Forms.Padding(4);
            this.UserNameLikesListView.Name = "UserNameLikesListView";
            this.UserNameLikesListView.Size = new System.Drawing.Size(351, 281);
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
            // AnalyzePostInfluenceExpansionButton
            // 
            this.AnalyzePostInfluenceExpansionButton.Location = new System.Drawing.Point(16, 442);
            this.AnalyzePostInfluenceExpansionButton.Margin = new System.Windows.Forms.Padding(4);
            this.AnalyzePostInfluenceExpansionButton.Name = "AnalyzePostInfluenceExpansionButton";
            this.AnalyzePostInfluenceExpansionButton.Size = new System.Drawing.Size(184, 49);
            this.AnalyzePostInfluenceExpansionButton.TabIndex = 11;
            this.AnalyzePostInfluenceExpansionButton.Text = "Analyze selected post influence expansion";
            this.AnalyzePostInfluenceExpansionButton.UseVisualStyleBackColor = true;
            this.AnalyzePostInfluenceExpansionButton.Click += new System.EventHandler(this.AnalyzePostInfluenceExpansionButton_Click);
            // 
            // PictureBoxUserPreview
            // 
            this.PictureBoxUserPreview.Location = new System.Drawing.Point(892, 161);
            this.PictureBoxUserPreview.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxUserPreview.Name = "PictureBoxUserPreview";
            this.PictureBoxUserPreview.Size = new System.Drawing.Size(200, 118);
            this.PictureBoxUserPreview.TabIndex = 12;
            this.PictureBoxUserPreview.TabStop = false;
            // 
            // AnalyzePostInfluencePreservationButton
            // 
            this.AnalyzePostInfluencePreservationButton.Location = new System.Drawing.Point(16, 511);
            this.AnalyzePostInfluencePreservationButton.Margin = new System.Windows.Forms.Padding(4);
            this.AnalyzePostInfluencePreservationButton.Name = "AnalyzePostInfluencePreservationButton";
            this.AnalyzePostInfluencePreservationButton.Size = new System.Drawing.Size(184, 49);
            this.AnalyzePostInfluencePreservationButton.TabIndex = 13;
            this.AnalyzePostInfluencePreservationButton.Text = "Analyze selected post influence preservation";
            this.AnalyzePostInfluencePreservationButton.UseVisualStyleBackColor = true;
            this.AnalyzePostInfluencePreservationButton.Click += new System.EventHandler(this.AnalyzePostInfluencePreservationButton_Click);
            // 
            // TextBoxPostAnalyzerPreview
            // 
            this.TextBoxPostAnalyzerPreview.Location = new System.Drawing.Point(208, 442);
            this.TextBoxPostAnalyzerPreview.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPostAnalyzerPreview.Multiline = true;
            this.TextBoxPostAnalyzerPreview.Name = "TextBoxPostAnalyzerPreview";
            this.TextBoxPostAnalyzerPreview.Size = new System.Drawing.Size(473, 117);
            this.TextBoxPostAnalyzerPreview.TabIndex = 15;
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.Location = new System.Drawing.Point(724, 417);
            this.GradeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(113, 17);
            this.GradeLabel.TabIndex = 16;
            this.GradeLabel.Text = "Influence Grade:";
            // 
            // GradeTextBox
            // 
            this.GradeTextBox.Location = new System.Drawing.Point(724, 442);
            this.GradeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.GradeTextBox.Name = "GradeTextBox";
            this.GradeTextBox.Size = new System.Drawing.Size(159, 22);
            this.GradeTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Friends:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Posts:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Albums:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(892, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Photo preview:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 417);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Post preview:";
            // 
            // appSettingsBindingSource
            // 
            this.AppSettingsBindingSource.DataSource = typeof(InfluencerToolkit.AppSettings);
            // 
            // rememberUserCheckBox
            // 
            this.rememberUserCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.AppSettingsBindingSource, "RememberUser", true));
            this.rememberUserCheckBox.Location = new System.Drawing.Point(133, 98);
            this.rememberUserCheckBox.Name = "rememberUserCheckBox";
            this.rememberUserCheckBox.Size = new System.Drawing.Size(27, 24);
            this.rememberUserCheckBox.TabIndex = 24;
            this.rememberUserCheckBox.UseVisualStyleBackColor = true;
            // 
            // albumAdapterBindingSource
            // 
            this.AlbumAdapterBindingSource.DataSource = typeof(InfluencerToolkit.AlbumAdapter);
            // 
            // imageSmallPictureBox
            // 
            this.imageSmallPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.AlbumAdapterBindingSource, "ImageSmall", true));
            this.imageSmallPictureBox.Location = new System.Drawing.Point(16, 315);
            this.imageSmallPictureBox.Name = "imageSmallPictureBox";
            this.imageSmallPictureBox.Size = new System.Drawing.Size(148, 90);
            this.imageSmallPictureBox.TabIndex = 30;
            this.imageSmallPictureBox.TabStop = false;
            // 
            // ListBoxAlbums
            // 
            this.ListBoxAlbums.DataSource = this.AlbumAdapterBindingSource;
            this.ListBoxAlbums.DisplayMember = "Name";
            this.ListBoxAlbums.FormattingEnabled = true;
            this.ListBoxAlbums.ItemHeight = 16;
            this.ListBoxAlbums.Location = new System.Drawing.Point(16, 161);
            this.ListBoxAlbums.Name = "ListBoxAlbums";
            this.ListBoxAlbums.Size = new System.Drawing.Size(148, 148);
            this.ListBoxAlbums.TabIndex = 31;
            // 
            // FormInfluencerToolkit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 702);
            this.Controls.Add(this.ListBoxAlbums);
            this.Controls.Add(this.imageSmallPictureBox);
            this.Controls.Add(rememberUserLabel);
            this.Controls.Add(this.rememberUserCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GradeTextBox);
            this.Controls.Add(this.GradeLabel);
            this.Controls.Add(this.TextBoxPostAnalyzerPreview);
            this.Controls.Add(this.AnalyzePostInfluencePreservationButton);
            this.Controls.Add(this.PictureBoxUserPreview);
            this.Controls.Add(this.AnalyzePostInfluenceExpansionButton);
            this.Controls.Add(this.UserNameLikesListView);
            this.Controls.Add(this.SortUserLikesButton);
            this.Controls.Add(this.ListBoxFriends);
            this.Controls.Add(this.ListBoxPosts);
            this.Controls.Add(this.PictureBoxProfile);
            this.Controls.Add(this.loginButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInfluencerToolkit";
            this.Text = "Influencers Toolkit";
            this.ResizeEnd += new System.EventHandler(this.FormInfluencerToolkit_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppSettingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        public System.Windows.Forms.PictureBox PictureBoxProfile;
        public System.Windows.Forms.ListBox ListBoxPosts;
        public System.Windows.Forms.ListBox ListBoxFriends;
        private System.Windows.Forms.Button SortUserLikesButton;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader LikesColumn;
        private System.Windows.Forms.Button AnalyzePostInfluenceExpansionButton;
        private System.Windows.Forms.Button AnalyzePostInfluencePreservationButton;
        public System.Windows.Forms.TextBox TextBoxPostAnalyzerPreview;
        public System.Windows.Forms.PictureBox PictureBoxUserPreview;
        private System.Windows.Forms.Label GradeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListView UserNameLikesListView;
        public System.Windows.Forms.TextBox GradeTextBox;
        public System.Windows.Forms.BindingSource AppSettingsBindingSource;
        private System.Windows.Forms.CheckBox rememberUserCheckBox;
        public System.Windows.Forms.BindingSource AlbumAdapterBindingSource;
        private System.Windows.Forms.PictureBox imageSmallPictureBox;
        public System.Windows.Forms.ListBox ListBoxAlbums;
    }
}

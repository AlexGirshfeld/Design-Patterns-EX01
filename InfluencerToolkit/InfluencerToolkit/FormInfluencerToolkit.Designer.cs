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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfluencerToolkit));
            System.Windows.Forms.Label imageSmallLabel;
            System.Windows.Forms.Label nameLabel;
            this.loginButton = new System.Windows.Forms.Button();
            this.PictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.ListBoxAlbums = new System.Windows.Forms.ListBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.GradeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.appSettingsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.appSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.appSettingsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rememberUserCheckBox = new System.Windows.Forms.CheckBox();
            this.imageSmallPictureBox1 = new System.Windows.Forms.PictureBox();
            this.albumAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageSmallPictureBox = new System.Windows.Forms.PictureBox();
            this.nameListBox = new System.Windows.Forms.ListBox();
            rememberUserLabel = new System.Windows.Forms.Label();
            imageSmallLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appSettingsBindingNavigator)).BeginInit();
            this.appSettingsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appSettingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumAdapterBindingSource)).BeginInit();
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
            // ListBoxAlbums
            // 
            this.ListBoxAlbums.DataSource = this.albumBindingSource;
            this.ListBoxAlbums.DisplayMember = "Name";
            this.ListBoxAlbums.FormattingEnabled = true;
            this.ListBoxAlbums.ItemHeight = 16;
            this.ListBoxAlbums.Location = new System.Drawing.Point(16, 161);
            this.ListBoxAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.ListBoxAlbums.Name = "ListBoxAlbums";
            this.ListBoxAlbums.Size = new System.Drawing.Size(159, 84);
            this.ListBoxAlbums.TabIndex = 4;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
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
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            this.TextBoxPostAnalyzerPreview.Size = new System.Drawing.Size(214, 117);
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
            this.label3.Location = new System.Drawing.Point(12, 133);
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
            // appSettingsBindingNavigator
            // 
            this.appSettingsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.appSettingsBindingNavigator.BindingSource = this.appSettingsBindingSource;
            this.appSettingsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.appSettingsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.appSettingsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.appSettingsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.appSettingsBindingNavigatorSaveItem});
            this.appSettingsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.appSettingsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.appSettingsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.appSettingsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.appSettingsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.appSettingsBindingNavigator.Name = "appSettingsBindingNavigator";
            this.appSettingsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.appSettingsBindingNavigator.Size = new System.Drawing.Size(1265, 27);
            this.appSettingsBindingNavigator.TabIndex = 23;
            this.appSettingsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // appSettingsBindingSource
            // 
            this.appSettingsBindingSource.DataSource = typeof(InfluencerToolkit.AppSettings);
            this.appSettingsBindingSource.CurrentChanged += new System.EventHandler(this.appSettingsBindingSource_CurrentChanged);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // appSettingsBindingNavigatorSaveItem
            // 
            this.appSettingsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.appSettingsBindingNavigatorSaveItem.Enabled = false;
            this.appSettingsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("appSettingsBindingNavigatorSaveItem.Image")));
            this.appSettingsBindingNavigatorSaveItem.Name = "appSettingsBindingNavigatorSaveItem";
            this.appSettingsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.appSettingsBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // rememberUserCheckBox
            // 
            this.rememberUserCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.appSettingsBindingSource, "RememberUser", true));
            this.rememberUserCheckBox.Location = new System.Drawing.Point(133, 98);
            this.rememberUserCheckBox.Name = "rememberUserCheckBox";
            this.rememberUserCheckBox.Size = new System.Drawing.Size(27, 24);
            this.rememberUserCheckBox.TabIndex = 24;
            this.rememberUserCheckBox.UseVisualStyleBackColor = true;
            // 
            // imageSmallPictureBox1
            // 
            this.imageSmallPictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageSmall", true));
            this.imageSmallPictureBox1.Location = new System.Drawing.Point(37, 324);
            this.imageSmallPictureBox1.Name = "imageSmallPictureBox1";
            this.imageSmallPictureBox1.Size = new System.Drawing.Size(112, 81);
            this.imageSmallPictureBox1.TabIndex = 26;
            this.imageSmallPictureBox1.TabStop = false;
            // 
            // albumAdapterBindingSource
            // 
            this.albumAdapterBindingSource.DataSource = typeof(InfluencerToolkit.AlbumAdapter);
            // 
            // imageSmallLabel
            // 
            imageSmallLabel.AutoSize = true;
            imageSmallLabel.Location = new System.Drawing.Point(438, 455);
            imageSmallLabel.Name = "imageSmallLabel";
            imageSmallLabel.Size = new System.Drawing.Size(88, 17);
            imageSmallLabel.TabIndex = 26;
            imageSmallLabel.Text = "Image Small:";
            // 
            // imageSmallPictureBox
            // 
            this.imageSmallPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumAdapterBindingSource, "ImageSmall", true));
            this.imageSmallPictureBox.Location = new System.Drawing.Point(532, 455);
            this.imageSmallPictureBox.Name = "imageSmallPictureBox";
            this.imageSmallPictureBox.Size = new System.Drawing.Size(120, 50);
            this.imageSmallPictureBox.TabIndex = 27;
            this.imageSmallPictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(438, 511);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 28;
            nameLabel.Text = "Name:";
            // 
            // nameListBox
            // 
            this.nameListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.albumAdapterBindingSource, "Name", true));
            this.nameListBox.DataSource = this.albumAdapterBindingSource;
            this.nameListBox.DisplayMember = "Name";
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.ItemHeight = 16;
            this.nameListBox.Location = new System.Drawing.Point(532, 511);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(120, 84);
            this.nameListBox.TabIndex = 29;
            // 
            // FormInfluencerToolkit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 702);
            this.Controls.Add(imageSmallLabel);
            this.Controls.Add(this.imageSmallPictureBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.imageSmallPictureBox1);
            this.Controls.Add(rememberUserLabel);
            this.Controls.Add(this.rememberUserCheckBox);
            this.Controls.Add(this.appSettingsBindingNavigator);
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
            this.Controls.Add(this.ListBoxAlbums);
            this.Controls.Add(this.PictureBoxProfile);
            this.Controls.Add(this.loginButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInfluencerToolkit";
            this.Text = "Influencers Toolkit";
            this.ResizeEnd += new System.EventHandler(this.FormInfluencerToolkit_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appSettingsBindingNavigator)).EndInit();
            this.appSettingsBindingNavigator.ResumeLayout(false);
            this.appSettingsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appSettingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        public System.Windows.Forms.PictureBox PictureBoxProfile;
        public System.Windows.Forms.ListBox ListBoxAlbums;
        public System.Windows.Forms.ListBox ListBoxPosts;
        public System.Windows.Forms.ListBox ListBoxFriends;
        private System.Windows.Forms.Button SortUserLikesButton;
        private System.Windows.Forms.ImageList imageList1;
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
        private System.Windows.Forms.BindingNavigator appSettingsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton appSettingsBindingNavigatorSaveItem;
        public System.Windows.Forms.BindingSource appSettingsBindingSource;
        private System.Windows.Forms.CheckBox rememberUserCheckBox;
        private System.Windows.Forms.PictureBox imageSmallPictureBox1;
        public System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.PictureBox imageSmallPictureBox;
        private System.Windows.Forms.ListBox nameListBox;
        public System.Windows.Forms.BindingSource albumAdapterBindingSource;
    }
}

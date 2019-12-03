using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public partial class FormInfluencerToolkit : Form
    {
        public AppSettings CurrentAppSettings { get; set; }

        public LoginResult LoginResult { get; set; }

        public UIPopulator UIDataPopulator { get; set; }

        public string AppID
        {
            get
            {
                return "3287703227971417";
            }
        }

        public FormInfluencerToolkit()
        {
            CurrentAppSettings = AppSettings.LoadFromFileOrInit();
            InitializeComponent();
            this.Size = CurrentAppSettings.LastWindowSize;
            this.Location = CurrentAppSettings.LastWindowLocation;
            this.checkBoxRememberUser.Checked = CurrentAppSettings.RememberUser;
            UIDataPopulator = new UIPopulator(this);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (!string.IsNullOrEmpty(CurrentAppSettings.LastAccesToken) && CurrentAppSettings.RememberUser)
            {
                LoginResult = FacebookService.Connect(CurrentAppSettings.LastAccesToken);
                UIDataPopulator.PopulateUI();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            CurrentAppSettings.SaveToFile();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var loginThread = new Thread(loginUser);
            loginThread.SetApartmentState(ApartmentState.STA);
            loginThread.Start();
            loginThread.Join();
            UIDataPopulator.PopulateUI();
        }

        private void loginUser()
        {
            string[] permissions = 
                {
                "public_profile",
                "user_birthday",
                "user_friends",
                "user_events",
                "user_posts",
                "user_likes",
                "user_photos",
                "user_posts",
                "user_gender",
                "email",
                "publish_to_groups",
                "user_age_range",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info"
                };
            if (!string.IsNullOrEmpty(CurrentAppSettings.LastAccesToken))
            {
                LoginResult = FacebookService.Connect(CurrentAppSettings.LastAccesToken);
            }
            else
            {
                LoginResult = FacebookService.Login(AppID, permissions);
            }

            CurrentAppSettings.LastAccesToken = LoginResult.AccessToken; 
        }

        public void DisplayErrorDialog(string i_Message)
        {
            MessageBox.Show(i_Message, "Error", MessageBoxButtons.OK);
        }

        private void SortUserLikesButton_Click(object sender, EventArgs e)
        {
            PostsDataAggregator postsDataAggregator = new PostsDataAggregator(this.LoginResult.LoggedInUser);
            SortedList<User, int> sortedListOfUsersByLikes = postsDataAggregator.UsersSortedByLikes();

            foreach (KeyValuePair<User, int> userLikesPair in sortedListOfUsersByLikes)
            {
                ListViewItem item = new ListViewItem(userLikesPair.Key.UserName);
                item.SubItems.Add(userLikesPair.Value.ToString());
                UserNameLikesListView.Items.Add(item);
            }
        }

        private void AnalyzePostInfluenceExpansionButton_Click(object sender, EventArgs e)
        {
            // InfluenceAnalyser influenceAnalyser = new InfluenceAnalyser(this.LoginResult.LoggedInUser);
            // int postInfluenceLevel = influenceAnalyser.GetPostInfluenceLevel();
        }

        private void AnalyzePostInfluencePreservationButton_Click(object sender, EventArgs e)
        {
            // InfluenceAnalyser influenceAnalyser = new InfluenceAnalyser(this.LoginResult.LoggedInUser);
            // int postInfluenceLevel = influenceAnalyser.GetPostInfluencePreserving();
        }

        private void UserNameLikesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            UIDataPopulator.SetPreviewUserOutOfSortedListByNames(UserNameLikesListView.SelectedItems.ToString());
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            UIDataPopulator.SetAndPreviewPostToAnalyze(listBoxPosts.SelectedItem.ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkBoxRememberUser_CheckedChanged(object sender, EventArgs e)
        {
            CurrentAppSettings.RememberUser = checkBoxRememberUser.Checked;
        }

        private void FormInfluencerToolkit_ResizeEnd(object sender, EventArgs e)
        {
            CurrentAppSettings.LastWindowSize = this.Size;
            CurrentAppSettings.LastWindowLocation = this.Location;
        }
    }
}

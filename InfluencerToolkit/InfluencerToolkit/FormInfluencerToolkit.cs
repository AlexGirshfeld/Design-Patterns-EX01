using System;
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
                return "787802105015306";
            }
        }

        public FormInfluencerToolkit()
        {
            CurrentAppSettings = AppSettings.LoadFromFileOrInit();
            InitializeComponent();
            this.Size = CurrentAppSettings.LastWindowSize;
            this.Location = CurrentAppSettings.LastWindowLocation;
            this.checkBoxRememberUser.Checked = CurrentAppSettings.RememberUser;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (!String.IsNullOrEmpty(CurrentAppSettings.LastAccesToken) && CurrentAppSettings.RememberUser)
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
            var loginThread = new Thread(loginAndInitUserUI);
            loginThread.SetApartmentState(ApartmentState.STA);
            loginThread.Start();

        }

        private void loginAndInitUserUI()
        {
            String[] permissions = {"public_profile",
                     "user_photos",
                     "user_albums",
                     "publish_actions",
                      "user_events",
                     "user_posts",
                     "user_friends",
                     "user_status"};

            UIDataPopulator = new UIPopulator(this);
            if (!String.IsNullOrEmpty(CurrentAppSettings.LastAccesToken))
            {
                LoginResult = FacebookService.Connect(CurrentAppSettings.LastAccesToken);
            }
            else
            {
                LoginResult = FacebookService.Login(AppID, permissions);
            }
            CurrentAppSettings.LastAccesToken = LoginResult.AccessToken;
            UIDataPopulator.PopulateUI();
        }
        public void DisplayErrorDialog(string i_Message)
        {
            MessageBox.Show(i_Message, "Error", MessageBoxButtons.OK);
        }

        private void SortUserLikesButton_Click(object sender, EventArgs e)
        {
            int likes = 5;
            string userName ="alex";
            SortedPerUserLikesList sortedsetRecivedFromDataAggregator = new SortedPerUserLikesList();
            foreach (Tuple<User, int> userLikesTuple in sortedsetRecivedFromDataAggregator)
            {
                ListViewItem item = new ListViewItem(userName);
                item.SubItems.Add(likes.ToString());

            }
            
        }

        private void AnalyzePostInfluenceExpansionButton_Click(object sender, EventArgs e)
        {

        }

        private void AnalyzePostInfluencePreservationButton_Click(object sender, EventArgs e)
        {

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

        private void FormInfluencerToolkit_Load(object sender, EventArgs e)
        {

        }

        private void FormInfluencerToolkit_ResizeEnd(object sender, EventArgs e)
        {
            CurrentAppSettings.LastWindowSize = this.Size;
            CurrentAppSettings.LastWindowLocation = this.Location;
        }
    }
}

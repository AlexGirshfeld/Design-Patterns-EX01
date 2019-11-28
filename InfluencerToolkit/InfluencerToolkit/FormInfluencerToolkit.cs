using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;



namespace InfluencerToolkit
{
    public partial class FormInfluencerToolkit : Form
    {
        //private FacebookObjectCollection<Post> m_RecentPosts = null;
        //public FacebookWrapper.ObjectModel.User LoggedInUser { get; set; }
        public AppSettings CurrentAppSettings { get; set; }
        public LoginResult LoginResult { get; set; }
        public UIPopulator UIDataPopulator { get; set; }
        public string AppID
        {
            get
            {
                return "588982305240916";
            }
        }



        public FormInfluencerToolkit()
        {
            CurrentAppSettings = new AppSettings();
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
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var loginThread = new Thread(loginAndInitUserUI);
            loginThread.SetApartmentState(ApartmentState.STA);
            /* startProgressBar();*/
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

        private void SortUserLikesButton_Click(object sender, EventArgs e)
        {
            int likes = 5;
            string userName;
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
            UI
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {

            UIDataPopulator.SetAndPreviewPostToAnalyze(listBoxPosts.SelectedItem.ToString());
        }

        private void FormInfluencerToolkit_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


    }
}

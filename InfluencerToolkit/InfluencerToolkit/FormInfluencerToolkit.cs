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

namespace InfluencerToolkit
{
    public partial class FormInfluencerToolkit : Form
    {
        //private FacebookObjectCollection<Post> m_RecentPosts = null;
        //public FacebookWrapper.ObjectModel.User LoggedInUser { get; set; }
        public AppSettings CurrentAppSettings { get; set; }
        public LoginResult LoginResult { get; set; }
        public UIPopulator UIDataPopulator { get; set; }

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


        /*private void initializeUserProfilePicture()
                {
                    m_ConnectedUserProfilePictureURL = getUserProfilePictureURL();
                    if (m_ConnectedUserProfilePictureURL != null)
                    {
                        m_PictureBox_ProfilePicture.LoadAsync(m_ConnectedUserProfilePictureURL);
                    }
                }*/

        private string getInfluencerAppID()
        {
            return "588982305240916";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var loginThread = new Thread(loginAndInit);
            loginThread.SetApartmentState(ApartmentState.STA);
            /* startProgressBar();*/
            loginThread.Start();

        }

        private void loginAndInitUserUI()
        {
            UIDataPopulator = new UIPopulator(this);
            if (!String.IsNullOrEmpty(CurrentAppSettings.LastAccesToken))
            {
                LoginResult = FacebookService.Connect(CurrentAppSettings.LastAccesToken);
            }
            else
            {
                LoginResult = FacebookService.Login(getInfluencerAppID(),
                     "public_profile",
                     "user_photos",
                     "user_albums",
                     "publish_actions",
                      "user_events",
                     "user_posts",
                     "user_friends",
                     "user_status");
            }
            CurrentAppSettings.LastAccesToken = LoginResult.AccessToken;
            UIDataPopulator.PopulateUI();
        }
    }
}

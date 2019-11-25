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
        private string m_ConnectedUserProfilePictureURL = null;
        //private FacebookObjectCollection<Post> m_RecentPosts = null;
        private AppSettings m_AppSettings = new AppSettings();
        private LoginResult m_LoginResult;
        FacebookWrapper.ObjectModel.User m_LoggedInUser;


        public FormInfluencerToolkit()
        {
            InitializeComponent();
            this.Size = m_AppSettings.LastWindowSize;
            this.Location = m_AppSettings.LastWindowLocation;
            this.checkBoxRememberUser.Checked = m_AppSettings.RememberUser;

        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (!String.IsNullOrEmpty(m_AppSettings.LastAccesToken) && m_AppSettings.RememberUser)
            {
                m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccesToken);
                populateUI();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

        }


        /*        private void initializeUserProfilePicture()
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

        private void populateUI()
        {
            m_LoggedInUser = m_LoginResult.LoggedInUser;
            pictureBoxProfile.ImageLocation = m_LoggedInUser.PictureNormalURL;
            this.Text = String.Format("Welcome {0} {1}", m_LoggedInUser.FirstName, m_LoggedInUser.LastName);
            fetchAlbums();
            //fetchFriends();
            //fetchPosts();
        }

        private void fetchAlbums()
        {
            foreach(FacebookWrapper.ObjectModel.Album album in m_LoggedInUser.Albums)
                {
                    listBoxAlbums.Items.Add(album.Name);    
                }
        }

        private void fetchPosts()
        {
            foreach(FacebookWrapper.ObjectModel.Post post in m_LoggedInUser.Posts)
            {
                listBoxPosts.Items.Add(post.Name);
            }
        }


        private void loginAndInit()
        {
            if (!String.IsNullOrEmpty(m_AppSettings.LastAccesToken))
            {
                m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccesToken);
            }
            else
            {
                m_LoginResult = FacebookService.Login(getInfluencerAppID(),
                     "public_profile",
                     "user_photos",
                     "user_albums",
                     "publish_actions",
                     "user_events",
            `         "user_posts",
                     "user_friends",
                     "user_status");
            }
            m_AppSettings.LastAccesToken = m_LoginResult.AccessToken;
            populateUI();
            /*var result = FacebookService.Login(
                getInfluencerAppID,
                "public_profile",
                "publish_actions",
                "user_events",
                "user_posts",
                "user_friends",
                "user_status");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                // Load data from service
                m_LoggedInUser = result.LoggedInUser;
                retrievePostScores();
                retrieveAccountActivity();
                m_PictureUrl = m_LoggedInUser.PictureNormalURL;
                m_Events = m_LoggedInUser.Events;
                m_Friends = m_LoggedInUser.Friends;
                m_Posts = m_LoggedInUser.Posts;
                m_Checkins = m_LoggedInUser.Checkins;*/
        }
            

    }
}

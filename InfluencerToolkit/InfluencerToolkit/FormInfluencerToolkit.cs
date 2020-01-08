using System;
using System.Net;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public partial class FormInfluencerToolkit : Form
    {
        private LoginResultAdapter m_LoginResult;

        public AppSettings CurrentAppSettings { get; set; }

        public CachedLoginResultAdapter LoginResult { get; set; }

        public UIPopulator UIDataPopulator { get; set; }
        

        public string AppID
        {
            get
            {
                return "3287703227971417";
            }
        }

        public UIPopulator UIPopulator
        {
            get => default;
            set
            {
            }
        }

        public FormInfluencerToolkit()
        {
            CurrentAppSettings = AppSettings.LoadFromFileOrInit();
            InitializeComponent();
            this.Size = CurrentAppSettings.LastWindowSize;
            this.Location = CurrentAppSettings.LastWindowLocation;
            appSettingsBindingSource.DataSource = CurrentAppSettings;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (!string.IsNullOrEmpty(CurrentAppSettings.LastAccesToken) && CurrentAppSettings.RememberUser)
            {
                try
                {
                    getAndAdaptLoginResultAndThenPopulateCache(FacebookService.Connect(CurrentAppSettings.LastAccesToken));
                }
                catch(Exception exception)
                {
                    DisplayErrorDialog(string.Format("Something went wrong when trying to connect to Facebook{0} Check your internet connection - meanwhile we you can work with you cached usef profile. {0} PAY ATTAENTION - the data may not be up to date!!!{0}Advanced:{1}", Environment.NewLine, exception.Message)); 
                    this.LoginResult = new CachedLoginResultAdapter();
                }
                finally
                {
                    UIDataPopulator = new UIPopulator(this);
                    UIDataPopulator.PopulateUI();
                }

            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            closingAppSequence();

        }
        private void closingAppSequence()
        {
            
            if (CurrentAppSettings.RememberUser)
            {
                CurrentAppSettings.SaveToFile();
                getLoginResultAdapterAndPopulateCache(m_LoginResult);
            }
            else
            {
                CurrentAppSettings = AppSettings.GetDefaultSettings();
                CurrentAppSettings.SaveToFile();
                getAndAdaptLoginResultAndThenPopulateCache(null);
            }
        }
        private void getAndAdaptLoginResultAndThenPopulateCache(LoginResult i_LoginResult)
        {
            this.m_LoginResult = new LoginResultAdapter(i_LoginResult);
            LoginResult = new CachedLoginResultAdapter(m_LoginResult);
        }

        private void getLoginResultAdapterAndPopulateCache(LoginResultAdapter i_LoginResultAdapter)
        {
            this.m_LoginResult = i_LoginResultAdapter;
            LoginResult = new CachedLoginResultAdapter(i_LoginResultAdapter);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var loginThread = new Thread(loginUser);
            loginThread.SetApartmentState(ApartmentState.STA);
            loginThread.Start();
            loginThread.Join();
            var UIpopulatorThread = new Thread(UIDataPopulator.PopulateUI);
            UIpopulatorThread.Start();
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
            try
            {
                if (!string.IsNullOrEmpty(CurrentAppSettings.LastAccesToken))
                {
                    getAndAdaptLoginResultAndThenPopulateCache(FacebookService.Connect(CurrentAppSettings.LastAccesToken));
                }
                else
                {
                    getAndAdaptLoginResultAndThenPopulateCache(FacebookService.Login(AppID, permissions));
                }
                CurrentAppSettings.LastAccesToken = LoginResult.AccessToken;
                UIDataPopulator = new UIPopulator(this);

            }
            catch (Exception e)
            {
                DisplayErrorDialog(string.Format("Something went wrong in the login process, please try again {0}Advanced:{1}", Environment.NewLine, e.Message));
            }
        }

        public void DisplayErrorDialog(string i_Message)
        {
            MessageBox.Show(i_Message, "Error", MessageBoxButtons.OK);
        }

        private void SortUserLikesButton_Click(object sender, EventArgs e)
        {
            UIDataPopulator.PopulateSortedUserList();
        }

        private void AnalyzePostInfluenceExpansionButton_Click(object sender, EventArgs e)
        {
            UIDataPopulator.ShowInfluenceExpansionGrade();
        }

        private void AnalyzePostInfluencePreservationButton_Click(object sender, EventArgs e)
        {
            UIDataPopulator.ShowInfluencePreservationGrade();
        }

        private void UserNameLikesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            UIDataPopulator.SetPreviewUserOutOfSortedListByNames(UserNameLikesListView.SelectedItems.ToString());
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            UIDataPopulator.SetAndPreviewPostToAnalyze((ListBoxPosts.SelectedItem as Post).Message);
        }


        private void FormInfluencerToolkit_ResizeEnd(object sender, EventArgs e)
        {
            CurrentAppSettings.LastWindowSize = this.Size;
            CurrentAppSettings.LastWindowLocation = this.Location;
        }

        private void appSettingsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void rememberUserCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

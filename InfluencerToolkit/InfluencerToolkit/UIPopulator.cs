using System;
using FacebookWrapper.ObjectModel;
namespace InfluencerToolkit
{
    public class UIPopulator
    {
        private FormInfluencerToolkit m_FormToPopulate;
        private PostInfluenceAnalyzer m_InfluenceAnalyzer;

        public UIPopulator(FormInfluencerToolkit i_Topopulate)
        {
            m_FormToPopulate = i_Topopulate;
            m_InfluenceAnalyzer = new PostInfluenceAnalyzer();
        }

        public void PopulateUI()
        {
            try
            {
                fetchAvatarAndTitle();
                fetchAlbums();
                fetchFriends();
                fetchPosts();
            }
            catch (Exception e)
            {
                m_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong in showing your details:{0}", e.Message));
            }
        }
        public void SetPreviewUserOutOfSortedListByNames(string i_UserName)
        {
            try
            {
                User userToPreview = m_FormToPopulate.LoginResult.LoggedInUser.Friends.Find(x => x.Name == i_UserName);
                if (userToPreview == null)
                {
                    m_FormToPopulate.DisplayErrorDialog("Couldn't find the friend to preview his profile image");
                }
                else
                {
                    displayPreviewProfilePicture(userToPreview);
                }
            }
            catch (Exception e)
            {
                m_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong in previewing your friends profile picture \n Advanced:{0}", e.Message));
            }

        }

        public void SetAndPreviewPostToAnalyze(string i_PostMessage)
        {
            try
            {
                Post postToPreviewAndAnalyze = m_InfluenceAnalyzer.FetchSetCurrentPostToAnalyze(i_PostMessage, m_FormToPopulate.LoginResult.LoggedInUser);
                if (postToPreviewAndAnalyze == null)
                {
                    m_FormToPopulate.DisplayErrorDialog("Couldn't find the post to preview");
                }
                else
                {
                    getPostToAnalyse = postToPreviewAndAnalyze;
                    displayPostToPreview(postToPreviewAndAnalyze);
                }
            }
            catch (Exception e)
            {
                m_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong in previewing your post\n Advanced:{0}", e.Message));
            }
        }

        public Post getPostToAnalyse { get; private set; }

        private void displayPostToPreview(Post i_Post)
        {
            try
            {
                m_FormToPopulate.textBoxPostAnalyzerPreview.Text = string.Format(@"POSTED AT:{0}{1}CONTENT:{2}",
                                    i_Post?.CreatedTime?.ToString(),
                                    System.Environment.NewLine,
                                    i_Post?.Message);
            }
            catch(Exception e)
            {
                m_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong in displaying the preview for the selected post.\n Advanced:{0}",e.Message));
            }
        }

        private void fetchAlbums()
        {
            foreach (Album album in m_FormToPopulate.LoginResult.LoggedInUser.Albums)
            {
                m_FormToPopulate.listBoxAlbums.Items.Add(album.Name);
            }
        }

        private void fetchPosts()
        {
            try
            {
                foreach (Post post in m_FormToPopulate.LoginResult.LoggedInUser.Posts)
                {
                    if (post.Message != null)
                    { 
                        m_FormToPopulate.listBoxPosts.Items.Add(post.Message);
                        
                    }
                }
            }
            catch(ArgumentNullException nullException)
            {
                m_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong in showing your posts \n Advanced:{0}", nullException.Message));
            }

        }

        private void fetchFriends()
        {
            foreach(User friend in m_FormToPopulate.LoginResult.LoggedInUser.Friends)
            {
                m_FormToPopulate.listBoxPosts.Items.Add(friend.Name);
            }
        }

        private void fetchAvatarAndTitle()
        {
            m_FormToPopulate.pictureBoxProfile.ImageLocation = m_FormToPopulate.LoginResult.LoggedInUser.PictureNormalURL;
            m_FormToPopulate.pictureBoxProfile.LoadAsync(m_FormToPopulate.pictureBoxProfile.ImageLocation);
            m_FormToPopulate.Text = String.Format("Welcome {0} {1}", m_FormToPopulate.LoginResult.LoggedInUser.FirstName, m_FormToPopulate.LoginResult.LoggedInUser.LastName);
        }

        private void displayPreviewProfilePicture(User i_UserToDisplay)
        {
            m_FormToPopulate.pictureBoxUserPreview.ImageLocation = i_UserToDisplay.PictureNormalURL;
        }

    }
}

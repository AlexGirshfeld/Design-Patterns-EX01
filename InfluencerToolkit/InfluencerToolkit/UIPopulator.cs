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
    public class UIPopulator
    {
        private FormInfluencerToolkit m_FormToPopulate;
        private User SelectedUserToDisplayPreviewPicture;
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
        public void SetPreviewUserOutOfSortedListByNames(string i_Username)
        {

        }

        public void SetAndPreviewPostToAnalyze(string i_postName)
        {
            Post postToPreviewAndAnalyze = m_InfluenceAnalyzer.FetchSetCurrentPostToAnalyzeByPostName(i_postName, m_FormToPopulate.LoginResult.LoggedInUser);
            if (postToPreviewAndAnalyze == null)
            {
                m_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong in previewing the post:{0}", e.Message));
            }
            else
            {
                displayPostToPreview(postToPreviewAndAnalyze);
            }
        }

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
                m_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong in displaying the preview for the selected post:{0}",e.Message));
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
            foreach (Post post in m_FormToPopulate.LoginResult.LoggedInUser.Posts)
            {
                m_FormToPopulate.listBoxPosts.Items.Add(post.Name);
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

    }
}

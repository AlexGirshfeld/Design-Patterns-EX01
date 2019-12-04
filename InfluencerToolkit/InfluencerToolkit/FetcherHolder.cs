using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public class FetcherHolder
    {
        private readonly FormInfluencerToolkit m_FormToPopulate;

        public Post CurrentPostToAnalyze { get; set; }

        public FetcherHolder(FormInfluencerToolkit i_Form)
        {
            m_FormToPopulate = i_Form;
            CurrentPostToAnalyze = null;  
        }

        public Post FetchSetCurrentPostToAnalyze(string i_PostMessage, User i_User)
        {
            Post postToReturn = i_User.Posts.Find(x => x.Message == i_PostMessage);
            CurrentPostToAnalyze = postToReturn;
            return postToReturn;
        }

        public void FetchAlbums()
        {
            foreach (Album album in m_FormToPopulate.LoginResult.LoggedInUser.Albums)
            {
                m_FormToPopulate.ListBoxAlbums.Items.Add(album.Name);
            }
        }

       public void FetchPosts()
        {
            try
            {
                foreach (Post post in m_FormToPopulate.LoginResult.LoggedInUser.Posts)
                {
                    if (post.Message != null)
                    {
                        m_FormToPopulate.ListBoxPosts.Items.Add(post.Message);
                    }
                }
            }
            catch (ArgumentNullException nullException)
            {
                m_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong in showing your posts \n Advanced:{0}", nullException.Message));
            }
        }

        public void FetchFriends()
        {
            foreach (User friend in m_FormToPopulate.LoginResult.LoggedInUser.Friends)
            {
                m_FormToPopulate.ListBoxPosts.Items.Add(friend.Name);
            }
        }

        public void FetchAvatarAndTitle()
        {
            m_FormToPopulate.PictureBoxProfile.ImageLocation = m_FormToPopulate.LoginResult.LoggedInUser.PictureNormalURL;
            m_FormToPopulate.PictureBoxProfile.LoadAsync(m_FormToPopulate.PictureBoxProfile.ImageLocation);
            m_FormToPopulate.Text = string.Format("Welcome {0} {1}", m_FormToPopulate.LoginResult.LoggedInUser.FirstName, m_FormToPopulate.LoginResult.LoggedInUser.LastName);
        }

        public void DisplayPreviewProfilePicture(User i_UserToDisplay)
        {
            m_FormToPopulate.PictureBoxUserPreview.ImageLocation = i_UserToDisplay.PictureNormalURL;
        }
    }
}

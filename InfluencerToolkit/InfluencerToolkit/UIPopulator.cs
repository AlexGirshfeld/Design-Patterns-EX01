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
    public class UIPopulator
    {
        FormInfluencerToolkit m_FormToPopulate;

        public UIPopulator(FormInfluencerToolkit i_Topopulate)
        {
            m_FormToPopulate = i_Topopulate;
        }

      public void PopulateUI()
        {
            fetchAvatarAndTitle();
            fetchAlbums();
            fetchFriends();
            fetchPosts();
        }

        private void fetchAlbums()
        {
            foreach (FacebookWrapper.ObjectModel.Album album in m_FormToPopulate.LoginResult.LoggedInUser.Albums)
            {
                m_FormToPopulate.listBoxAlbums.Items.Add(album.Name);
            }
        }

        private void fetchPosts()
        {
            foreach (FacebookWrapper.ObjectModel.Post post in m_FormToPopulate.LoginResult.LoggedInUser.Posts)
            {
                m_FormToPopulate.listBoxPosts.Items.Add(post.Name);
            }
        }

        private void fetchFriends()
        {
            foreach(FacebookWrapper.ObjectModel.User friend in m_FormToPopulate.LoginResult.LoggedInUser.Friends)
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

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
        private readonly FormInfluencerToolkit r_FormToPopulate;

        public FetcherHolder(FormInfluencerToolkit i_Form)
        {
            r_FormToPopulate = i_Form;
        }

        public Post FetchSetCurrentPostToAnalyze(string i_PostMessage, User i_User)
        {
            Post postToReturn = i_User.Posts.Find(x => x.Message == i_PostMessage);
            return postToReturn;
        }

        public void FetchAlbums()
        {
            r_FormToPopulate.ListBoxAlbums.Items.Clear();
            foreach (Album album in r_FormToPopulate.LoginResult.LoggedInUser.Albums)
            {
                r_FormToPopulate.ListBoxAlbums.Items.Add(album.Name);
            }
        }

       public void FetchPosts()
        {
            r_FormToPopulate.ListBoxPosts.Items.Clear();
            try
            {
                foreach (Post post in r_FormToPopulate.LoginResult.LoggedInUser.Posts)
                {
                    if (post.Message != null)
                    {
                        r_FormToPopulate.ListBoxPosts.Items.Add(post.Message);
                    }
                }
            }
            catch (ArgumentNullException nullException)
            {
                r_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong in showing your posts \n Advanced:{0}", nullException.Message));
            }
        }

        public void FetchFriends()
        {
            r_FormToPopulate.ListBoxPosts.Items.Clear();
            foreach (User friend in r_FormToPopulate.LoginResult.LoggedInUser.Friends)
            {
                r_FormToPopulate.ListBoxPosts.Items.Add(friend.Name);
            }
        }

        public void FetchAvatarAndTitle()
        {
            r_FormToPopulate.PictureBoxProfile.ImageLocation = r_FormToPopulate.LoginResult.LoggedInUser.PictureNormalURL;
            r_FormToPopulate.PictureBoxProfile.LoadAsync(r_FormToPopulate.PictureBoxProfile.ImageLocation);
            r_FormToPopulate.Text = string.Format("Welcome {0} {1}", r_FormToPopulate.LoginResult.LoggedInUser.FirstName, r_FormToPopulate.LoginResult.LoggedInUser.LastName);
        }

        public void DisplayPreviewProfilePicture(User i_UserToDisplay)
        {
            r_FormToPopulate.PictureBoxUserPreview.ImageLocation = i_UserToDisplay.PictureNormalURL;
        }
    }
}

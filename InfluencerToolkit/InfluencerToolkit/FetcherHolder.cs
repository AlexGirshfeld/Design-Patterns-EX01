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

        public PostAdapter FetchSetCurrentPostToAnalyze(string i_PostMessage, UserAdapter i_User)
        {
            PostAdapter postToReturn = i_User.Posts.Find(x => x.Message == i_PostMessage);
            return postToReturn;
        }



        public void FetchAlbums()
        {
            //r_FormToPopulate.albumBindingSource.DataSource = r_FormToPopulate.LoginResult.LoggedInUser.Albums;
            // r_FormToPopulate.albumAdapterBindingSource.Invoke(new Action(() => r_FormToPopulate.albumAdapterBindingSource.DataSource = r_FormToPopulate.LoginResult.LoggedInUser.Albums));
            r_FormToPopulate.albumAdapterBindingSource.DataSource = r_FormToPopulate.LoginResult.LoggedInUser.Albums;
            //r_FormToPopulate.ListBoxPosts.Invoke(new Action(() => r_FormToPopulate.albumAdapterBindingSource.DataSource = r_FormToPopulate.LoginResult.LoggedInUser.Albums));
        }
        public void FetchPosts()
        {
            r_FormToPopulate.ListBoxPosts.Invoke(new Action(() => r_FormToPopulate.ListBoxPosts.DisplayMember = "Message"));
            r_FormToPopulate.ListBoxPosts.Invoke(new Action(() => r_FormToPopulate.ListBoxPosts.Items.Clear()));
            try
            {
                foreach (PostAdapter post in r_FormToPopulate.LoginResult.LoggedInUser.Posts)
                {
                    if (post.Message != null)
                    {
                        r_FormToPopulate.ListBoxPosts.Invoke(new Action(() => r_FormToPopulate.ListBoxPosts.Items.Add(post)));
                    }
                } 
            }
            catch (Exception Exception)
            {
                r_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong in showing your posts \n Advanced:{0}", Exception.Message));
            }
        }

        public void FetchFriends()
        {
            r_FormToPopulate.ListBoxFriends.Invoke(new Action(() => r_FormToPopulate.ListBoxFriends.DisplayMember = "Name"));
            r_FormToPopulate.ListBoxFriends.Invoke(new Action(() => r_FormToPopulate.ListBoxFriends.Items.Clear()));
            try
            {
                foreach (UserAdapter friend in r_FormToPopulate.LoginResult.LoggedInUser.Friends)
                {
                    r_FormToPopulate.ListBoxFriends.Invoke(new Action( () => r_FormToPopulate.ListBoxFriends.Items.Add(friend)));
                }
            }
            catch (Exception Exception)
            {
                r_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong in showing your friends \n Advanced:{0}", Exception.Message));
            }
        }

        public void FetchAvatarAndTitle()
        {
            //r_FormToPopulate.PictureBoxProfile.ImageLocation = r_FormToPopulate.LoginResult.LoggedInUser.PictureNormalURL;
            //r_FormToPopulate.PictureBoxProfile.Image = r_FormToPopulate.LoginResult.LoggedInUser.ImageNormal;
            //r_FormToPopulate.PictureBoxProfile.LoadAsync(r_FormToPopulate.PictureBoxProfile.ImageLocation);
            r_FormToPopulate.PictureBoxProfile.Invoke(new Action(()=> r_FormToPopulate.PictureBoxProfile.Image = r_FormToPopulate.LoginResult.LoggedInUser.ImageNormal));
            r_FormToPopulate.Invoke(new Action( () => r_FormToPopulate.Text = string.Format("Welcome {0} {1}", r_FormToPopulate.LoginResult.LoggedInUser.FirstName, r_FormToPopulate.LoginResult.LoggedInUser.LastName)));
        }

        public void DisplayPreviewProfilePicture(UserAdapter i_UserToDisplay)
        {
            r_FormToPopulate.PictureBoxUserPreview.Image = i_UserToDisplay.ImageNormal;
        }
    }
}

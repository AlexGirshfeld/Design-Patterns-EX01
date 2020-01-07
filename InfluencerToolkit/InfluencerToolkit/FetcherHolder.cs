﻿using System;
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

        public void FetchAlbumsDeprecated()
        {
            r_FormToPopulate.ListBoxAlbums.Invoke(new Action( () => r_FormToPopulate.ListBoxAlbums.DisplayMember = "Name"));
            r_FormToPopulate.ListBoxAlbums.Invoke(new Action( () => r_FormToPopulate.ListBoxAlbums.Items.Clear()));
            foreach (Album album in r_FormToPopulate.LoginResult.LoggedInUser.Albums)
            {
                r_FormToPopulate.ListBoxAlbums.Invoke(new Action(() => r_FormToPopulate.ListBoxAlbums.Items.Add(album)));
            }
        }

        public void FetchAlbums()
        {
            r_FormToPopulate.albumBindingSource.DataSource = r_FormToPopulate.LoginResult.LoggedInUser.Albums;
        }
        public void FetchPosts()
        {
            r_FormToPopulate.ListBoxPosts.Invoke(new Action(() => r_FormToPopulate.ListBoxPosts.DisplayMember = "Message"));
            r_FormToPopulate.ListBoxPosts.Invoke(new Action(() => r_FormToPopulate.ListBoxPosts.Items.Clear()));
            try
            {
                foreach (Post post in r_FormToPopulate.LoginResult.LoggedInUser.Posts)
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
                foreach (User friend in r_FormToPopulate.LoginResult.LoggedInUser.Friends)
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
            r_FormToPopulate.PictureBoxProfile.ImageLocation = r_FormToPopulate.LoginResult.LoggedInUser.PictureNormalURL;
            r_FormToPopulate.PictureBoxProfile.LoadAsync(r_FormToPopulate.PictureBoxProfile.ImageLocation);
            r_FormToPopulate.Invoke(new Action( () => r_FormToPopulate.Text = string.Format("Welcome {0} {1}", r_FormToPopulate.LoginResult.LoggedInUser.FirstName, r_FormToPopulate.LoginResult.LoggedInUser.LastName)));
        }

        public void DisplayPreviewProfilePicture(User i_UserToDisplay)
        {
            r_FormToPopulate.PictureBoxUserPreview.ImageLocation = i_UserToDisplay.PictureNormalURL;
        }
    }
}

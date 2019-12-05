﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public class UIPopulator
    {
        private readonly FormInfluencerToolkit r_FormToPopulate;
        private FetcherHolder m_FetcherHolder;
        private InfluenceAnalyser m_influenceAnalyser;

        public Post PostToAnalyse { get; private set; }

        public UIPopulator(FormInfluencerToolkit i_Topopulate)
        {
            r_FormToPopulate = i_Topopulate;
            m_FetcherHolder = new FetcherHolder(this.r_FormToPopulate);
            m_influenceAnalyser = null; 
        }

        public void PopulateUI()
        {
            try
            {
                m_FetcherHolder.FetchAvatarAndTitle();
                m_FetcherHolder.FetchAlbums();
                m_FetcherHolder.FetchFriends();
                m_FetcherHolder.FetchPosts();
            }
            catch (Exception e)
            {
                r_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong in showing your details:{0} Advanced:{1}", Environment.NewLine, e.Message));
            }
        }

        public void SetPreviewUserOutOfSortedListByNames(string i_UserName)
        {
            try
            {
                User userToPreview = r_FormToPopulate.LoginResult.LoggedInUser.Friends.Find(x => x.Name == i_UserName);
                if (userToPreview == null)
                {
                    r_FormToPopulate.DisplayErrorDialog("Couldn't find the friend to preview his profile image");
                }
                else
                {
                    m_FetcherHolder.DisplayPreviewProfilePicture(userToPreview);
                }
            }
            catch (Exception e)
            {
                r_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong calculating the influence grade grade {0} Advanced:{1}", Environment.NewLine, e.Message));
            }
        }
     
        public void PopulateSortedUserList()
        {
            PostsDataAggregator postsDataAggregator = new PostsDataAggregator(this.r_FormToPopulate.LoginResult.LoggedInUser);
            SortedList<User, int> sortedListOfUsersByLikes = postsDataAggregator.UsersSortedByLikes();
            foreach (KeyValuePair<User, int> userLikesPair in sortedListOfUsersByLikes)
            {
                ListViewItem item = new ListViewItem(userLikesPair.Key.UserName);
                item.SubItems.Add(userLikesPair.Value.ToString());
                this.r_FormToPopulate.UserNameLikesListView.Items.Add(item);
            }
        }

        public void ShowInfluenceExpansionGrade()
        {
            try
            {
                m_influenceAnalyser = new InfluenceAnalyser(this.r_FormToPopulate.LoginResult.LoggedInUser);
                int postInfluenceLevel = m_influenceAnalyser.GetPostInfluenceLevel(PostToAnalyse);
                r_FormToPopulate.GradeTextBox.Text = postInfluenceLevel.ToString();
            }
            catch (Exception e)
            {
                r_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong calculating the influence grade grade {0} Advanced:{1}", Environment.NewLine, e.Message));
            }
        }

        public void ShowInfluencePreservationGrade()
        {
            try
            {
                m_influenceAnalyser = new InfluenceAnalyser(this.r_FormToPopulate.LoginResult.LoggedInUser);
                int postInfluenceLevel = m_influenceAnalyser.GetPostInfluencePreserving(PostToAnalyse);
                r_FormToPopulate.GradeTextBox.Text = postInfluenceLevel.ToString();
            }
            catch (Exception e)
            {
                r_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong in previewing your friends profile picture {1} Advanced:{0}", e.Message, Environment.NewLine));
            }
        }

        public void SetAndPreviewPostToAnalyze(string i_PostMessage)
        {
            try
            {
                Post postToPreviewAndAnalyze = m_FetcherHolder.FetchSetCurrentPostToAnalyze(i_PostMessage, r_FormToPopulate.LoginResult.LoggedInUser);
                if (postToPreviewAndAnalyze == null)
                {
                    r_FormToPopulate.DisplayErrorDialog("Couldn't find the post to preview");
                }
                else
                {
                    PostToAnalyse = postToPreviewAndAnalyze;
                    displayPostToPreview(postToPreviewAndAnalyze);
                }
            }
            catch (Exception e)
            {
                r_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong in previewing your post{1} Advanced:{0}", e.Message, Environment.NewLine));
            }
        }

        private void displayPostToPreview(Post i_Post)
        {
            try
            {
                r_FormToPopulate.TextBoxPostAnalyzerPreview.Text = string.Format(
                                    @"POSTED AT:{0}{1}CONTENT:{2}",
                                    i_Post?.CreatedTime?.ToString(),
                                    System.Environment.NewLine,
                                    i_Post?.Message);
            }
            catch(Exception e)
            {
                r_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong in displaying the preview for the selected post.{1}Advanced:{0}", e.Message, Environment.NewLine));
            }
        }
    }
}

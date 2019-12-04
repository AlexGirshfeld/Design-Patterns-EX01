using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public class UIPopulator
    {
        private FormInfluencerToolkit m_FormToPopulate;
        private FetcherHolder m_FetcherHolder;

        public Post getPostToAnalyse { get; private set; }

        public UIPopulator(FormInfluencerToolkit i_Topopulate)
        {
            m_FormToPopulate = i_Topopulate;
            m_FetcherHolder = new FetcherHolder(this.m_FormToPopulate);
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
                    m_FetcherHolder.DisplayPreviewProfilePicture(userToPreview);
                }
            }
            catch (Exception e)
            {
                m_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong in previewing your friends profile picture \n Advanced:{0}", e.Message));
            }
        }

        public void PopulateSortedUserList()
        {
            PostsDataAggregator postsDataAggregator = new PostsDataAggregator(this.m_FormToPopulate.LoginResult.LoggedInUser);
            SortedList<User, int> sortedListOfUsersByLikes = postsDataAggregator.UsersSortedByLikes();
            foreach (KeyValuePair<User, int> userLikesPair in sortedListOfUsersByLikes)
            {
                ListViewItem item = new ListViewItem(userLikesPair.Key.UserName);
                item.SubItems.Add(userLikesPair.Value.ToString());
                this.m_FormToPopulate.UserNameLikesListView.Items.Add(item);
            }
        }

        public void ShowInfluenceExpansionGrade()
        {
            InfluenceAnalyser influenceAnalyser = new InfluenceAnalyser(this.m_FormToPopulate.LoginResult.LoggedInUser);
            int postInfluenceLevel = influenceAnalyser.GetPostInfluenceLevel(getPostToAnalyse);
            this.m_FormToPopulate.GradeTextBox.Text = postInfluenceLevel.ToString();
        }

        public void ShowInfluencePreservationGrade()
        {
                InfluenceAnalyser influenceAnalyser = new InfluenceAnalyser(this.m_FormToPopulate.LoginResult.LoggedInUser);
                int postInfluenceLevel = influenceAnalyser.GetPostInfluencePreserving(getPostToAnalyse);
                m_FormToPopulate.GradeTextBox.Text = postInfluenceLevel.ToString();
        }

        public void SetAndPreviewPostToAnalyze(string i_PostMessage)
        {
            try
            {
                Post postToPreviewAndAnalyze = m_FetcherHolder.FetchSetCurrentPostToAnalyze(i_PostMessage, m_FormToPopulate.LoginResult.LoggedInUser);
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

        private void displayPostToPreview(Post i_Post)
        {
            try
            {
                m_FormToPopulate.TextBoxPostAnalyzerPreview.Text = string.Format(
                                    @"POSTED AT:{0}{1}CONTENT:{2}",
                                    i_Post?.CreatedTime?.ToString(),
                                    System.Environment.NewLine,
                                    i_Post?.Message);
            }
            catch(Exception e)
            {
                m_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong in displaying the preview for the selected post.\n Advanced:{0}", e.Message));
            }
        }
    }
}

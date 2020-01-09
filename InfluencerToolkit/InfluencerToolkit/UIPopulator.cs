using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public class UIPopulator
    {
        private readonly FormInfluencerToolkit r_FormToPopulate;
        private FetcherHolder m_FetcherHolder;
        private InfluenceAnalyserFacade m_InfluenceAnalyserFacade;

        public PostAdapter PostToAnalyse { get; internal set; }

        public UIPopulator(FormInfluencerToolkit i_Topopulate)
        {
            r_FormToPopulate = i_Topopulate;
            m_FetcherHolder = new FetcherHolder(this.r_FormToPopulate);
            m_InfluenceAnalyserFacade = new InfluenceAnalyserFacade(this.r_FormToPopulate.LoginResult.LoggedInUser);
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
                UserAdapter userToPreview = r_FormToPopulate.LoginResult.LoggedInUser.Friends.Find(x => x.Name == i_UserName);
                if (userToPreview == null)
                {
                    r_FormToPopulate.DisplayErrorDialog("Couldn't find the friend to preview his profile image");
                }
                else
                {
                    m_FetcherHolder.FetchAvatarAndTitle();
                }
            }
            catch (Exception e)
            {
                r_FormToPopulate.DisplayErrorDialog(string.Format("Something went wrong calculating the influence grade grade {0} Advanced:{1}", Environment.NewLine, e.Message));
            }
        }
     
        public void PopulateSortedUserList()
        {
            SortedList<UserAdapter, int> sortedListOfUsersByLikes = this.m_InfluenceAnalyserFacade.UsersSortedByLikes();
            foreach (KeyValuePair<UserAdapter, int> userLikesPair in sortedListOfUsersByLikes)
            {
                ListViewItem item = new ListViewItem(userLikesPair.Key.FirstName);
                item.SubItems.Add(userLikesPair.Value.ToString());
                this.r_FormToPopulate.UserNameLikesListView.Items.Add(item);
            }
        }

        public void ShowInfluenceExpansionGrade()
        {
            try
            {
                int postInfluenceLevel = m_InfluenceAnalyserFacade.GetPostInfluenceLevel(PostToAnalyse);
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
                int postInfluenceLevel = m_InfluenceAnalyserFacade.GetPostInfluencePreserving(PostToAnalyse);
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
                PostAdapter postToPreviewAndAnalyze = m_FetcherHolder.FetchSetCurrentPostToAnalyze(i_PostMessage, r_FormToPopulate.LoginResult.LoggedInUser);
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

        public void displayPostToPreview(PostAdapter i_Post)
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

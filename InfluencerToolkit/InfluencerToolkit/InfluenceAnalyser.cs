using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public class InfluenceAnalyser
    {
        private User m_user;
        private SortedList<User, int> m_UsersSortedByLikesCount;

        public InfluenceAnalyser(User i_user)
        {
            this.m_user = i_user;
            this.m_UsersSortedByLikesCount = new PostsDataAggregator(this.m_user).UsersSortedByLikes();
        }

        public int AnalysePostInfluenceLevel(Post i_post)
        {
            int postInfluenceLevel = 0;
            if (this.m_user.Posts.Contains(i_post))
            {

            } else
            {
                throw new Exception("The post you requested was not found!");
            }
            return postInfluenceLevel;
        }

    }
}

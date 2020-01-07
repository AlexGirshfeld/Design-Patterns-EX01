using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public class InfluenceAnalyserFacade
    {
        private User m_User;
        private PostsDataAggregator m_PostsDataAggregator;
        private InfluenceAnalyser m_InfluenceAnalyser;

        public InfluenceAnalyserFacade(User i_User) 
        {
            this.m_User = i_User;
            this.m_InfluenceAnalyser = new InfluenceAnalyser(this.m_User);
            this.m_PostsDataAggregator = new PostsDataAggregator(this.m_User);
        }

        public int GetPostInfluenceLevel(Post i_Post)
        {
            return this.m_InfluenceAnalyser.GetPostInfluenceLevel(i_Post);
        }

        public int GetPostInfluencePreserving(Post i_Post)
        {
            return this.m_InfluenceAnalyser.GetPostInfluencePreserving(i_Post);
        }

        public SortedList<User, int> UsersSortedByLikes()
        {
            return this.m_PostsDataAggregator.UsersSortedByLikes;
        }
    }
}

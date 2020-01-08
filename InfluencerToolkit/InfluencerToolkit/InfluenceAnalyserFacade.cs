using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public class InfluenceAnalyserFacade
    {
        private UserAdapter m_UserAdapter;
        private PostsDataAggregator m_PostsDataAggregator;
        private InfluenceAnalyser m_InfluenceAnalyser;

        public InfluenceAnalyserFacade(UserAdapter i_UserAdapter) 
        {
            this.m_UserAdapter = i_UserAdapter;
            this.m_InfluenceAnalyser = new InfluenceAnalyser(this.m_UserAdapter);
            this.m_PostsDataAggregator = new PostsDataAggregator(this.m_UserAdapter);
        }

        public int GetPostInfluenceLevel(PostAdapter i_Post)
        {
            return this.m_InfluenceAnalyser.GetPostInfluenceLevel(i_Post);
        }

        public int GetPostInfluencePreserving(PostAdapter i_Post)
        {
            return this.m_InfluenceAnalyser.GetPostInfluencePreserving(i_Post);
        }

        public SortedList<UserAdapter, int> UsersSortedByLikes()
        {
            return this.m_PostsDataAggregator.UsersSortedByLikes;
        }
    }
}

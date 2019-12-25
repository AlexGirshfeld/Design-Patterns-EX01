using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public class InfluenceAnalyserFacade
    {
        private User m_user;
        private InfluenceAnalyser m_influenceAnalyser;
        internal PostsDataAggregator m_postsDataAggregator;

        public InfluenceAnalyserFacade(User i_user) 
        {
            this.m_user = i_user;
            this.m_influenceAnalyser = new InfluenceAnalyser(this.m_user);
            this.m_postsDataAggregator = new PostsDataAggregator(this.m_user);
        }

        public int GetPostInfluenceLevel(Post i_Post)
        {
            int postInfluenceLevel = 0;
            if (this.m_user.Posts.Contains(i_Post))
            {
                postInfluenceLevel = this.m_influenceAnalyser.AnalysePostInfluenceLevel(i_Post);
            }
            else
            {
                throw new Exception("The post you requested was not found!");
            }

            return postInfluenceLevel;
        }

        public int GetPostInfluencePreserving(Post i_Post)
        {
            return (int)(this.m_influenceAnalyser.quantitiveInfluencePreservationFactor(i_Post) * 70) + (int)(this.m_influenceAnalyser.qualityInfluencePreservationFactor(i_Post) * 30);
        }

        public int AvarageCountOfLikesPerPost
        {
            get
            {
                this.m_postsDataAggregator.AggregateUserLikes();
                return this.m_postsDataAggregator.m_AvargeCountOfLikesPerPost;
            }
        }

        public int AvarageCountOfLikesPerFriend
        {
            get
            {
                this.m_postsDataAggregator.m_AvarageNumberOfLikesGivenToMyPostsPerUser = this.m_postsDataAggregator.calculateAvarageNumberOfLikesGivenPerFriend(this.m_postsDataAggregator.AggregateUserLikes());
                return this.m_postsDataAggregator.m_AvarageNumberOfLikesGivenToMyPostsPerUser;
            }
        }

        public int TotalLikes
        {
            get
            {
                this.m_postsDataAggregator.AggregateUserLikes();
                return this.m_postsDataAggregator.m_TotalNumberOfLikesRecievedInAllPosts;
            }
        }

        public SortedList<User, int> UsersSortedByLikes()
        {
            return this.m_postsDataAggregator.SortUsersByLikesCount();
        }
    }
}

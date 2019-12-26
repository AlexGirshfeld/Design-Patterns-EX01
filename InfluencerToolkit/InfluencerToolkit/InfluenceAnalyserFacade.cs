﻿using System;
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
            int postInfluenceLevel = 0;
            if (this.m_User.Posts.Contains(i_Post))
            {
                postInfluenceLevel = this.m_InfluenceAnalyser.AnalysePostInfluenceLevel(i_Post);
            }
            else
            {
                throw new Exception("The post you requested was not found!");
            }

            return postInfluenceLevel;
        }

        public int GetPostInfluencePreserving(Post i_Post)
        {
            return (int)(this.m_InfluenceAnalyser.quantitiveInfluencePreservationFactor(i_Post) * 70) + (int)(this.m_InfluenceAnalyser.qualityInfluencePreservationFactor(i_Post) * 30);
        }

        public int AvarageCountOfLikesPerPost
        {
            get
            {
                this.m_PostsDataAggregator.AggregateUserLikes();
                return this.m_PostsDataAggregator.AvargeCountOfLikesPerPost;
            }
        }

        public int AvarageCountOfLikesPerFriend
        {
            get
            {
                this.m_PostsDataAggregator.AvarageNumberOfLikesGivenToMyPostsPerUser = this.m_PostsDataAggregator.CalculateAvarageNumberOfLikesGivenPerFriend(m_PostsDataAggregator.AggregateUserLikes());
                return this.m_PostsDataAggregator.AvarageNumberOfLikesGivenToMyPostsPerUser;
            }
        }

        public int TotalLikes
        {
            get
            {
                this.m_PostsDataAggregator.AggregateUserLikes();
                return this.m_PostsDataAggregator.TotalNumberOfLikesRecievedInAllPosts;
            }
        }

        public SortedList<User, int> UsersSortedByLikes()
        {
            return this.m_PostsDataAggregator.SortUsersByLikesCount();
        }
    }
}

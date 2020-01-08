using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public class InfluenceAnalyser
    {
        private UserAdapter m_User;
        private PostsDataAggregator m_PostsDataAggregator;
        private SortedList<UserAdapter, int> m_UsersSortedByLikes;
    
        public InfluenceAnalyser(UserAdapter i_User)
        {
            this.m_User = i_User;
            this.m_PostsDataAggregator = new PostsDataAggregator(this.m_User);
            this.m_UsersSortedByLikes = this.m_PostsDataAggregator.UsersSortedByLikes;
        }

        internal int GetPostInfluenceLevel(PostAdapter i_Post)
        {
            int postInfluenceLevel = 0;
            if (this.m_User.Posts.Contains(i_Post))
            {
                postInfluenceLevel = AnalysePostInfluenceLevel(i_Post);
            }
            else
            {
                throw new Exception("The post you requested was not found!");
            }

            return postInfluenceLevel;
        }

        internal int GetPostInfluencePreserving(PostAdapter i_Post)
        {
            return (int)(quantitiveInfluencePreservationFactor(i_Post) * 70) + (int)(qualityInfluencePreservationFactor(i_Post) * 30);
        }

        private int AnalysePostInfluenceLevel(PostAdapter i_Post)
        {
            int postInfluenceLevel = 0;

            // If the post got more likes than average, it gets 30% of the grade 
            if (i_Post.LikedBy.Count > this.m_PostsDataAggregator.AvarageCountOfLikesPerPost)
            {
                postInfluenceLevel += 30;
            }

            int previouslyInfluencedUsersCount = 0;
            foreach (KeyValuePair<UserAdapter, int> userLikesPair in this.m_UsersSortedByLikes)
            {
                if(i_Post.LikedBy.Contains(userLikesPair.Key))
                {
                    previouslyInfluencedUsersCount++;
                }
            }

            // The more people who liked the post but never liked user's content before, the more credit the post gets, up to 50%
            if (previouslyInfluencedUsersCount > 0)
            {
                postInfluenceLevel += ((i_Post.LikedBy.Count - previouslyInfluencedUsersCount) / i_Post.LikedBy.Count) * 50;
            } 
            else
            {
                postInfluenceLevel += 50;
            }

            // The more people who already liked user's content liked it, the more credit it gets, up to 20%
            if (i_Post.LikedBy.Count == 0)
            {
                postInfluenceLevel += 0;
            }
            else
            {
                postInfluenceLevel += (previouslyInfluencedUsersCount / i_Post.LikedBy.Count) * 20;
            }
            
            return postInfluenceLevel;
        }

        private float qualityInfluencePreservationFactor(PostAdapter i_Post)
        {
            float postInfluencePreservation = 0;
            foreach (KeyValuePair<UserAdapter, int> userLikesPair in m_UsersSortedByLikes)
            {
                if (i_Post.LikedBy.Contains(userLikesPair.Key))
                {
                    postInfluencePreservation += userLikesPair.Value / this.m_PostsDataAggregator.TotalNumberOfLikesRecievedInAllPosts;
                }
            }

            return postInfluencePreservation;
        }
        
        private float quantitiveInfluencePreservationFactor(PostAdapter i_Post)
        {
            float m_quantitiveInfluencePreservationFactor = 0f;
            if (m_PostsDataAggregator.AvarageCountOfLikesPerPost != 0)
            {
                m_quantitiveInfluencePreservationFactor = i_Post.LikedBy.Count / m_PostsDataAggregator.AvarageCountOfLikesPerPost;
                if (m_quantitiveInfluencePreservationFactor > 1)
                {
                    m_quantitiveInfluencePreservationFactor = 1f;
                }
            }

            return m_quantitiveInfluencePreservationFactor;
        }
    }
}

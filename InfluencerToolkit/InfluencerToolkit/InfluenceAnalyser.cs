using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public class InfluenceAnalyser
    {
        private User m_user;
        private PostsDataAggregator m_PostsDataAggregator;
        private SortedList<User, int> m_UsersSortedByLikes;
    
        public InfluenceAnalyser(User i_User)
        {
            this.m_user = i_User;
            this.m_PostsDataAggregator = new PostsDataAggregator(this.m_user);
            this.m_UsersSortedByLikes = this.m_PostsDataAggregator.UsersSortedByLikes();
        }

        internal int AnalysePostInfluenceLevel(Post i_Post)
        {
            int postInfluenceLevel = 0;

            // If the post got more likes than average, it gets 30% of the grade 
            if (i_Post.LikedBy.Count > this.m_PostsDataAggregator.AvarageCountOfLikesPerPost)
            {
                postInfluenceLevel += 30;
            }

            int previouslyInfluencedUsersCount = 0;
            foreach (KeyValuePair<User, int> userLikesPair in this.m_UsersSortedByLikes)
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

        internal float qualityInfluencePreservationFactor(Post i_Post)
        {
            float postInfluencePreservation = 0;
            foreach (KeyValuePair<User, int> userLikesPair in m_UsersSortedByLikes)
            {
                if (i_Post.LikedBy.Contains(userLikesPair.Key))
                {
                    postInfluencePreservation += userLikesPair.Value / this.m_PostsDataAggregator.TotalLikes;
                }
            }

            return postInfluencePreservation;
        }
        
        internal float quantitiveInfluencePreservationFactor(Post i_Post)
        {
            float quantitiveInfluencePreservationFactor = 0f;
            if (m_PostsDataAggregator.AvarageCountOfLikesPerPost != 0)
            {
                quantitiveInfluencePreservationFactor = i_Post.LikedBy.Count / m_PostsDataAggregator.AvarageCountOfLikesPerPost;
                if (quantitiveInfluencePreservationFactor > 1)
                {
                    quantitiveInfluencePreservationFactor = 1f;
                }
            }

            return quantitiveInfluencePreservationFactor;
        }
    }
}

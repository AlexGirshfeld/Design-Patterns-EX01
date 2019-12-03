using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using System.Linq;

namespace InfluencerToolkit
{
    public class InfluenceAnalyser
    {
        private User m_user;
        private PostsDataAggregator postsDataAggregator;
        private SortedList<User, int> m_UsersSortedByLikes;
        private int m_avarageNumberOfLikesPerPost;

        public InfluenceAnalyser(User i_user)
        {
            this.m_user = i_user;
            this.postsDataAggregator = new PostsDataAggregator(this.m_user);
            this.m_UsersSortedByLikes = this.postsDataAggregator.UsersSortedByLikes();
            this.m_avarageNumberOfLikesPerPost = postsDataAggregator.AvarageCountOfLikesPerPost;
        }

        public int GetPostInfluenceLevel(Post i_post)
        {
            int postInfluenceLevel = 0;
            if (this.m_user.Posts.Contains(i_post))
            {
                postInfluenceLevel = AnalysePostInfluenceLevel(i_post);
            } 
            else
            {  
                throw new Exception("The post you requested was not found!");
            }

            return postInfluenceLevel;
        }

        private int AnalysePostInfluenceLevel(Post i_post)
        {
            int postInfluenceLevel = 0;

            //If the post got more likes than average, it gets 30% of the grade 
            if (i_post.LikedBy.Count > this.m_avarageNumberOfLikesPerPost)
            {
                postInfluenceLevel += 30;
            }

            int previouslyInfluencedUsersCount = 0;
            foreach (KeyValuePair<User, int> userLikesPair in this.m_UsersSortedByLikes)
            {
                if(i_post.LikedBy.Contains(userLikesPair.Key))
                {
                    previouslyInfluencedUsersCount++;
                }
            }

            //The more people who liked the post but never liked user's content before, the more credit the post gets, up to 50%
            if (previouslyInfluencedUsersCount > 0)
            {
                postInfluenceLevel += ((i_post.LikedBy.Count - previouslyInfluencedUsersCount) / i_post.LikedBy.Count) * 50;
            } 
            else
            {
                postInfluenceLevel += 50;
            }

            //The more people who already liked user's content liked it, the more credit it gets, up to 20%
            postInfluenceLevel += (previouslyInfluencedUsersCount / i_post.LikedBy.Count) * 20;

            return postInfluenceLevel;
        }

        public int GetPostInfluenceIncrease(Post i_post)
        {
            int postInfluenceIncreaseLevel = 0;
            int counter = this.m_avarageNumberOfLikesPerPost;

            foreach (KeyValuePair<User, int> userLikesPair in this.m_UsersSortedByLikes)
            {
                if (i_post.LikedBy.Contains(userLikesPair.Key))
                {
                    postInfluenceIncreaseLevel += (userLikesPair.Value / (this.m_avarageNumberOfLikesPerPost + counter)); 
                }

                counter--;
            }

            return postInfluenceIncreaseLevel;
        }
    }
}

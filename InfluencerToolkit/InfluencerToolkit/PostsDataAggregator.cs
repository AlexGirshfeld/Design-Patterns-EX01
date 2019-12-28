﻿using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public class PostsDataAggregator
    {
        private FacebookObjectCollection<Post> m_CurrentUserPostsCollection;
        private int m_AvargeCountOfLikesPerPost;
        public int m_AvarageNumberOfLikesGivenToMyPostsPerUser;
        private int m_TotalNumberOfLikesRecievedInAllPosts;

        public PostsDataAggregator(User i_User)
        {
            m_CurrentUserPostsCollection = i_User.Posts;
        }

        public int TotalNumberOfLikesRecievedInAllPosts 
        {
            get { return this.m_TotalNumberOfLikesRecievedInAllPosts; }
            private set { this.m_TotalNumberOfLikesRecievedInAllPosts = value;  }
        }
        public int AvarageNumberOfLikesGivenToMyPostsPerUser
        {
            get { return this.m_AvarageNumberOfLikesGivenToMyPostsPerUser; }
            private set { this.m_AvarageNumberOfLikesGivenToMyPostsPerUser = value; }
        }


        public Dictionary<User, int> AggregateUserLikes()
        {
            Dictionary<User, int> m_usersLikesCount = new Dictionary<User, int>();
            m_TotalNumberOfLikesRecievedInAllPosts = 0;

            foreach(Post post in this.m_CurrentUserPostsCollection)
            {
                foreach(User user in post.LikedBy)
                {
                    m_TotalNumberOfLikesRecievedInAllPosts++;
                    if (m_usersLikesCount.ContainsKey(user))
                    {
                        m_usersLikesCount[user]++;
                    } 
                    else
                    {
                        m_usersLikesCount.Add(user, 1);
                    }
                }

                m_AvargeCountOfLikesPerPost += post.LikedBy.Count;
            }
            
            m_AvargeCountOfLikesPerPost /= m_CurrentUserPostsCollection.Count;
            return m_usersLikesCount;
        }

        public int CalculateAvarageNumberOfLikesGivenPerFriend(Dictionary<User, int> i_UserLikesDict)
        {
            int avarageLikes = 0;
            foreach(KeyValuePair<User, int> userLikesPair in i_UserLikesDict)
            {
                avarageLikes += userLikesPair.Value;
            }

            return avarageLikes / i_UserLikesDict.Count;
        }

        public SortedList<User, int> SortUsersByLikesCount()
        {
            SortedList<User, int> m_usersSortedByLikes = new SortedList<User, int>();
            Dictionary<User, int> m_dictionaryToSort = AggregateUserLikes();
            m_dictionaryToSort.OrderBy(x => x.Value);

            foreach(KeyValuePair<User, int> userLikesCount in m_dictionaryToSort)
            {
                m_usersSortedByLikes.Add(userLikesCount.Key, userLikesCount.Value);
            }

            return m_usersSortedByLikes;
        }

    }
}
